mod adb_manager;

use std::path::PathBuf;
use std::io::{Write, Read, BufRead, BufReader};
use std::net::TcpStream;
use clap::Parser;
use adb_manager::AdbManager;
use common::GameContext;

#[derive(Parser, Debug)]
#[command(name = "lastz_auto_host", about = "Controller cho LastZ Auto")]
struct Args {
    #[arg(short, long, default_value_t = 0)]
    instance: u32,

    #[arg(short, long)]
    debug: bool,

    #[arg(long, default_value = "C:\\LDPlayer\\LDPlayer9\\adb.exe")]
    adb_path: String,
}

fn main() {
    println!("=== LASTZ AUTO HOST - WINDOWS CONTROLLER ===");
    let args = Args::parse();
    
    let adb = AdbManager::new(PathBuf::from(&args.adb_path), args.instance);
    
    if !adb.is_device_ready() {
        println!("[-] Thiết bị (Instance {}) chưa sẵn sàng hoặc không tìm thấy.", args.instance);
        return;
    }
    
    println!("[+] Thiết bị sẵn sàng. Đang triển khai Agent...");
    
    // 1. Push Agent lên giả lập
    let local_agent = "target/x86_64-linux-android/release/lastz_auto_agent";
    let remote_agent = "/data/local/tmp/lastz_auto_agent";
    
    if let Err(e) = adb.push_file(local_agent, remote_agent) {
        println!("[-] Không thể push Agent: {}", e);
        return;
    }
    
    // 2. Forward port
    if let Err(e) = adb.forward_port(12345, 12345) {
        println!("[-] Không thể forward port: {}", e);
        return;
    }
    
    // 3. Chạy Agent
    println!("[+] Đang chạy Agent...");
    if let Err(e) = adb.run_agent(remote_agent) {
        println!("[-] Không thể chạy Agent: {}", e);
        return;
    }
    
    // 4. Kết nối và lấy thông tin
    println!("[*] Đang kết nối tới Agent qua TCP...");
    std::thread::sleep(std::time::Duration::from_secs(2)); // Chờ agent khởi động
    
    match TcpStream::connect("127.0.0.1:12345") {
        Ok(mut stream) => {
            println!("[+] Kết nối thành công! Đang yêu cầu Game Context...");
            let _ = stream.write_all(b"GET_CONTEXT\n");
            
            let mut reader = BufReader::new(&stream);
            let mut response = String::new();
            if reader.read_line(&mut response).is_ok() {
                if response.starts_with("ERROR") {
                    println!("[-] Agent báo lỗi: {}", response.trim());
                } else {
                    match serde_json::from_str::<GameContext>(&response) {
                        Ok(ctx) => {
                            println!("\n[+] ĐÃ NHẬN DỮ LIỆU TỪ AGENT:");
                            println!("    - PID Game: {}", ctx.process_id);
                            println!("    - libil2cpp.so Base: 0x{:X}", ctx.libil2cpp_base);
                            println!("    - XLuaManager ptr: 0x{:X}", ctx.xlua_manager_ptr);

                            if ctx.xlua_manager_ptr != 0 {
                                // Thử đọc XLuaManager struct
                                let size = std::mem::size_of::<common::XLuaManager>();
                                let read_cmd = format!("READ 0x{:X} {}\n", ctx.xlua_manager_ptr, size);
                                let _ = stream.write_all(read_cmd.as_bytes());
                                
                                let mut data = vec![0u8; size];
                                if stream.read_exact(&mut data).is_ok() {
                                    let xlua: common::XLuaManager = unsafe { std::ptr::read(data.as_ptr() as *const _) };
                                    println!("    - LuaEnv ptr: 0x{:X}", xlua.lua_env_ptr);
                                    println!("\n[***] HỆ THỐNG HOST-AGENT ĐÃ THÔNG SUỐT! [***]");
                                }
                            }
                        }
                        Err(e) => println!("[-] Không thể parse JSON từ Agent: {}", e),
                    }
                }
            }
        }
        Err(e) => println!("[-] Không thể kết nối tới Agent: {}", e),
    }
}
