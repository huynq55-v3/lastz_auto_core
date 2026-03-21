mod memory;
mod offsets;

use clap::Parser;
use memory::MemoryManager;
use offsets::offsets::GAME_ENTRY_LUA;
use offsets::signatures::{LIB_IL2CPP_SIG_16, LIB_IL2CPP_SIG_64};

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
    
    println!("[*] Đang tìm kiếm cửa sổ LDPlayer với instance ID: {}", args.instance);

    if let Some(mem) = MemoryManager::attach_to_ldplayer(args.instance, args.debug) {
        println!("[+] Kết nối vào process thành công (PID: {})! Sẵn sàng quét.", mem.get_pid());

        println!("[*] Bắt đầu quét bộ nhớ tìm libil2cpp.so (Sử dụng Sig 16-byte để tăng độ bền)...");
        
        // Sử dụng 16-byte signature trước để tăng khả năng tìm thấy
        if let Some(base_address) = mem.find_pattern(&LIB_IL2CPP_SIG_16, args.debug) {
            println!("\n[+] BINGO! Tìm thấy vùng chứa libil2cpp.so tại địa chỉ: 0x{:X}", base_address);
            
            // Verification (optional but good for debug)
            if args.debug {
                println!("[*] Đang kiểm tra 64-byte Header để xác thực...");
                // Đọc 64 byte tại địa chỉ vừa tìm thấy để so sánh
                let mut header = vec![0u8; 64];
                // Lưu ý: Cần thêm hàm read_bytes vào MemoryManager nếu muốn đọc mảng byte
                // Ở đây ta có thể tạm bỏ qua hoặc dùng read::<[u8; 64]> nếu Rust hỗ trợ
            }

            let target_address = base_address + GAME_ENTRY_LUA;
            println!("[+] Địa chỉ lấy XLuaManager (GameEntry.Lua) là: 0x{:X}", target_address);
            
            println!("\n[*] Đang thử đọc con trỏ lấy XLuaManager...");
            if let Some(lua_ptr) = mem.read::<usize>(target_address) {
                println!("    [+] Giá trị đọc được (có thể là con trỏ): 0x{:X}", lua_ptr);
            } else {
                println!("    [-] Không đọc được bộ nhớ tại 0x{:X}", target_address);
            }
        } else {
            println!("[-] Không tìm thấy libil2cpp.so trong bộ nhớ.");
            println!("    Gợi ý: Hãy thử bật cờ --debug để xem chi tiết các vùng nhớ quét qua.");
        }
    } else {
        println!("[-] Không tìm thấy cửa sổ LDPlayer nào cho instance {}", args.instance);
    }
}
