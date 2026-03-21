use serde::{Deserialize, Serialize};

pub mod offsets {
    // Offset từ libil2cpp_base đến GameEntry.Lua
    pub const GAME_ENTRY_LUA: usize = 0x3727FF0;
}

#[derive(Debug, Default, Clone, Serialize, Deserialize)]
pub struct GameContext {
    pub process_id: u32,
    pub libil2cpp_base: usize,
    pub xlua_manager_ptr: usize,
}

#[repr(C)]
#[derive(Debug, Copy, Clone, Serialize, Deserialize)]
pub struct XLuaManager {
    pub padding: [u8; 0x10],
    pub lua_env_ptr: usize,
}
