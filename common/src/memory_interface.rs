pub trait MemoryInterface {
    fn read_raw(&self, address: usize, size: usize) -> Option<Vec<u8>>;

    fn read_u64(&self, address: usize) -> u64 {
        self.read::<u64>(address).unwrap_or(0)
    }

    fn read_usize(&self, address: usize) -> usize {
        self.read::<usize>(address).unwrap_or(0)
    }

    fn read_bool(&self, address: usize) -> bool {
        self.read::<u8>(address).unwrap_or(0) != 0
    }

    fn read<T: Copy>(&self, address: usize) -> Option<T> {
        let size = std::mem::size_of::<T>();
        let data = self.read_raw(address, size)?;
        if data.len() == size {
            Some(unsafe { std::ptr::read(data.as_ptr() as *const T) })
        } else {
            None
        }
    }

    /// Đọc chuỗi System.String (UTF-16) của C#/IL2CPP
    fn read_string_utf16(&self, address: usize) -> Option<String> {
        if address == 0 { return None; }
        
        // Offset 0x10 là chiều dài chuỗi (int32)
        let length = self.read::<i32>(address + 0x10)? as usize;
        if length == 0 { return Some(String::new()); }
        if length > 1024 { return None; } // Giới hạn an toàn

        // Offset 0x14 là mảng ký tự
        let data = self.read_raw(address + 0x14, length * 2)?;
        let u16_data: Vec<u16> = data.chunks_exact(2)
            .map(|c| u16::from_le_bytes([c[0], c[1]]))
            .collect();
            
        Some(String::from_utf16_lossy(&u16_data))
    }
}
