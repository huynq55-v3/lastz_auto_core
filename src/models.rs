// File này chứa các cấu trúc dữ liệu (structs), chữ ký (signatures) 
// và các hằng số offsets dùng để map thông tin từ bộ nhớ RAM.

pub mod signatures {
}

pub mod offsets {
    // Offset từ libil2cpp_base đến GameEntry.Lua
    pub const GAME_ENTRY_LUA: usize = 0x3727FF0;
}

/// Chứa tất cả thông tin địa chỉ đã tìm thấy trong một phiên quét.
#[derive(Debug, Default, Clone)]
pub struct GameContext {
    pub process_id: u32,
    pub libil2cpp_base: usize,
    pub xlua_manager_ptr: usize,
}

#[repr(C)]
#[derive(Debug, Copy, Clone)]
pub struct XLuaManager {
    // Cấu trúc thực tế sẽ được cập nhật sau khi phân tích kỹ hơn
    pub padding: [u8; 0x10],
    pub lua_env_ptr: usize,
}
