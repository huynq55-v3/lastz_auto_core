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
    let frida_server_name = "frida-server-17.8.2-android-x86_64";
    if let Err(e) = adb.deploy_frida_server(frida_server_name) {
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

pub fn inject_hello_world(pid: u32, _base: usize, _xlua_ptr: usize) {
    println!("[Frida] Đang khởi tạo Frida và kết nối tới thiết bị...");

    let frida = unsafe { Frida::obtain() };
    let device_manager = DeviceManager::obtain(&frida);

    let device = device_manager
        .get_device_by_id("tcp")
        .or_else(|_| device_manager.get_device_by_type(frida::DeviceType::USB))
        .or_else(|_| device_manager.get_remote_device("127.0.0.1:27042"))
        .expect("Không tìm thấy thiết bị Frida. Hãy chạy adb forward.");

    println!("[Frida] Đang Attach vào PID: {}...", pid);
    let session = device
        .attach(pid)
        .expect("Không thể Attach vào game.");

    // Dùng format! để truyền base vào JS nếu cần, hoặc dùng raw string nếu Rust đã in rồi
    let js_code = format!(
        r#"
        (function() {{
            try {{
                console.log("[JS] --- BẢN CHIÊU HỒI v9 (FIXED MODULE) ---");
                
                function findExportSafe(libName, exportName) {{
                    var mod = null;
                    try {{ mod = Process.getModuleByName(libName); }} catch(e) {{}}
                    if (!mod) {{
                        Process.enumerateModules().forEach(function(m) {{
                            if (m.name.toLowerCase().indexOf(libName.toLowerCase()) !== -1) {{
                                mod = m;
                            }}
                        }});
                    }}
                    return mod ? mod.findExportByName(exportName) : null;
                }}

                var itf_ptr = findExportSafe("libhoudini.so", "NativeBridgeItf");
                var swap_addr = findExportSafe("libEGL.so", "eglSwapBuffers");
                var il2cpp_base = ptr("0x{:X}");

                console.log("[?] NativeBridgeItf: " + itf_ptr);
                console.log("[?] eglSwapBuffers: " + swap_addr);

                if (!itf_ptr || !swap_addr) {{
                    console.log("[-] Thiếu thành phần Bridge.");
                    return;
                }}

                // Offset 16: loadLibrary(const char* libpath, int flag)
                var loadLibrary = new NativeFunction(itf_ptr.add(16).readPointer(), 'pointer', ['pointer', 'int']);
                // Offset 24: getTrampoline(void* handle, const char* name, const char* shorty, uint32_t len)
                var get_tramp = new NativeFunction(itf_ptr.add(24).readPointer(), 'pointer', ['pointer', 'pointer', 'pointer', 'uint32']);

                var hooked = false;
                Interceptor.attach(swap_addr, {{
                    onEnter: function(args) {{
                        if (hooked) return;
                        
                        try {{
                            console.log("\n[!!!] TRÚNG BẪY x86_64! Đang tải thư viện qua Houdini...");
                            
                            // 1. Tải libil2cpp.so qua Cầu nối để lấy Handle
                            // Đôi khi Houdini cần đường dẫn tuyệt đối tĩnh. Ta quét maps để lấy
                            var lib_path = "libil2cpp.so";
                            try {{
                                var fd = new File("/proc/self/maps", "r");
                                var content = fd.readText();
                                fd.close();
                                var lines = content.split("\n");
                                for (var i = 0; i < lines.length; i++) {{
                                    if (lines[i].indexOf("libil2cpp.so") !== -1) {{
                                        var parts = lines[i].trim().split(" ");
                                        lib_path = parts[parts.length - 1];
                                        break;
                                    }}
                                }}
                            }} catch(e) {{}}
                            
                            console.log("[*] Đường dẫn thực tế libil2cpp: " + lib_path);

                            var handle_1 = loadLibrary(Memory.allocUtf8String(lib_path), 1);
                            var handle_2 = loadLibrary(Memory.allocUtf8String("libil2cpp.so"), 1);
                            
                            var handles_to_test = [
                                {{ name: "Absolute Path", ptr: handle_1 }},
                                {{ name: "File Name", ptr: handle_2 }},
                                {{ name: "RTLD_DEFAULT (-1)", ptr: ptr("-1") }},
                                {{ name: "NULL Handle (0)", ptr: ptr("0") }},
                            ];

                            var name_domain = Memory.allocUtf8String("il2cpp_domain_get");
                            var name_attach = Memory.allocUtf8String("il2cpp_thread_attach");
                            var shorty = Memory.allocUtf8String("V"); // JNI shorty
                            
                            var t_domain = ptr(0);
                            var t_attach = ptr(0);
                            var working_handle_name = "None";

                            for (var i = 0; i < handles_to_test.length; i++) {{
                                var h = handles_to_test[i];
                                if (!h.ptr.isNull() || h.name.indexOf("0") !== -1) {{
                                    console.log("    - Testing Handle [" + h.name + "]: " + h.ptr);
                                    try {{
                                        var td = get_tramp(h.ptr, name_domain, shorty, 1);
                                        var ta = get_tramp(h.ptr, name_attach, shorty, 1);
                                        if (!td.isNull() && !ta.isNull()) {{
                                            t_domain = td;
                                            t_attach = ta;
                                            working_handle_name = h.name;
                                            console.log("      [+++] THÀNH CÔNG TẠI HANDLE NÀY!");
                                            break;
                                        }} else {{
                                            console.log("      [-] Trả về NULL.");
                                        }}
                                    }} catch(e) {{
                                        console.log("      [-] CRASH khi dùng handle này.");
                                    }}
                                }}
                            }}

                            if (t_domain.isNull() || t_attach.isNull()) {{
                                console.log("[-] Không tìm được Handle nào hoạt động.");
                                return;
                            }}

                            console.log("\n[+] Dùng Trampoline Domain: " + t_domain);
                            console.log("[+] Dùng Trampoline Attach: " + t_attach);

                            if (!t_domain.isNull() && !t_attach.isNull()) {{
                                var fn_domain_get = new NativeFunction(t_domain, 'pointer', []);
                                var fn_attach = new NativeFunction(t_attach, 'pointer', ['pointer']);
                                
                                // Gọi hàm qua Bridge
                                var domain = fn_domain_get();
                                console.log("[+] GỌI THÀNH CÔNG! Domain: " + domain);
                                fn_attach(domain);
                                console.log("[++] XÁC NHẬN: Cầu truyền thông x86_64 -> ARM64 đã THÔNG SUỐT hoàn toàn!");
                                
                                hooked = true;
                            }} else {{
                                console.log("[-] Không tạo được bàn nhún. Dấu hiệu sai Shorty hoặc hàm không được Export.");
                                hooked = true;
                            }}
                        }} catch(e) {{
                            console.log("[-] Lỗi khi tải Cầu: " + e.message);
                            hooked = true;
                        }}
                    }}
                }});

                console.log("[+] Đã bao vây. Hãy vào game và nhấn gì đó!");

            }} catch (e) {{
                console.log("[JS ERROR] " + (e.stack || e.message));
            }}
        }})();
        "#,
        _base
    );

    let mut options = ScriptOption::default();
    let mut script = session
        .create_script(&js_code, &mut options)
        .expect("Lỗi tạo Script");

    script.handle_message(LogHandler).unwrap();
    script.load().expect("Lỗi Load Script");

    println!("[Frida] Hệ thống đã sẵn sàng.");
    println!("[*] Nhấn Enter để kết thúc quá trình.");
    let mut idle = String::new();
    let _ = std::io::stdin().read_line(&mut idle);
}
