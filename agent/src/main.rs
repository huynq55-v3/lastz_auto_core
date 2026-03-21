use std::fs::{self, File};
use std::io::{BufRead, BufReader, Write, Read, Seek, SeekFrom};
use std::net::{TcpListener, TcpStream};
use common::{offsets::GAME_ENTRY_LUA, GameContext};

fn log(msg: &str) {
    let mut file = fs::OpenOptions::new()
        .create(true)
        .append(true)
        .open("/data/local/tmp/agent.log")
        .unwrap();
    let _ = writeln!(file, "[{}] {}", chrono::Local::now().format("%H:%M:%S"), msg);
}

fn main() {
    log("=== AGENT STARTED (Root) ===");
    
    let listener = TcpListener::bind("0.0.0.0:12345").expect("Không thể bind port 12345");
    log("Lắng nghe trên port 12345...");

    for stream in listener.incoming() {
        match stream {
            Ok(mut stream) => {
                log("Host đã kết nối.");
                handle_client(&mut stream);
            }
            Err(e) => log(&format!("Lỗi kết nối: {}", e)),
        }
    }
}

fn handle_client(stream: &mut TcpStream) {
    let mut buffer = [0u8; 1024];
    loop {
        match stream.read(&mut buffer) {
            Ok(n) if n > 0 => {
                let msg = String::from_utf8_lossy(&buffer[..n]);
                let cmd = msg.trim();
                log(&format!("Nhận lệnh: {}", cmd));
                
                if cmd == "GET_CONTEXT" {
                    log("Đang quét libil2cpp.so...");
                    if let Some((pid, base)) = find_game_by_lib("libil2cpp.so") {
                        log(&format!("Game tìm thấy: PID {}, Base 0x{:X}", pid, base));
                        
                        // Đọc XLuaManager ptr
                        let target_addr = base + GAME_ENTRY_LUA;
                        log(&format!("Đọc XLuaManager ptr tại 0x{:X}...", target_addr));
                        let xlua_ptr = read_memory::<usize>(pid, target_addr).unwrap_or(0);
                        log(&format!("XLuaManager ptr: 0x{:X}", xlua_ptr));
                        
                        let ctx = GameContext {
                            process_id: pid,
                            libil2cpp_base: base,
                            xlua_manager_ptr: xlua_ptr,
                        };
                        match serde_json::to_string(&ctx) {
                            Ok(json) => {
                                let _ = stream.write_all(json.as_bytes());
                                let _ = stream.write_all(b"\n");
                                log("Đã gửi Context JSON.");
                            }
                            Err(e) => log(&format!("Lỗi serialize JSON: {}", e)),
                        }
                    } else {
                        log("Lỗi: Không tìm thấy game.");
                        let _ = stream.write_all(b"ERROR: LIB_NOT_FOUND\n");
                    }
                } else if cmd.starts_with("READ") {
                    // Lệnh: READ <address> <size>
                    // Lưu ý: Giữ PID ở tầm global hoặc cache nó
                    let parts: Vec<&str> = cmd.split_whitespace().collect();
                    if parts.len() == 3 {
                        let addr = usize::from_str_radix(parts[1].trim_start_matches("0x"), 16).unwrap_or(0);
                        let size = parts[2].parse::<usize>().unwrap_or(0);
                        if let Some((pid, _)) = find_game_by_lib("libil2cpp.so") {
                            if let Some(data) = read_raw(pid, addr, size) {
                                let _ = stream.write_all(&data);
                            }
                        }
                    }
                }
            }
            _ => break,
        }
    }
}

fn find_game_by_lib(lib_name: &str) -> Option<(u32, usize)> {
    let package_name = "com.readygo.barrel.gphh";
    if let Ok(entries) = fs::read_dir("/proc") {
        for entry in entries.flatten() {
            let path = entry.path();
            if path.is_dir() {
                if let Some(pid_str) = path.file_name().and_then(|s| s.to_str()) {
                    if let Ok(pid) = pid_str.parse::<u32>() {
                        let cmd_path = path.join("cmdline");
                        let is_target = if let Ok(cmdline) = fs::read_to_string(cmd_path) {
                            cmdline.contains(package_name)
                        } else {
                            false
                        };

                        if is_target {
                            if let Some(base) = find_library_base(pid, lib_name) {
                                return Some((pid, base));
                            }
                        }
                    }
                }
            }
        }
    }
    None
}

fn find_library_base(pid: u32, lib_name: &str) -> Option<usize> {
    let maps_path = format!("/proc/{}/maps", pid);
    let file = fs::File::open(maps_path).ok()?;
    let reader = BufReader::new(file);

    for line in reader.lines() {
        let line = line.ok()?;
        if line.contains(lib_name) {
            let parts: Vec<&str> = line.split('-').collect();
            if !parts.is_empty() {
                return usize::from_str_radix(parts[0], 16).ok();
            }
        }
    }
    None
}

fn read_memory<T: Copy>(pid: u32, address: usize) -> Option<T> {
    let data = read_raw(pid, address, std::mem::size_of::<T>())?;
    if data.len() == std::mem::size_of::<T>() {
        Some(unsafe { *(data.as_ptr() as *const T) })
    } else {
        None
    }
}

fn read_raw(pid: u32, address: usize, size: usize) -> Option<Vec<u8>> {
    let mem_path = format!("/proc/{}/mem", pid);
    let mut file = File::open(mem_path).ok()?;
    let mut buffer = vec![0u8; size];
    
    file.seek(SeekFrom::Start(address as u64)).ok()?;
    if file.read_exact(&mut buffer).is_ok() {
        Some(buffer)
    } else {
        None
    }
}
