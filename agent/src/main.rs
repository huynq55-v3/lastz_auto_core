use common::GameContext;
use std::fs;
use std::io::{BufRead, BufReader, Read, Write, Seek, SeekFrom};
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
        if reader.read_line(&mut line).is_err() || line.is_empty() { break; }
        let parts: Vec<&str> = line.trim().split_whitespace().collect();
        if parts.is_empty() { continue; }

        match parts[0] {
            "SET_PID" => {
                if parts.len() < 2 { continue; }
                current_pid = parts[1].parse::<u32>().unwrap_or(0);
                let _ = stream.write_all(b"OK\n");
            }
            "READ" => {
                if parts.len() < 3 { continue; }
                let addr = usize::from_str_radix(parts[1].trim_start_matches("0x"), 16).unwrap_or(0);
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

fn read_mem(pid: u32, addr: usize, size: usize) -> Option<Vec<u8>> {
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
