mod adb_manager;
mod memory;

use adb_manager::AdbManager;
use clap::Parser;
use common::game::{GameEntry, GlobalDataManager, NetworkManager};
use memory::RemoteMemory;
use std::io::{BufRead, BufReader, Write};
use std::net::TcpStream;
use std::path::PathBuf;

#[derive(Parser, Debug)]
#[command(name = "lastz_auto_host", about = "Controller cho LastZ Auto")]
struct Args {
    #[arg(short, long, default_value_t = 0)]
    instance: u32,
    #[arg(long, default_value = "C:\\LDPlayer\\LDPlayer9\\adb.exe")]
    adb_path: String,
}

fn main() {
    println!("=== LASTZ AUTO HOST - WINDOWS CONTROLLER ===");
    let args = Args::parse();
    let adb = AdbManager::new(PathBuf::from(&args.adb_path), args.instance);

    if !adb.is_device_ready() {
        println!("[-] Thiết bị chưa sẵn sàng.");
        return;
    }

    println!("[+] Thiết bị sẵn sàng. Đang triển khai Agent...");
    let local_agent = "target/x86_64-linux-android/release/lastz_auto_agent";
    let remote_agent = "/data/local/tmp/lastz_auto_agent";

    if adb.push_file(local_agent, remote_agent).is_err()
        || adb.forward_port(12345, 12345).is_err()
        || adb.run_agent(remote_agent).is_err()
    {
        println!("[-] Khởi tạo Agent thất bại!");
        return;
    }

    println!("[*] Đang kết nối tới Agent qua TCP...");
    std::thread::sleep(std::time::Duration::from_secs(2));

    match TcpStream::connect("127.0.0.1:12345") {
        Ok(mut stream) => {
            println!("[+] Kết nối thành công!");

            // 1. Tìm PID bằng lệnh pidof (Nhanh và cực kỳ chính xác trên Android)
            let pkg = "com.readygo.barrel.gphh";
            let out = adb
                .run_command(&format!("pidof {}", pkg))
                .unwrap_or_default();
            let pid = out.trim().parse::<u32>().unwrap_or(0);

            if pid == 0 {
                println!("[-] Game chưa mở! Vui lòng mở game trước khi chạy Tool.");
                return;
            }

            // 2. Yêu cầu Agent khởi tạo và tự tìm Base chuẩn
            let _ = stream.write_all(format!("INIT {}\n", pid).as_bytes());
            let mut reader = BufReader::new(stream.try_clone().unwrap());
            let mut response = String::new();
            let _ = reader.read_line(&mut response);

            let mut base = 0;
            if response.starts_with("BASE") {
                let parts: Vec<&str> = response.trim().split_whitespace().collect();
                base = usize::from_str_radix(parts[1], 10).unwrap_or(0); // parse decimal vì format format!("BASE {}", real_base)
            }

            if base == 0 {
                println!("[-] Agent không tìm thấy Bản thể thật libil2cpp.so!");
                return;
            }

            println!("    - PID Game: {}", pid);
            println!("    - libil2cpp.so Base (Real): 0x{:X}", base);

            let mem = RemoteMemory::new(stream.try_clone().unwrap());

            // 3. Vòng lặp Auto
            println!("\n[*] BẮT ĐẦU VÒNG LẶP AUTO...");
            loop {
                if let Some(entry) = GameEntry::init_from_metadata(base, &mem) {
                    let lua_addr = entry.get_lua_addr(&mem);
                    let net_addr = entry.get_network_addr(&mem);
                    let global_addr = entry.get_global_data_addr(&mem);

                    let net_mgr = NetworkManager::new(net_addr);
                    let global_data = GlobalDataManager::new(global_addr);
                    let country = global_data.get_from_country(&mem);

                    println!(
                        "\r[LOG] LuaMgr: 0x{:X} | Country: {:<5} | Net Init: {}",
                        lua_addr,
                        country,
                        net_mgr.is_initialized()
                    );
                } else {
                    print!("\r[*] Đang chờ GameEntry khởi tạo (Load game/Network)...     ");
                }

                std::io::stdout().flush().unwrap();
                std::thread::sleep(std::time::Duration::from_millis(1000));
            }
        }
        Err(e) => println!("[-] Lỗi TCP: {}", e),
    }
}
