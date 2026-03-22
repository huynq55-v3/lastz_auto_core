use crate::memory_interface::MemoryInterface;

pub struct GameEntry {
    pub address: usize,
}

impl GameEntry {
    // Địa chỉ con trỏ .got đã biết
    pub const PTR_GOT_GATEWAY: usize = 0x4AB58A8;

    // Offset trỏ tới vùng nhớ static_fields bên trong IL2CPP Class (Luôn là 0xB8 cho game 64-bit)
    pub const OFFSET_STATIC_FIELDS_PTR: usize = 0xB8;

    pub const OFFSET_NETWORK: usize = 0x30;
    pub const OFFSET_LUA: usize = 0x48;
    pub const OFFSET_DATA: usize = 0x58;
    pub const OFFSET_GLOBAL_DATA: usize = 0x70;

    pub fn new(address: usize) -> Self {
        Self { address }
    }

    pub fn find_base(base_libil2cpp: usize, mem: &impl MemoryInterface) -> Option<Self> {
        // Nhảy lần 1: Đọc vào bảng .got để lấy con trỏ tới Class Metadata (X20 trong ASM)
        let val = mem.read_usize(base_libil2cpp + Self::PTR_GOT_GATEWAY);
        if val == 0 {
            println!("[-] Lỗi: Cổng GOT tại 0x{:X} trống!", Self::PTR_GOT_GATEWAY);
            return None;
        }

        // Nếu giá trị nhỏ (< 0x1000000000), đây có thể là RVA (Relative Virtual Address)
        let metadata_ptr = if val < 0x1000000000 {
            println!("[DEBUG] Phát hiện RVA: 0x{:X} -> Tuyệt đối: 0x{:X}", val, base_libil2cpp + val);
            base_libil2cpp + val
        } else {
            val
        };

        // Nhảy lần 2: Đọc Metadata để lấy địa chỉ thực của Il2CppClass (LDR X8, [X20] trong ASM)
        let class_ptr = mem.read_usize(metadata_ptr);
        if class_ptr == 0 {
            println!("[-] Lỗi: Metadata tại 0x{:X} vẫn là NULL!", metadata_ptr);
            return None;
        }

        // Nhảy lần 3: Đọc vùng chứa biến tĩnh (LDR X8, [X8, #0xB8] trong ASM)
        let static_fields_ptr = mem.read_usize(class_ptr + Self::OFFSET_STATIC_FIELDS_PTR);
        if static_fields_ptr == 0 {
            println!("[-] Lỗi: Il2CppClass (0x{:X}) tồn tại, nhưng static_fields chưa khởi tạo.", class_ptr);
            return None;
        }

        println!("[+] GameEntry Static Fields: 0x{:X}", static_fields_ptr);
        Some(Self::new(static_fields_ptr))
    }

    pub fn get_network_addr(&self, mem: &impl MemoryInterface) -> usize {
        mem.read_usize(self.address + Self::OFFSET_NETWORK)
    }

    pub fn get_lua_addr(&self, mem: &impl MemoryInterface) -> usize {
        mem.read_usize(self.address + Self::OFFSET_LUA)
    }

    pub fn get_global_data_addr(&self, mem: &impl MemoryInterface) -> usize {
        mem.read_usize(self.address + Self::OFFSET_GLOBAL_DATA)
    }
}
