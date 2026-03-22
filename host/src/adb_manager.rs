use std::process::Command;
use std::path::PathBuf;

pub struct AdbManager {
    adb_path: PathBuf,
    serial: String,
}

impl AdbManager {
    pub fn new(adb_path: PathBuf, instance_id: u32) -> Self {
        // LDPlayer instance 0 -> 5554, instance 1 -> 5556, ...
        // Trên một số máy LDPlayer 9 dùng "emulator-5554"
        let port = 5554 + instance_id * 2;
        let serial = format!("emulator-{}", port);
        Self { adb_path, serial }
    }

    fn run_adb(&self, args: &[&str]) -> Result<String, String> {
        let mut full_args = vec!["-s", &self.serial];
        full_args.extend_from_slice(args);

        let output = Command::new(&self.adb_path)
            .args(&full_args)
            .output()
            .map_err(|e| e.to_string())?;

        if output.status.success() {
            Ok(String::from_utf8_lossy(&output.stdout).to_string())
        } else {
            Err(String::from_utf8_lossy(&output.stderr).to_string())
        }
    }

    pub fn push_file(&self, local: &str, remote: &str) -> Result<(), String> {
        self.run_adb(&["push", local, remote])?;
        Ok(())
    }

    pub fn forward_port(&self, local_port: u16, remote_port: u16) -> Result<(), String> {
        self.run_adb(&["forward", &format!("tcp:{}", local_port), &format!("tcp:{}", remote_port)])?;
        Ok(())
    }

    pub fn run_agent(&self, remote_path: &str) -> Result<(), String> {
        // 1. Kill phiên bản cũ (dùng su -c)
        let _ = self.run_adb(&["shell", &format!("su -c 'pkill -f lastz_auto_agent'")]);
        
        // 2. Chế độ chmod 777 cho file
        self.run_adb(&["shell", &format!("su -c 'chmod 777 {}'", remote_path)])?;
        
        // 3. Chạy Agent quyền root trong background
        let cmd = format!("su -c '{} > /dev/null 2>&1 &'", remote_path);
        let _ = Command::new(&self.adb_path)
            .args(&["-s", &self.serial, "shell", &cmd])
            .status()
            .map_err(|e| e.to_string())?;
        Ok(())
    }

    pub fn connect(&self) -> Result<(), String> {
        // Thử connect với serial hiện tại
        let _ = self.run_adb_no_serial(&["connect", &self.serial]);
        
        // Nếu là emulator-xxxx, đôi khi cần dùng 127.0.0.1:port
        if self.serial.starts_with("emulator-") {
            if let Some(port_str) = self.serial.strip_prefix("emulator-") {
                if let Ok(port) = port_str.parse::<u32>() {
                    let alt_serial = format!("127.0.0.1:{}", port);
                    let _ = self.run_adb_no_serial(&["connect", &alt_serial]);
                }
            }
        }
        Ok(())
    }

    fn run_adb_no_serial(&self, args: &[&str]) -> Result<String, String> {
        let output = Command::new(&self.adb_path)
            .args(args)
            .output()
            .map_err(|e| format!("Lỗi thực thi ADB: {}", e))?;

        if output.status.success() {
            Ok(String::from_utf8_lossy(&output.stdout).to_string())
        } else {
            Err(String::from_utf8_lossy(&output.stderr).to_string())
        }
    }

    pub fn is_device_ready(&self) -> bool {
        let _ = self.connect(); // Thử connect trước
        match self.run_adb(&["shell", "getprop sys.boot_completed"]) {
            Ok(out) => {
                println!("[DEBUG] Boot status: {}", out.trim());
                out.trim() == "1"
            }
            Err(e) => {
                println!("[DEBUG] Lỗi khi kiểm tra boot status: {}", e);
                false
            }
        }
    }

    pub fn run_command(&self, cmd: &str) -> Result<String, String> {
        self.run_adb(&["shell", &format!("su -c '{}'", cmd)])
    }

    pub fn deploy_frida_server(&self, local_path: &str) -> Result<(), String> {
        let remote_path = "/data/local/tmp/frida-server";
        println!("[*] Đang đẩy Frida Server lên thiết bị...");
        self.push_file(local_path, remote_path)?;
        
        println!("[*] Đang cấp quyền thực thi cho Frida Server...");
        self.run_command(&format!("chmod 777 {}", remote_path))?;
        
        println!("[*] Đang khởi động Frida Server...");
        // Chạy Frida Server trong background và chuyển hướng output để tránh treo Terminal host
        let start_cmd = format!("su -c '{} -D > /dev/null 2>&1 &'", remote_path);
        let _ = Command::new(&self.adb_path)
            .args(&["-s", &self.serial, "shell", &start_cmd])
            .status()
            .map_err(|e| e.to_string())?;
        
        println!("[*] Đang chờ Frida Server ổn định (2s)...");
        std::thread::sleep(std::time::Duration::from_secs(2));

        println!("[*] Đang Forward port Frida (27042)...");
        let _ = self.forward_port(27042, 27042);
        
        Ok(())
    }
}
