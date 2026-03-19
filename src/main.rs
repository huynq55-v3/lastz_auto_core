use std::fs::File;
use std::io::{self, BufRead};
use std::os::unix::fs::FileExt;
use sysinfo::System;

const GAME_PACKAGE_NAME: &str = "com.readygo.barrel.gphh";

fn get_process_id(process_name: &str) -> Option<u32> {
    let mut sys = System::new_all();
    sys.refresh_all();
    for (pid, process) in sys.processes() {
        let name = process.name();
        let cmd = process.cmd().join(" ");
        if name.contains(process_name) || cmd.contains(process_name) {
            return Some(pid.as_u32());
        }
    }
    None
}

fn find_il2cpp_base(pid: u32) -> Option<usize> {
    let maps_path = format!("/proc/{}/maps", pid);
    let mem_path = format!("/proc/{}/mem", pid);

    let maps_file = File::open(&maps_path).expect("Không mở được maps");
    let mem_file = File::open(&mem_path).expect("Không mở được mem");
    let reader = io::BufReader::new(maps_file);

    let mut largest_size = 0;
    let mut best_address = 0;

    for line in reader.lines() {
        let line = line.unwrap();

        // Quét các vùng nhớ có cờ thực thi hoặc đọc từ APK
        if line.contains(".apk") && line.contains("r-") {
            let parts: Vec<&str> = line.split_whitespace().collect();
            let addr_range: Vec<&str> = parts[0].split('-').collect();

            let start_addr = usize::from_str_radix(addr_range[0], 16).unwrap_or(0);
            let end_addr = usize::from_str_radix(addr_range[1], 16).unwrap_or(0);
            let size = end_addr - start_addr;

            // Bỏ qua rác nhỏ dưới 30MB
            if size > 30_000_000 {
                let mut magic = [0u8; 4];
                if mem_file
                    .read_exact_at(&mut magic, start_addr as u64)
                    .is_ok()
                {
                    // Nếu đúng là file ELF
                    if magic == [0x7F, 0x45, 0x4C, 0x46] {
                        // So sánh xem thằng này có béo nhất không
                        if size > largest_size {
                            largest_size = size;
                            best_address = start_addr;
                        }
                    }
                }
            }
        }
    }

    if best_address != 0 {
        println!(
            "[+] Đã lọc ra file IL2CPP (Béo nhất: {} MB)",
            largest_size / 1024 / 1024
        );
        Some(best_address)
    } else {
        None
    }
}

fn main() {
    println!("[*] Đang tìm kiếm tiến trình game: {}", GAME_PACKAGE_NAME);
    if let Some(pid) = get_process_id(GAME_PACKAGE_NAME) {
        println!("[+] Tìm thấy game với PID: {}", pid);

        println!("[*] Đang dùng Magic Header dò tìm Base Address...");
        if let Some(base_addr) = find_il2cpp_base(pid) {
            println!("==================================================");
            println!("[🔥] TÌM THẤY RỒI! BASE ADDRESS: 0x{:X}", base_addr);
            println!("==================================================");

            // Từ đây, ông cộng Base Address này với Offset tìm được bằng IDA Pro
            // để ra địa chỉ thật của biến Máu, Tọa độ, v.v...
        } else {
            println!("[-] Vẫn không thấy. Khả năng game chưa qua mốc 31%.");
        }
    } else {
        println!("[-] Không tìm thấy tiến trình game.");
    }
}
