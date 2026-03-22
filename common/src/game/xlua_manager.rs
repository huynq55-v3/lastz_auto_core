use crate::memory_interface::MemoryInterface;

pub struct XLuaManager {
    pub address: usize,
}

impl XLuaManager {
    // Các Offset quan trọng bóc từ dnSpy (C#)
    pub const OFFSET_LUA_SCRIPTS: usize = 0x10; // Dictionary chứa các script đã load
    pub const OFFSET_LUA_ENV: usize = 0x20; // Con trỏ môi trường Lua (LuaEnv) - Rất quan trọng
    pub const OFFSET_UI_MANAGER: usize = 0x28; // Quản lý UI
    pub const OFFSET_LUA_UPDATE: usize = 0x30; // Delegate vòng lặp Update của Lua
    pub const OFFSET_USE_NATIVE: usize = 0x41; // bool m_useNative

    pub fn new(address: usize) -> Self {
        Self { address }
    }

    pub fn is_initialized(&self) -> bool {
        self.address != 0
    }

    /// Lấy địa chỉ của máy ảo Lua (LuaEnv)
    pub fn get_lua_env_addr(&self, mem: &impl MemoryInterface) -> usize {
        mem.read_usize(self.address + Self::OFFSET_LUA_ENV)
    }

    /// Lấy địa chỉ của UIManager
    pub fn get_ui_manager_addr(&self, mem: &impl MemoryInterface) -> usize {
        mem.read_usize(self.address + Self::OFFSET_UI_MANAGER)
    }

    /// Kiểm tra xem game đã bật chế độ Native Lua chưa
    pub fn is_use_native(&self, mem: &impl MemoryInterface) -> bool {
        mem.read_bool(self.address + Self::OFFSET_USE_NATIVE)
    }
}
