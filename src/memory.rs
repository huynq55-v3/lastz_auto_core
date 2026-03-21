use std::ffi::c_void;
use sysinfo::System;
use windows::Win32::Foundation::{CloseHandle, FALSE, HANDLE};
use windows::Win32::System::Diagnostics::Debug::ReadProcessMemory;
use windows::Win32::System::Threading::{OpenProcess, PROCESS_QUERY_INFORMATION, PROCESS_VM_READ};
use windows::Win32::System::Memory::{VirtualQueryEx, MEMORY_BASIC_INFORMATION, MEM_COMMIT, PAGE_NOACCESS};

pub struct MemoryManager {
    pid: u32,
    handle: HANDLE,
}

impl MemoryManager {
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

    /// Quét toàn bộ bộ nhớ để tìm chuỗi Byte (Signature/Pattern)
    pub fn find_pattern(&self, signature: &[u8], debug: bool) -> Option<usize> {
        let mut address: usize = 0;
        let mut info = MEMORY_BASIC_INFORMATION::default();
        let mut buffer: Vec<u8> = Vec::new();

        if debug {
            println!("[DEBUG] Bắt đầu quét Pattern Scan (Len: {})", signature.len());
        }

        while unsafe {
            VirtualQueryEx(
                self.handle,
                Some(address as *const c_void),
                &mut info,
                std::mem::size_of::<MEMORY_BASIC_INFORMATION>(),
            )
        } != 0
        {
            // Kiểm tra các vùng nhớ có khả năng chứa code/data (MEM_COMMIT)
            // Bỏ qua NOACCESS và GUARD pages (thường gây lỗi khi ReadProcessMemory)
            let is_readable = info.State == MEM_COMMIT && 
                             (info.Protect == windows::Win32::System::Memory::PAGE_READONLY ||
                              info.Protect == windows::Win32::System::Memory::PAGE_READWRITE ||
                              info.Protect == windows::Win32::System::Memory::PAGE_EXECUTE_READ ||
                              info.Protect == windows::Win32::System::Memory::PAGE_EXECUTE_READWRITE);

            if is_readable {
                let region_size = info.RegionSize;
                let start_addr = info.BaseAddress as usize;

                // Nâng giới hạn quét: LDPlayer 9 thường cấp phát > 2GB RAM cho máy ảo
                // Quét tối đa 4GB mỗi vùng nhớ để đảm bảo không sót
                if region_size > 0 && region_size <= 0xFFFFFFFF { 
                    if buffer.capacity() < region_size {
                        buffer.reserve(region_size - buffer.capacity());
                    }
                    unsafe { buffer.set_len(region_size) };
                    
                    let mut bytes_read = 0;
                    let success = unsafe {
                        ReadProcessMemory(
                            self.handle,
                            start_addr as *const c_void,
                            buffer.as_mut_ptr() as *mut c_void,
                            region_size,
                            Some(&mut bytes_read),
                        )
                    };

                    if success.is_ok() {
                        let valid_data = if bytes_read > 0 { &buffer[0..bytes_read] } else { &[] };
                        if let Some(pos) = valid_data.windows(signature.len()).position(|window| window == signature) {
                            if debug {
                                println!("[DEBUG] Tìm thấy Signature tại: 0x{:X} (Region: 0x{:X}, Size: {})", 
                                         start_addr + pos, start_addr, region_size);
                            }
                            return Some(start_addr + pos);
                        }
                    } else if debug && region_size > 1000_000 {
                        // In lỗi nếu không đọc được vùng nhớ lớn (tiềm năng chứa game)
                        // println!("[DEBUG] Không thể đọc vùng 0x{:X} (Size: {})", start_addr, region_size);
                    }
                }
            }

            let next_addr = (info.BaseAddress as usize).saturating_add(info.RegionSize);
            if next_addr <= address || next_addr >= 0x7FFFFFFFFFFFFFFF {
                break;
            }
            address = next_addr;
        }

        None
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
