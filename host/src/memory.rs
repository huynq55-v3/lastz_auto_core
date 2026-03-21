use common::memory_interface::MemoryInterface;
use std::io::{Read, Write};
use std::net::TcpStream;

pub struct RemoteMemory {
    stream: std::cell::RefCell<TcpStream>,
}

impl RemoteMemory {
    pub fn new(stream: TcpStream) -> Self {
        Self {
            stream: std::cell::RefCell::new(stream),
        }
    }
}

impl MemoryInterface for RemoteMemory {
    fn read_raw(&self, address: usize, size: usize) -> Option<Vec<u8>> {
        let mut stream = self.stream.borrow_mut();
        let cmd = format!("READ 0x{:X} {}\n", address, size);
        let _ = stream.write_all(cmd.as_bytes());
        
        let mut buffer = vec![0u8; size];
        if stream.read_exact(&mut buffer).is_ok() {
            Some(buffer)
        } else {
            None
        }
    }
}
