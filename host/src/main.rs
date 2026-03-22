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

                        // Truyền pid, base xịn và lua_addr
                        inject_hello_world(pid, base, lua_addr);

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

pub fn inject_hello_world(pid: u32, base: usize, xlua_ptr: usize) {
    println!("[Frida] Đang khởi tạo Frida và kết nối tới thiết bị...");

    // 1. Khởi tạo Frida Context (Unsafe trong 0.17.x) và Device Manager
    let frida = unsafe { Frida::obtain() };
    let device_manager = DeviceManager::obtain(&frida);

    // 2. Kết nối tới Frida Server
    // Thử nhiều cách để tìm thiết bị (ID 'tcp', Local, hoặc Remote)
    let device = device_manager
        .get_device_by_id("tcp")
        .or_else(|_| device_manager.get_device_by_type(frida::DeviceType::USB))
        .or_else(|_| device_manager.get_remote_device("127.0.0.1:27042"));

    let device = match device {
        Ok(d) => d,
        Err(e) => {
            println!("[-] Không tìm thấy thiết bị Frida: {}", e);
            println!("[*] Danh sách thiết bị hiện có:");
            let devices = device_manager.enumerate_all_devices();
            for d in devices {
                println!(
                    "    - ID: {}, Name: {}, Type: {:?}",
                    d.get_id(),
                    d.get_name(),
                    d.get_type()
                );
            }
            panic!("DeviceLookupFailed");
        }
    };

    // 3. Đính kèm (Attach) vào Process của Game
    println!("[Frida] Đang Attach vào PID: {}...", pid);
    let session = device
        .attach(pid)
        .expect("Không thể Attach vào game. Frida Server đã chạy chưa?");

    // 4. Viết mã JavaScript Payload (Sử dụng Hex Format chuẩn chỉ)
    let js_code = format!(
        r#"
        console.log("[JS] Frida đã chui thành công vào Game!");

        // Tọa độ truyền từ Rust (Dùng format Hex chuẩn 0x...)
        var xlua_ptr = ptr("0x{:X}"); 
        var real_base = ptr("0x{:X}");
        var SafeDoStringAddr = real_base.add(0x1DB1C10);

        console.log("[JS] XLuaManager: " + xlua_ptr);
        console.log("[JS] Real Base: " + real_base);
        console.log("[JS] SafeDoString Address: " + SafeDoStringAddr);

        // --- BÍ KÍP TÌM HÀM il2cpp_string_new ---
        // Lấy export từ bản mồi nhử công khai
        var fake_export = Module.findExportByName("libil2cpp.so", "il2cpp_string_new");
        if (fake_export == null) {{
            console.log("[-] Lỗi: Không tìm thấy export il2cpp_string_new!");
        }} else {{
            // Tính Offset và áp dụng vào Base thật
            var fake_base = Module.findBaseAddress("libil2cpp.so");
            var export_offset = fake_export.sub(fake_base);
            var real_il2cpp_string_new = real_base.add(export_offset);
            
            console.log("[JS] il2cpp_string_new chuẩn nằm tại: " + real_il2cpp_string_new);

            // Khởi tạo hàm
            var il2cpp_string_new = new NativeFunction(real_il2cpp_string_new, 'pointer', ['pointer']);
            var SafeDoString = new NativeFunction(SafeDoStringAddr, 'void', ['pointer', 'pointer', 'pointer']);

            // Nội dung Lua muốn thực thi
            var luaCode = "CS.UnityEngine.Debug.LogWarning('====== HELLO WORLD TU RUST & FRIDA ======');";
            
            // Cấp phát chuỗi C và chuyển thành chuỗi IL2CPP
            var c_string_ptr = Memory.allocUtf8String(luaCode);
            var cs_string_ptr = il2cpp_string_new(c_string_ptr);

            console.log("[JS] Đang BÓP CÒ thực thi mã Lua...");
            
            // Gọi hàm game (Tham số 3 truyền NULL / 0)
            SafeDoString(xlua_ptr, cs_string_ptr, ptr(0));

            console.log("[JS] THỰC THI THÀNH CÔNG! Hãy kiểm tra Logcat!");
        }}
        "#,
        xlua_ptr, base
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
