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
        let cmd = format!("su -c '{} &'", remote_path);
        Command::new(&self.adb_path)
            .args(&["-s", &self.serial, "shell", &cmd])
            .spawn()
            .map_err(|e| e.to_string())?;
        Ok(())
    }

    pub fn connect(&self) -> Result<(), String> {
        let output = self.run_adb_no_serial(&["connect", &self.serial])?;
        println!("[DEBUG] ADB Connect ({}): {}", self.serial, output.trim());
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
}
