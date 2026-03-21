use crate::memory_interface::MemoryInterface;

pub struct GlobalDataManager {
    pub address: usize,
}

impl GlobalDataManager {
    // [FieldOffset(Offset = "0x58")] public string fromCountry;
    pub const OFFSET_FROM_COUNTRY: usize = 0x58; 

    pub fn new(address: usize) -> Self {
        Self { address }
    }

    pub fn get_from_country(&self, mem: &impl MemoryInterface) -> String {
        let string_ptr = mem.read_usize(self.address + Self::OFFSET_FROM_COUNTRY);
        mem.read_string_utf16(string_ptr).unwrap_or_else(|| "Unknown".to_string())
    }

    pub fn is_initialized(&self) -> bool {
        self.address != 0
    }
}
