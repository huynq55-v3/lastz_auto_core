use std::fs;
use std::io::{BufRead, BufReader, Read, Seek, SeekFrom, Write};
use std::net::{TcpListener, TcpStream};

fn main() {
    let listener = TcpListener::bind("0.0.0.0:12345").expect("Could not bind port");
    println!("Agent listening on port 12345...");

    for stream in listener.incoming() {
        match stream {
            Ok(stream) => {
                handle_client(stream);
            }
            Err(e) => eprintln!("Connection failed: {}", e),
        }
    }
}

fn handle_client(mut stream: TcpStream) {
    let mut reader = BufReader::new(stream.try_clone().expect("Failed to clone stream"));

    // TRẠNG THÁI PID (Do Host thiết lập)
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
            "SET_PID" => {
                if parts.len() < 2 {
                    continue;
                }
                current_pid = parts[1].parse::<u32>().unwrap_or(0);
                if current_pid != 0 {
                    println!(
                        "[*] Đã nhận PID: {}. (Dump tự động đã tắt để tiết kiệm dung lượng)",
                        current_pid
                    );
                    // dump_libil2cpp_from_ram(current_pid, "/sdcard/dumped_il2cpp.so");
                    scan_real_il2cpp_base(current_pid);
                }
                let _ = stream.write_all(b"OK\n");
            }
            "SCAN" => {
                if current_pid != 0 {
                    let results = scan_real_il2cpp_base(current_pid);
                    let _ = stream.write_all(results.as_bytes());
                    let _ = stream.write_all(b"SCAN_END\n");
                } else {
                    let _ = stream.write_all(b"ERROR_NO_PID\n");
                }
            }
            "DUMP" => {
                if current_pid != 0 {
                    dump_libil2cpp_from_ram(current_pid, "/sdcard/dumped_il2cpp.so");
                    let _ = stream.write_all(b"DUMP_OK\n");
                } else {
                    let _ = stream.write_all(b"ERROR_NO_PID\n");
                }
            }
            "READ" => {
                if parts.len() < 3 {
                    continue;
                }
                let addr =
                    usize::from_str_radix(parts[1].trim_start_matches("0x"), 16).unwrap_or(0);
                let size = parts[2].parse::<usize>().unwrap_or(0);

                if current_pid != 0 {
                    if let Some(data) = read_mem(current_pid, addr, size) {
                        let _ = stream.write_all(&data);
                    } else {
                        // Trả về buffer rỗng nếu lỗi để không làm treo Host
                        let _ = stream.write_all(&vec![0u8; size]);
                    }
                } else {
                    let _ = stream.write_all(&vec![0u8; size]);
                }
            }
            "WRITE" => {
                let _ = stream.write_all(b"NOT_IMPLEMENTED\n");
            }
            _ => {
                let _ = stream.write_all(b"UNKNOWN\n");
            }
        }
    }
}

pub fn dump_libil2cpp_from_ram(pid: u32, output_path: &str) {
    println!(
        "[*] Đang tiến hành Dump libil2cpp.so từ RAM (PID: {})...",
        pid
    );

    let maps_path = format!("/proc/{}/maps", pid);
    let mem_path = format!("/proc/{}/mem", pid);

    let maps_content = match fs::read_to_string(&maps_path) {
        Ok(content) => content,
        Err(e) => {
            println!("[-] Lỗi: Không thể đọc maps! {}", e);
            return;
        }
    };

    let mut mem_file = match fs::File::open(&mem_path) {
        Ok(file) => file,
        Err(e) => {
            println!("[-] Lỗi: Yêu cầu quyền Root để đọc mem! {}", e);
            return;
        }
    };

    let mut base_addr: Option<usize> = None;
    let mut max_end_addr: usize = 0;

    // Bước 1: Tính toán dung lượng thật của thư viện trên RAM
    for line in maps_content.lines().filter(|l| l.contains("libil2cpp.so")) {
        let parts: Vec<&str> = line.split_whitespace().collect();
        let addr_range: Vec<&str> = parts[0].split('-').collect();
        let start = usize::from_str_radix(addr_range[0], 16).unwrap();
        let end = usize::from_str_radix(addr_range[1], 16).unwrap();

        if base_addr.is_none() {
            base_addr = Some(start);
        }
        if end > max_end_addr {
            max_end_addr = end;
        }
    }

    if base_addr.is_none() {
        println!("[-] Thất bại: Không tìm thấy libil2cpp.so trong memory map.");
        return;
    }

    let base = base_addr.unwrap();
    let total_size = max_end_addr - base;
    println!(
        "[*] Base: 0x{:X} | Kích thước dự kiến: {} bytes",
        base, total_size
    );

    // Tạo một mảng byte rỗng (chứa toàn số 0) làm khung
    let mut dump_buffer = vec![0u8; total_size];

    // Bước 2: Bắt đầu hút dữ liệu từ các vùng nhớ hợp lệ
    for line in maps_content.lines().filter(|l| l.contains("libil2cpp.so")) {
        let parts: Vec<&str> = line.split_whitespace().collect();
        let perms = parts[1]; // Phân quyền (r-xp, rw-p...)

        // Chỉ hút những vùng có cờ 'r' (đọc được)
        if !perms.starts_with('r') {
            continue;
        }

        let addr_range: Vec<&str> = parts[0].split('-').collect();
        let start = usize::from_str_radix(addr_range[0], 16).unwrap();
        let end = usize::from_str_radix(addr_range[1], 16).unwrap();
        let size = end - start;
        let offset = start - base; // Vị trí ghi vào file

        // Dịch chuyển đầu từ đọc vào đúng tọa độ RAM
        if let Err(e) = mem_file.seek(SeekFrom::Start(start as u64)) {
            println!("  [-] Seek failed at 0x{:X}: {}", start, e);
            continue;
        }

        // Hút dữ liệu nhét thẳng vào mảng
        if let Err(e) = mem_file.read_exact(&mut dump_buffer[offset..offset + size]) {
            println!(
                "  [-] Read failed at 0x{:X} (size 0x{:X}): {}",
                start, size, e
            );
            continue;
        }
        println!(
            "  -> Hút thành công phân vùng: 0x{:X} - 0x{:X} [{}]",
            start, end, perms
        );
    }

    // Bước 3: Xuất ra file
    match fs::File::create(output_path) {
        Ok(mut out_file) => {
            if let Err(e) = out_file.write_all(&dump_buffer) {
                println!("[-] Lỗi khi ghi file: {}", e);
            } else {
                println!("[+] Hoàn tất! File đã được Dump ra: {}", output_path);
            }
        }
        Err(e) => println!("[-] Không thể tạo file Output {}: {}", output_path, e),
    }
}

fn read_mem(pid: u32, addr: usize, size: usize) -> Option<Vec<u8>> {
    let _ = (pid, addr, size); // suppress unused warnings for non-unix targets
    #[cfg(unix)]
    {
        if let Ok(mut file) = fs::File::open(format!("/proc/{}/mem", pid)) {
            let mut buffer = vec![0u8; size];
            if file.seek(SeekFrom::Start(addr as u64)).is_ok() {
                if file.read_exact(&mut buffer).is_ok() {
                    return Some(buffer);
                }
            }
        }
    }
    None
}

pub fn scan_real_il2cpp_base(pid: u32) -> String {
    let mut results = String::new();
    results.push_str("\n[*] --- BẮT ĐẦU QUÉT TÌM BẢN THỂ THẬT CỦA IL2CPP ---\n");
    let maps_path = format!("/proc/{}/maps", pid);

    if let Ok(maps_content) = fs::read_to_string(&maps_path) {
        for line in maps_content.lines() {
            // Chúng ta tìm các vùng nhớ có quyền Thực Thi (r-xp)
            // if line.contains("r-xp") {
            let parts: Vec<&str> = line.split_whitespace().collect();
            if parts.is_empty() {
                continue;
            }

            let addr_range: Vec<&str> = parts[0].split('-').collect();
            if addr_range.len() < 2 {
                continue;
            }

            let start = usize::from_str_radix(addr_range[0], 16).unwrap_or(0);
            let end = usize::from_str_radix(addr_range[1], 16).unwrap_or(0);
            let size_mb = (end - start) / (1024 * 1024);

            // IL2CPP thường rất nặng (từ 30MB đến 150MB).
            // Lọc những vùng nhớ lớn hơn 20MB.
            if size_mb > 0 {
                let path = if parts.len() > 5 {
                    parts[5]
                } else {
                    "[ẨN DANH / ANONYMOUS]"
                };

                let log = format!("[?] Phát hiện vùng nhớ đáng ngờ: 0x{:X} - 0x{:X} | Kích thước: {} MB | Path: {}\n", 
                        start, end, size_mb, path);
                println!("{}", log.trim());
                results.push_str(&log);

                // Nếu nó là ẩn danh, khả năng 99% đây là Base xịn mà Packer đang giấu!
            }
            // }
        }
    }
    results.push_str("[*] --- KẾT THÚC QUÉT ---\n");
    results
}
