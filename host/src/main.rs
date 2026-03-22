mod adb_manager;
mod memory;

use adb_manager::AdbManager;
use clap::Parser;
use common::game::{GameEntry, GlobalDataManager, NetworkManager};
use frida::{DeviceManager, Frida, Message, ScriptHandler, ScriptOption};
use memory::RemoteMemory;
use std::io::{BufRead, BufReader, Write};
use std::net::TcpStream;
use std::path::PathBuf;
use std::time::Duration;

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

    // --- TRIỂN KHAI FRIDA SERVER ---
    println!("[+] Đang triển khai Frida Server...");
    let frida_server_local = "frida-server-17.8.2-android-x86_64";
    if let Err(e) = adb.deploy_frida_server(frida_server_local) {
        println!("[-] Triển khai Frida Server thất bại: {}", e);
        // Có thể tiếp tục nếu server đã chạy sẵn, nhưng tốt nhất là báo lỗi
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

                    // --- TEST INJECTION ---
                    if lua_addr != 0 {
                        println!("\n[*] Đã nắm được XLuaManager. Tiến hành Test Injection...");
                        inject_hello_world(pid, lua_addr);
                        
                        println!("[*] Đã Test xong. Dừng vòng lặp để kiểm tra logcat.");
                        break; 
                    }
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

struct LogHandler;

impl ScriptHandler for LogHandler {
    fn on_message(&mut self, message: Message, _data: Option<Vec<u8>>) {
        if let Message::Log(log) = message {
            println!("[Frida Log] {:?}: {}", log.level, log.payload);
        } else {
            println!("[Frida Msg] {:?}", message);
        }
    }
}

/// Hàm này nhận vào PID của game và Địa chỉ của XLuaManager mà tool ông vừa quét được
pub fn inject_hello_world(pid: u32, xlua_ptr: usize) {
    println!("[Frida] Đang khởi tạo Frida và kết nối tới thiết bị...");

    // 1. Khởi tạo Frida Context (Unsafe trong 0.17.x) và Device Manager
    let frida = unsafe { Frida::obtain() };
    let device_manager = DeviceManager::obtain(&frida);
    
    // 2. Kết nối tới Frida Server
    // Thử nhiều cách để tìm thiết bị (ID 'tcp', Local, hoặc Remote)
    let device = device_manager.get_device_by_id("tcp")
        .or_else(|_| device_manager.get_device_by_type(frida::DeviceType::USB))
        .or_else(|_| device_manager.get_remote_device("127.0.0.1:27042"));

    let device = match device {
        Ok(d) => d,
        Err(e) => {
            println!("[-] Không tìm thấy thiết bị Frida: {}", e);
            println!("[*] Danh sách thiết bị hiện có:");
            let devices = device_manager.enumerate_all_devices();
            for d in devices {
                println!("    - ID: {}, Name: {}, Type: {:?}", d.get_id(), d.get_name(), d.get_type());
            }
            panic!("DeviceLookupFailed");
        }
    };

    // 3. Đính kèm (Attach) vào Process của Game
    println!("[Frida] Đang Attach vào PID: {}...", pid);
    let session = device
        .attach(pid)
        .expect("Không thể Attach vào game. Frida Server đã chạy chưa?");

    // 3. Viết mã JavaScript Payload
    let js_code = format!(
        r#"
        console.log("[JS] Frida đã chui thành công vào Game!");

        // Tọa độ truyền từ Rust
        var xlua_ptr = ptr("{}"); 
        var SafeDoStringAddr = Module.findBaseAddress("libil2cpp.so").add(0x1DB1C10);

        console.log("[JS] XLuaManager: " + xlua_ptr);
        console.log("[JS] SafeDoString Address: " + SafeDoStringAddr);

        // --- BÍ KÍP TẠO SYSTEM.STRING CHO IL2CPP ---
        var il2cpp_string_new_addr = Module.findExportByName("libil2cpp.so", "il2cpp_string_new");
        var il2cpp_string_new = new NativeFunction(il2cpp_string_new_addr, 'pointer', ['pointer']);

        var luaCode = "CS.UnityEngine.Debug.LogWarning('====== HELLO WORLD TỪ RUST & FRIDA ======');";
        
        var c_string_ptr = Memory.allocUtf8String(luaCode);
        var cs_string_ptr = il2cpp_string_new(c_string_ptr);

        // --- GỌI HÀM GAME ---
        var SafeDoString = new NativeFunction(SafeDoStringAddr, 'void', ['pointer', 'pointer', 'pointer']);

        console.log("[JS] Đang thực thi mã Lua...");
        SafeDoString(xlua_ptr, cs_string_ptr, ptr(0));

        console.log("[JS] Thực thi thành công!");
    "#,
        xlua_ptr
    );

    // 4. Bơm (Inject) JS vào game
    let mut options = ScriptOption::default();
    let mut script = session
        .create_script(&js_code, &mut options)
        .expect("Lỗi tạo Script");

    // Lắng nghe log từ JS gửi về Rust (Dùng struct LogHandler thay vì closure)
    script
        .handle_message(LogHandler)
        .expect("Lỗi thiết lập log handler");

    script.load().expect("Lỗi Load Script");

    // Đợi 3 giây để JS chạy xong trước khi đóng kết nối
    std::thread::sleep(Duration::from_secs(3));
    println!("[Frida] Hoàn tất quá trình Inject.");
}
