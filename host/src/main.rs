mod adb_manager;
mod memory;

use adb_manager::AdbManager;
use clap::Parser;
use common::game::{GameEntry, NetworkManager, GlobalDataManager};
use common::memory_interface::MemoryInterface;
use common::GameContext;
use memory::RemoteMemory;
use std::io::{BufRead, BufReader, Read, Write};
use std::net::TcpStream;
use std::path::PathBuf;

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
        println!(
            "[-] Thiết bị (Instance {}) chưa sẵn sàng hoặc không tìm thấy.",
            args.instance
        );
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
    std::thread::sleep(std::time::Duration::from_secs(2));

    match TcpStream::connect("127.0.0.1:12345") {
        Ok(mut stream) => {
            println!("[+] Kết nối thành công! Đang tìm kiếm game qua ADB...");

            // Tự tìm PID và Base qua ADB thay vì nhờ Agent
            let pkg = "com.readygo.barrel.gphh";
            let mut pid = 0;
            let mut base = 0;

            // Tìm PID
            if let Ok(out) = adb.run_command(&format!("ps -A | grep {}", pkg)) {
                if let Some(line) = out.lines().next() {
                    let parts: Vec<&str> = line.split_whitespace().collect();
                    if parts.len() > 1 {
                        pid = parts[1].parse::<u32>().unwrap_or(0);
                    }
                }
            }

            // Tìm Base
            if pid != 0 {
                if let Ok(out) = adb.run_command(&format!("grep libil2cpp.so /proc/{}/maps", pid)) {
                    if let Some(line) = out.lines().next() {
                        if let Some(base_str) = line.split('-').next() {
                            base = usize::from_str_radix(base_str, 16).unwrap_or(0);
                        }
                    }
                }
            }

            if pid == 0 || base == 0 {
                println!("[-] Không tìm thấy game hoặc không lấy được Base address!");
                return;
            }

            println!("    - PID Game: {}", pid);
            println!("    - libil2cpp.so Base: 0x{:X}", base);

            // Gửi PID cho Agent
            let _ = stream.write_all(format!("SET_PID {}\n", pid).as_bytes());
            
            // Đọc phản hồi OK từ Agent (đọc từng byte để tránh BufReader ăn mất dữ liệu sau đó)
            let mut ok_buf = [0u8; 1];
            loop {
                let _ = stream.read_exact(&mut ok_buf);
                if ok_buf[0] == b'\n' { break; }
            }

            let mut ctx = GameContext::default();
            ctx.process_id = pid;
            ctx.libil2cpp_base = base;

            // KHỞI TẠO HỆ THỐNG WRAPPER
            let mem = RemoteMemory::new(stream.try_clone().unwrap());

            // 1. Tìm GameEntry động từ .got
            if let Some(entry) = GameEntry::find_base(ctx.libil2cpp_base, &mem) {
                println!("    - GameEntry Base: 0x{:X}", entry.address);

                // VÒNG LẶP CHÍNH CỦA AUTO
                println!("\n[*] BẮT ĐẦU VÒNG LẶP AUTO...");
                loop {
                    // Đọc các Manager chính
                    let lua_addr = entry.get_lua_addr(&mem);
                    let net_addr = entry.get_network_addr(&mem);
                    let global_addr = entry.get_global_data_addr(&mem);

                    // Sử dụng Wrapper để "bọc" các địa chỉ này lại
                    let net_mgr = NetworkManager::new(net_addr);
                    let global_data = GlobalDataManager::new(global_addr);

                    let country = global_data.get_from_country(&mem);

                    println!(
                        "\r[LOG] LuaMgr: 0x{:X} | Country: {} | Net Initialized: {}",
                        lua_addr,
                        country,
                        net_mgr.is_initialized()
                    );

                    std::io::stdout().flush().unwrap();
                    std::thread::sleep(std::time::Duration::from_millis(1000));
                }
            } else {
                println!("[-] Không tìm thấy GameEntry qua .got!");
            }
        }
        Err(e) => println!("[-] Không thể kết nối tới Agent: {}", e),
    }
}
