use crate::memory_interface::MemoryInterface;

pub struct NetworkManager {
    pub address: usize,
}

impl NetworkManager {
    pub const OFFSET_SMARTFOX: usize = 0x18; // Dự đoán từ dnSpy

    pub fn new(address: usize) -> Self {
        Self { address }
    }

    pub fn is_initialized(&self) -> bool {
        self.address != 0
    }
    
    // Thêm các hàm đọc dữ liệu mạng ở đây...
}
