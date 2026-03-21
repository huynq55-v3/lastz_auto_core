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

    /// Lấy địa chỉ thực tế của GameEntry từ vùng nhớ .got
    pub fn find_base(base_libil2cpp: usize, mem: &impl MemoryInterface) -> Option<Self> {
        let got_value = mem.read_usize(base_libil2cpp + Self::PTR_GOT_GATEWAY);
        if got_value == 0 { return None; }

        let mut class_ptr = got_value;
        if class_ptr < base_libil2cpp {
            class_ptr += base_libil2cpp;
        }
        
        println!("\n[DEBUG] class_ptr: 0x{:X}", class_ptr);
        
        // Dump 0x100 bytes để soi cấu trúc Il2CppClass
        if let Some(dump) = mem.read_raw(class_ptr, 0x100) {
            println!("[DEBUG] Class Dump (first 64 bytes):");
            for i in 0..8 {
                let offset = i * 8;
                let val = usize::from_le_bytes(dump[offset..offset+8].try_into().unwrap());
                println!("  +0x{:02X}: 0x{:012X}", offset, val);
            }
        }

        // Thử tìm static_fields bằng cách quét các pointer hợp lệ
        // (Thường là offset 0xB0 hoặc 0xB8)
        let static_fields_ptr = mem.read_usize(class_ptr + Self::OFFSET_STATIC_FIELDS_PTR);
        
        if static_fields_ptr != 0 && static_fields_ptr > 0x10000000 {
            Some(Self::new(static_fields_ptr))
        } else {
            // Thử offset 0xB0 nếu 0xB8 không ra gì
            let alt_ptr = mem.read_usize(class_ptr + 0xB0);
            if alt_ptr != 0 && alt_ptr > 0x10000000 {
                println!("[DEBUG] Found static_fields at 0xB0 instead: 0x{:X}", alt_ptr);
                Some(Self::new(alt_ptr))
            } else {
                None
            }
        }
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
