use std::ffi::c_void;
use sysinfo::System;
use windows::Win32::Foundation::{CloseHandle, FALSE, HANDLE};
use windows::Win32::System::Diagnostics::Debug::ReadProcessMemory;
use windows::Win32::System::Threading::{OpenProcess, PROCESS_QUERY_INFORMATION, PROCESS_VM_READ};
use windows::Win32::System::Memory::{VirtualQueryEx, MEMORY_BASIC_INFORMATION, MEM_COMMIT};

use crate::models::{offsets::GAME_ENTRY_LUA, GameContext};

pub struct MemoryManager {
    pid: u32,
    handle: HANDLE,
}

impl MemoryManager {
    /// Khởi tạo toàn bộ thông tin Game (libil2cpp base, XLuaManager ptr)
    /// Trình tự: Tìm libil2cpp -> Xác thực -> Tính toán và đọc XLuaManager
    pub fn initialize_game_context(&self, debug: bool) -> Option<GameContext> {
        let mut ctx = GameContext {
            process_id: self.pid,
            ..Default::default()
        };

        if debug {
            println!("[DEBUG] Đang tìm kiếm libil2cpp.so...");
        }

        // 1. Tìm chuỗi "libil2cpp.so" trong bộ nhớ
        let target_lib_name = "libil2cpp.so";
        if debug { println!("[DEBUG] Đang tìm kiếm chuỗi '{}' trong bộ nhớ...", target_lib_name); }
        let string_locations = self.find_string(target_lib_name, false);
        
        let mut best_base = 0;
        for str_addr in string_locations {
            if debug { println!("[DEBUG] Tìm thấy chuỗi tại 0x{:X}, đang truy vết ngược tìm Header...", str_addr); }
            
            // 2. Truy vết ngược từ str_addr để tìm Header ELF (7F 45 4C 46)
            // Quét ngược tối đa 256MB - một số thư viện lớn có thể có offset xa
            let mut check_addr = str_addr & !0xFFF; // Căn lề page
            let limit_addr = if str_addr > 0x10000000 { str_addr - 0x10000000 } else { 0 };
            
            if debug { println!("[DEBUG] Đang quét ngược từ 0x{:X} về 0x{:X}...", check_addr, limit_addr); }
            
            while check_addr >= limit_addr {
                if let Some(header) = self.read_raw(check_addr, 64) {
                    if header[0..4] == [0x7F, 0x45, 0x4C, 0x46] { // .ELF Magic
                        let arch = header[0x12];
                        let class = header[0x04]; // 1 = 32-bit, 2 = 64-bit
                        
                        if debug {
                            println!("[DEBUG] Found ELF at 0x{:X} (Arch: 0x{:02X}, Class: {}) near string 0x{:X}", 
                                     check_addr, arch, class, str_addr);
                        }

                        // ARM64: Arch 0xB7, Class 2 | ARM 32: Arch 0x28, Class 1
                        if (arch == 0xB7 && class == 0x02) || (arch == 0x28 && class == 0x01) {
                            best_base = check_addr;
                            if debug { 
                                let arch_name = if arch == 0xB7 { "ARM64" } else { "ARM32" };
                                println!("[DEBUG] XÁC NHẬN CHÍNH XÁC libil2cpp.so ({}) tại: 0x{:X}", arch_name, best_base); 
                            }
                            break;
                        }
                    }
                }
                check_addr -= 0x1000;
            }
            if best_base != 0 { break; }
        }

        if best_base == 0 {
            if debug { println!("[DEBUG] Không tìm thấy thư viện ARM64 nào khớp với tên '{}'", target_lib_name); }
            return None;
        }

        ctx.libil2cpp_base = best_base;

        // 3. Đọc XLuaManager ptr
        let target_address = best_base + GAME_ENTRY_LUA;
        if let Some(lua_ptr) = self.read::<usize>(target_address) {
            ctx.xlua_manager_ptr = lua_ptr;
            if debug { println!("[DEBUG] Đọc được XLuaManager pointer: 0x{:X}", lua_ptr); }
        } else if debug {
            println!("[DEBUG] Thất bại khi đọc XLuaManager pointer tại 0x{:X}", target_address);
        }

        Some(ctx)
    }

    /// Tìm và mở Process LDPlayer
    pub fn attach_to_ldplayer(instance_id: u32, debug: bool) -> Option<Self> {
        let mut sys = System::new_all();
        sys.refresh_all();

        let id_str = instance_id.to_string();
        let leidian_name = format!("leidian{}", id_str);
        let index_str = format!("index={}", id_str);
        let is_main_instance = instance_id == 0;
        let mut candidate_pids = Vec::new();

        for (pid, process) in sys.processes() {
            let name = process.name().to_lowercase();
            if name.contains("boxheadless") || name.contains("dnplayer") {
                let cmd_args = process.cmd();
                let cmd_full = cmd_args.join(" ");

                if debug {
                    println!("[DEBUG] Found LD process: PID={}, Name='{}'", pid, process.name());
                    println!("[DEBUG] Cmd: {}", cmd_full);
                }

                let mut matched = false;
                if cmd_full.contains(&leidian_name) || cmd_full.contains(&index_str) {
                    matched = true;
                } else if is_main_instance {
                    if cmd_full.contains("leidian") && !cmd_full.contains("leidian1") && !cmd_full.contains("leidian2") {
                        matched = true;
                    }
                }

                if matched {
                    if name.contains("boxheadless") {
                        return Self::open_process(pid.as_u32());
                    } else {
                        candidate_pids.push(pid.as_u32());
                    }
                }
            }
        }

        if let Some(pid) = candidate_pids.first() {
            return Self::open_process(*pid);
        }
        None
    }

    fn open_process(pid: u32) -> Option<Self> {
        unsafe {
            match OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_INFORMATION, FALSE, pid) {
                Ok(handle) => Some(Self { pid, handle }),
                Err(_) => None,
            }
        }
    }

    pub fn get_pid(&self) -> u32 {
        self.pid
    }

    /// QUÉT NHANH (Page-aligned): Tìm tất cả địa chỉ gốc có thể là Module
    pub fn find_module_base(&self, signature: &[u8], _debug: bool) -> Vec<usize> {
        let mut results = Vec::new();
        let mut address: usize = 0;
        let mut info = MEMORY_BASIC_INFORMATION::default();
        let mut page_buffer = vec![0u8; signature.len()];

        while unsafe {
            VirtualQueryEx(
                self.handle,
                Some(address as *const c_void),
                &mut info,
                std::mem::size_of::<MEMORY_BASIC_INFORMATION>(),
            )
        } != 0
        {
            let is_readable = info.State == MEM_COMMIT && 
                             (info.Protect == windows::Win32::System::Memory::PAGE_READONLY ||
                              info.Protect == windows::Win32::System::Memory::PAGE_READWRITE ||
                              info.Protect == windows::Win32::System::Memory::PAGE_EXECUTE_READ ||
                              info.Protect == windows::Win32::System::Memory::PAGE_EXECUTE_READWRITE);

            if is_readable {
                let region_size = info.RegionSize;
                let region_start = info.BaseAddress as usize;
                
                for page_addr in (region_start..region_start + region_size).step_by(0x1000) {
                    let mut bytes_read = 0;
                    let success = unsafe {
                        ReadProcessMemory(
                            self.handle,
                            page_addr as *const c_void,
                            page_buffer.as_mut_ptr() as *mut c_void,
                            signature.len(),
                            Some(&mut bytes_read),
                        )
                    };

                    if success.is_ok() && bytes_read == signature.len() {
                        if page_buffer == signature {
                            results.push(page_addr);
                        }
                    }
                }
            }

            let next_addr = (info.BaseAddress as usize).saturating_add(info.RegionSize);
            if next_addr <= address || next_addr >= 0x7FFFFFFFFFFFFFFF {
                break;
            }
            address = next_addr;
        }
        results
    }

    /// Tìm chuỗi trong bộ nhớ (Case sensitive)
    pub fn find_string(&self, target: &str, debug: bool) -> Vec<usize> {
        let mut results = Vec::new();
        let target_bytes = target.as_bytes();
        let target_len = target_bytes.len();
        
        let mut current_addr = 0usize;
        let max_addr = 0x200000000usize; // 8GB limit cho LDPlayer
        
        while current_addr < max_addr {
            let mut mbi = MEMORY_BASIC_INFORMATION::default();
            let size = unsafe {
                VirtualQueryEx(
                    self.handle,
                    Some(current_addr as *const c_void),
                    &mut mbi,
                    std::mem::size_of::<MEMORY_BASIC_INFORMATION>(),
                )
            };

            if size == 0 { break; }

            // Chỉ quét vùng nhớ đã COMMIT và có quyền READ
            let is_readable = mbi.State == MEM_COMMIT && 
                             (mbi.Protect == windows::Win32::System::Memory::PAGE_READONLY ||
                              mbi.Protect == windows::Win32::System::Memory::PAGE_READWRITE ||
                              mbi.Protect == windows::Win32::System::Memory::PAGE_EXECUTE_READ ||
                              mbi.Protect == windows::Win32::System::Memory::PAGE_EXECUTE_READWRITE);
            
            if is_readable {
                let region_end = mbi.BaseAddress as usize + mbi.RegionSize;
                let mut scan_ptr = current_addr;
                
                // Đọc theo chunk lớn (e.g. 1MB) để tối ưu RPM
                let chunk_size = 1024 * 1024;
                while scan_ptr < region_end {
                    let to_read = (region_end - scan_ptr).min(chunk_size);
                    if let Some(data) = self.read_raw(scan_ptr, to_read) {
                        let mut offset = 0;
                        while let Some(pos) = data[offset..].windows(target_len).position(|w| w == target_bytes) {
                            results.push(scan_ptr + offset + pos);
                            offset += pos + 1; // Tiếp tục tìm sau vị trí vừa thấy
                            if results.len() > 50 { break; } // Giới hạn 50 kết quả
                        }
                    }
                    scan_ptr += to_read;
                    if results.len() > 50 { break; }
                }
            }
            
            current_addr = mbi.BaseAddress as usize + mbi.RegionSize;
            if results.len() > 50 { break; }
        }

        if debug { println!("[DEBUG] Tìm thấy {} vị trí chuỗi '{}'", results.len(), target); }
        results
    }

    /// Đọc một chuỗi byte thô từ bộ nhớ
    pub fn read_raw(&self, address: usize, size: usize) -> Option<Vec<u8>> {
        let mut buffer = vec![0u8; size];
        let mut bytes_read = 0;

        let success = unsafe {
            ReadProcessMemory(
                self.handle,
                address as *const c_void,
                buffer.as_mut_ptr() as *mut c_void,
                size,
                Some(&mut bytes_read),
            )
        };

        if success.is_ok() && bytes_read == size {
            Some(buffer)
        } else {
            None
        }
    }

    /// Đọc một kiểu dữ liệu bất kỳ (Struct, int, float) từ bộ nhớ
    pub fn read<T>(&self, address: usize) -> Option<T> {
        let mut buffer: T = unsafe { std::mem::zeroed() };
        let mut bytes_read = 0;

        let success = unsafe {
            ReadProcessMemory(
                self.handle,
                address as *const c_void,
                &mut buffer as *mut _ as *mut c_void,
                std::mem::size_of::<T>(),
                Some(&mut bytes_read),
            )
        };

        if success.is_ok() && bytes_read == std::mem::size_of::<T>() {
            Some(buffer)
        } else {
            None
        }
    }
}

impl Drop for MemoryManager {
    fn drop(&mut self) {
        unsafe {
            let _ = CloseHandle(self.handle);
        }
    }
}
