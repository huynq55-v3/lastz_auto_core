use crate::memory_interface::MemoryInterface;

pub struct GameEntry {
    pub address: usize, // Địa chỉ của static_fields
}

impl GameEntry {
    pub const PTR_GOT_GATEWAY: usize = 0x4AB58A8;
    pub const OFFSET_STATIC_FIELDS_PTR: usize = 0xB8;

    pub const OFFSET_NETWORK: usize = 0x30;
    pub const OFFSET_LUA: usize = 0x48;
    pub const OFFSET_DATA: usize = 0x58;
    pub const OFFSET_GLOBAL_DATA: usize = 0x70;

    pub fn new(address: usize) -> Self {
        Self { address }
    }

    pub fn init_from_metadata(base_libil2cpp: usize, mem: &impl MemoryInterface) -> Option<Self> {
        // Nhảy 1: Đọc GOT lấy Class Metadata (Giờ đây chắc chắn là Pointer xịn, không phải RVA)
        let class_metadata_ptr = mem.read_usize(base_libil2cpp + Self::PTR_GOT_GATEWAY);
        if class_metadata_ptr == 0 || class_metadata_ptr < 0x1000000000 {
            return None; // Game chưa khởi tạo xong
        }

        // Nhảy 2: Bốc Class Pointer từ Metadata
        let class_ptr = mem.read_usize(class_metadata_ptr);
        if class_ptr == 0 {
            return None;
        }

        // Nhảy 3: Lấy kho chứa tĩnh
        let static_fields_ptr = mem.read_usize(class_ptr + Self::OFFSET_STATIC_FIELDS_PTR);
        if static_fields_ptr == 0 {
            return None;
        }

        Some(Self::new(static_fields_ptr))
    }

    // Các hàm Getter giữ nguyên
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
