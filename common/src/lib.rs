use serde::{Deserialize, Serialize};

pub mod memory_interface;
pub mod game;

#[derive(Debug, Default, Clone, Serialize, Deserialize)]
pub struct GameContext {
    pub process_id: u32,
    pub libil2cpp_base: usize,
}

#[repr(C)]
#[derive(Debug, Copy, Clone, Serialize, Deserialize)]
pub struct XLuaManager {
    pub padding: [u8; 0x10],
    pub lua_env_ptr: usize,
}
