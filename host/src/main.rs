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
                            
                            // Cấu hình Handle (Đã xác nhận thành công với RTLD_DEFAULT = -1)
                            var handle = ptr("-1");
                            
                            // Các hàm IL2CPP chuẩn cần được "Bắc Cầu" (Trampolined)
                            var exports_to_bridge = [
                                "il2cpp_domain_get",
                                "il2cpp_thread_attach",
                                "il2cpp_domain_get_assemblies",
                                "il2cpp_assembly_get_image",
                                "il2cpp_class_from_name",
                                "il2cpp_class_get_method_from_name",
                                "il2cpp_string_new",
                                "il2cpp_runtime_invoke"
                            ];
                            
                            var api = {{}};
                            var success_count = 0;
                            var shorty = Memory.allocUtf8String("V");
                            
                            console.log("[*] Đang xin cấp quyền (Trampoline) cho " + exports_to_bridge.length + " hàm IL2CPP...");
                            for (var i = 0; i < exports_to_bridge.length; i++) {{
                                var name = exports_to_bridge[i];
                                var name_ptr = Memory.allocUtf8String(name);
                                var tramp = get_tramp(handle, name_ptr, shorty, 1);
                                if (!tramp.isNull()) {{
                                    api[name] = tramp;
                                    success_count++;
                                }} else {{
                                    console.log("[-] Lỗi xin biên dịch: " + name);
                                }}
                            }}
                            
                            if (success_count < exports_to_bridge.length) {{
                                console.log("[-] Không cấp đủ quyền, hủy bỏ chiến dịch.");
                                hooked = true;
                                return;
                            }}
                            
                            console.log("[+] Đã bắc cầu thành công " + success_count + " IL2CPP APIs.");
                            
                            // Định nghĩa x86_64 Interface (Vỏ bọc cho các hàm ARM64 thực sự)
                            var fn_domain_get = new NativeFunction(api.il2cpp_domain_get, 'pointer', []);
                            var fn_thread_attach = new NativeFunction(api.il2cpp_thread_attach, 'pointer', ['pointer']);
                            var fn_get_assemblies = new NativeFunction(api.il2cpp_domain_get_assemblies, 'pointer', ['pointer', 'pointer']);
                            var fn_get_image = new NativeFunction(api.il2cpp_assembly_get_image, 'pointer', ['pointer']);
                            var fn_class_from_name = new NativeFunction(api.il2cpp_class_from_name, 'pointer', ['pointer', 'pointer', 'pointer']);
                            var fn_get_method = new NativeFunction(api.il2cpp_class_get_method_from_name, 'pointer', ['pointer', 'pointer', 'int']);
                            var fn_string_new = new NativeFunction(api.il2cpp_string_new, 'pointer', ['pointer']);
                            var fn_runtime_invoke = new NativeFunction(api.il2cpp_runtime_invoke, 'pointer', ['pointer', 'pointer', 'pointer', 'pointer']);
                            
                            // ========================
                            // QUÁ TRÌNH THỰC THI CHÍNH
                            // ========================

                            // 1. Thread Attach
                            var domain = fn_domain_get();
                            fn_thread_attach(domain);
                            console.log("[+] Đã liên kết Thread với ARM64 (Domain: " + domain + ")");
                            
                            // 2. Tìm MethodInfo của XLuaManager.SafeDoString
                            var size_ptr = Memory.alloc(8);
                            var assemblies = fn_get_assemblies(domain, size_ptr);
                            var count = Process.pointerSize === 8 ? size_ptr.readU64() : size_ptr.readU32(); 
                            
                            var target_method = ptr(0);
                            var str_empty = Memory.allocUtf8String("");
                            var str_XLuaManager = Memory.allocUtf8String("XLuaManager");
                            var str_SafeDoString = Memory.allocUtf8String("SafeDoString");
                            
                            for (var i = 0; i < count; i++) {{
                                var assembly = assemblies.add(i * Process.pointerSize).readPointer();
                                var image = fn_get_image(assembly);
                                var klass = fn_class_from_name(image, str_empty, str_XLuaManager);
                                if (!klass.isNull()) {{
                                    target_method = fn_get_method(klass, str_SafeDoString, 1);
                                    if (!target_method.isNull()) {{
                                        console.log("[+++] TÌM THẤY CỐT LÕI: SafeDoString MethodInfo @ " + target_method);
                                        break;
                                    }}
                                }}
                            }}
                            
                            if (target_method.isNull()) {{
                                console.log("[-] Không tìm thấy SafeDoString trong Assembly-CSharp.");
                                hooked = true;
                                return;
                            }}
                            
                            // 3. Chuẩn bị Instance và gọi Script
                            var xlua_instance = ptr("0x{:X}");
                            if (xlua_instance.isNull()) {{
                                console.log("[-] Pointer XLuaManager lỗi/trống từ Rust.");
                                hooked = true;
                                return;
                            }}
                            
                            console.log("[*] Bơm LUA vào địa chỉ Instance: " + xlua_instance);
                            var lua_script = Memory.allocUtf8String("CS.UnityEngine.Debug.LogError('====== FRIDA BRIDGE X86 -> ARM64 TỪ LASTZ_AUTO ======')");
                            var il2cpp_str = fn_string_new(lua_script);
                            
                            var params = Memory.alloc(Process.pointerSize);
                            params.writePointer(il2cpp_str);
                            var exc = Memory.alloc(Process.pointerSize);
                            exc.writePointer(ptr(0));
                            
                            fn_runtime_invoke(target_method, xlua_instance, params, exc);
                            
                            console.log("[+++++] CHIẾN THẮNG TUYỆT ĐỐI! NHIỆM VỤ ĐÃ HOÀN TẤT!");
                            hooked = true;
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
        _xlua_ptr
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
