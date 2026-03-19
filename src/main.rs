use std::fs::File;
use std::io::{self, BufRead, Read, Seek, SeekFrom};
use sysinfo::System;

const GAME_PACKAGE_NAME: &str = "com.readygo.barrel.gphh";

fn get_process_id(process_name: &str) -> Option<u32> {
    let mut sys = System::new_all();
    sys.refresh_all();
    for (pid, process) in sys.processes() {
        if process.name().contains(process_name) || process.cmd().join(" ").contains(process_name) {
            return Some(pid.as_u32());
        }
    }
    None
}

// Hàm quét trực tiếp chuỗi UTF-16 trong RAM
fn scan_memory_for_string(pid: u32, target_str: &str) {
    let maps_path = format!("/proc/{}/maps", pid);
    let mem_path = format!("/proc/{}/mem", pid);

    let maps_file = File::open(&maps_path).expect("[-] Không mở được maps");
    let mut mem_file = File::open(&mem_path).expect("[-] Không mở được mem. Nhớ dùng sudo!");
    let reader = io::BufReader::new(maps_file);

    // Chuyển chuỗi cần tìm sang định dạng UTF-16 (Mỗi ký tự 2 bytes)
    let target_bytes: Vec<u8> = target_str
        .encode_utf16()
        .flat_map(|c| c.to_le_bytes())
        .collect();

    println!("[*] Đang quét toàn bộ RAM tìm chữ: '{}'...", target_str);
    let mut found_count = 0;

    for line in reader.lines() {
        let line = line.unwrap();
        // Chỉ quét các vùng nhớ có quyền Đọc/Ghi và thường là Heap (ẩn danh)
        if line.contains("rw-p") && (!line.contains("/") || line.contains("[anon:")) {
            let parts: Vec<&str> = line.split_whitespace().collect();
            let addr_range: Vec<&str> = parts[0].split('-').collect();

            let start_addr = usize::from_str_radix(addr_range[0], 16).unwrap_or(0);
            let end_addr = usize::from_str_radix(addr_range[1], 16).unwrap_or(0);
            let size = end_addr - start_addr;

            // Bỏ qua các vùng quá lớn để tránh treo máy (> 50MB)
            if size > 50_000_000 {
                continue;
            }

            let mut buffer = vec![0u8; size];
            if mem_file.seek(SeekFrom::Start(start_addr as u64)).is_ok() {
                if mem_file.read_exact(&mut buffer).is_ok() {
                    // Thuật toán tìm kiếm chuỗi (Naive search)
                    for i in 0..=(buffer.len() - target_bytes.len()) {
                        if &buffer[i..i + target_bytes.len()] == target_bytes.as_slice() {
                            let match_addr = start_addr + i;
                            found_count += 1;
                            println!("\n[+] BINGO! Tìm thấy tại địa chỉ: 0x{:X}", match_addr);

                            // In ra 100 bytes xung quanh để xem toàn bộ thông tin máy
                            let context_start = if i > 30 { i - 30 } else { 0 };
                            let context_end = if i + 100 < buffer.len() {
                                i + 100
                            } else {
                                buffer.len()
                            };

                            let utf16_context: Vec<u16> = buffer[context_start..context_end]
                                .chunks_exact(2)
                                .map(|chunk| u16::from_le_bytes([chunk[0], chunk[1]]))
                                .collect();

                            println!(
                                "    Nội dung xung quanh: {}",
                                String::from_utf16_lossy(&utf16_context)
                            );
                        }
                    }
                }
            }
        }
    }

    if found_count == 0 {
        println!("[-] Không tìm thấy chuỗi này trong RAM. (Đảm bảo đã vào tận sảnh game chưa?)");
    } else {
        println!("\n[*] Tổng cộng tìm thấy {} kết quả.", found_count);
    }
}

fn main() {
    println!("=== LASTZ AUTO CORE - MEMORY SCANNER ===");
    let pid = match get_process_id(GAME_PACKAGE_NAME) {
        Some(p) => p,
        None => {
            println!("[-] Game chưa bật!");
            return;
        }
    };
    println!("[+] PID: {}", pid);

    // 1. Quét tìm UUID (Thay bằng UUID ông lấy được từ logcat)
    scan_memory_for_string(pid, "ff3ed1f9159333e52806623c223c2c1b");

    // 2. Quét tìm AppsFlyer ID (Nếu UUID kia không ra, nó có thể dùng AFID)
    // scan_memory_for_string(pid, "1773894997945");
}
