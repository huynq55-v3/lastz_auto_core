use std::fs;
use std::io::{BufRead, BufReader, Read, Seek, SeekFrom, Write};
use std::net::{TcpListener, TcpStream};

fn main() {
    let listener = TcpListener::bind("0.0.0.0:12345").expect("Could not bind port");
    println!("[Agent] Đang lắng nghe trên cổng 12345...");

    for stream in listener.incoming() {
        match stream {
            Ok(stream) => {
                handle_client(stream);
            }
            Err(e) => eprintln!("[Agent] Lỗi kết nối: {}", e),
        }
    }
}

fn handle_client(mut stream: TcpStream) {
    let mut reader = BufReader::new(stream.try_clone().expect("Failed to clone stream"));
    let mut current_pid: u32 = 0;

    loop {
        let mut line = String::new();
        if reader.read_line(&mut line).is_err() || line.is_empty() {
            break;
        }
        let parts: Vec<&str> = line.trim().split_whitespace().collect();
        if parts.is_empty() {
            continue;
        }

        match parts[0] {
            // Host gửi lệnh INIT <PID>. Agent sẽ tự tìm Base thật và trả về.
            "INIT" => {
                if parts.len() < 2 {
                    continue;
                }
                current_pid = parts[1].parse::<u32>().unwrap_or(0);

                if current_pid != 0 {
                    println!(
                        "[Agent] Đã nhận PID: {}. Đang tìm Bản thể thật libil2cpp.so...",
                        current_pid
                    );
                    if let Some(real_base) = find_real_il2cpp_base(current_pid) {
                        println!("[Agent] Tìm thấy Base chuẩn: 0x{:X}", real_base);
                        let _ = stream.write_all(format!("BASE {}\n", real_base).as_bytes());
                    } else {
                        let _ = stream.write_all(b"ERROR_BASE_NOT_FOUND\n");
                    }
                }
            }
            "READ" => {
                if parts.len() < 3 || current_pid == 0 {
                    continue;
                }
                let addr =
                    usize::from_str_radix(parts[1].trim_start_matches("0x"), 16).unwrap_or(0);
                let size = parts[2].parse::<usize>().unwrap_or(0);

                if let Some(data) = read_mem(current_pid, addr, size) {
                    let _ = stream.write_all(&data);
                } else {
                    let _ = stream.write_all(&vec![0u8; size]); // Trả về mảng byte 0 nếu lỗi
                }
            }
            _ => {
                let _ = stream.write_all(b"UNKNOWN_CMD\n");
            }
        }
    }
}

// Lõi thông minh của Agent: Tự tìm Base xịn
fn find_real_il2cpp_base(pid: u32) -> Option<usize> {
    let maps_path = format!("/proc/{}/maps", pid);
    let maps_content = fs::read_to_string(&maps_path).ok()?;

    let got_offset = 0x4AB58A8;
    let expected_rva = 0x4CE1DA0; // RVA nguyên thủy từ file gốc

    let mut potential_bases = Vec::new();

    // Bước 1: Thu thập tất cả các đầu mút của libil2cpp.so (Cả thật lẫn giả đều có offset 00000000)
    for line in maps_content.lines() {
        if line.contains("libil2cpp.so") {
            let addr_str = line.split('-').next().unwrap_or("");
            if let Ok(base_addr) = usize::from_str_radix(addr_str, 16) {
                if !potential_bases.contains(&base_addr) {
                    potential_bases.push(base_addr);
                }
            }
        }
    }

    if potential_bases.is_empty() {
        return None;
    }

    // Bước 2: Dùng định lý Relocation để test từng thằng
    for base_addr in potential_bases {
        if let Some(got_data) = read_mem(pid, base_addr + got_offset, 8) {
            let got_value = usize::from_le_bytes(got_data.try_into().unwrap());

            println!(
                "[Agent] Thử Base: 0x{:X} | Giá trị tại GOT: 0x{:X}",
                base_addr, got_value
            );

            // NẾU GIÁ TRỊ TẠI GOT BẰNG ĐÚNG RVA -> Đây là bản thô từ ổ cứng (Mồi nhử)
            if got_value == expected_rva {
                println!("    -> Bản copy thô (Mồi nhử). Bỏ qua.");
                continue;
            }

            // NẾU GIÁ TRỊ TẠI GOT LÀ MỘT POINTER (Lớn hơn Base) -> ĐÃ ĐƯỢC OS RELOCATE!
            if got_value > base_addr {
                println!("    -> CHÍNH XÁC LÀ BẢN THỂ THẬT!");
                return Some(base_addr);
            }
        }
    }

    None
}

// Đọc memory thô (dành riêng cho Agent)
fn read_mem(pid: u32, addr: usize, size: usize) -> Option<Vec<u8>> {
    let _ = (pid, addr, size);
    #[cfg(unix)]
    {
        if let Ok(mut file) = fs::File::open(format!("/proc/{}/mem", pid)) {
            let mut buffer = vec![0u8; size];
            if file.seek(SeekFrom::Start(addr as u64)).is_ok()
                && file.read_exact(&mut buffer).is_ok()
            {
                return Some(buffer);
            }
        }
    }
    None
}
