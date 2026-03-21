mod memory;
mod models;

use clap::Parser;
use memory::MemoryManager;

#[derive(Parser, Debug)]
#[command(name = "lastz_auto_core", about = "Memory Scanner cho LDPlayer")]
struct Args {
    #[arg(short, long, default_value_t = 0)]
    instance: u32,

    #[arg(short, long)]
    debug: bool,
}

fn main() {
    println!("=== LASTZ AUTO CORE - WINDOWS MEMORY SCANNER ===");
    let args = Args::parse();

    println!(
        "[*] Đang tìm kiếm cửa sổ LDPlayer với instance ID: {}",
        args.instance
    );

    if let Some(mem) = MemoryManager::attach_to_ldplayer(args.instance, args.debug) {
        println!(
            "[+] Kết nối vào process thành công (PID: {})! Sẵn sàng quét.",
            mem.get_pid()
        );

        println!("[*] Đang khởi tạo dữ liệu game...");

        if let Some(ctx) = mem.initialize_game_context(args.debug) {
            println!("\n[+] KHỞI TẠO THÀNH CÔNG:");
            println!("    - libil2cpp.so: 0x{:X}", ctx.libil2cpp_base);
            println!("    - XLuaManager ptr: 0x{:X}", ctx.xlua_manager_ptr);

            if ctx.xlua_manager_ptr == 0 {
                println!("\n[!] Cảnh báo: XLuaManager ptr là 0x0. Có thể logic tìm kiếm bị sai hoặc game chưa load xong.");
            } else {
                println!("\n[+] Sẵn sàng lấy thông tin từ XLuaManager.");
            }
        } else {
            println!("\n[-] THẤT BẠI: Không tìm thấy libil2cpp.so hoặc dữ liệu cần thiết.");
            println!("    Gợi ý: Hãy thử bật cờ --debug để xem chi tiết quá trình quét.");
        }
    } else {
        println!(
            "[-] Không tìm thấy cửa sổ LDPlayer nào cho instance {}",
            args.instance
        );
    }
}
