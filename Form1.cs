using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace IPSwitch
{
    public partial class Form1 : Form
    {
        private List<IpConfig> ipConfigs;
        private string configFilePath = "ipconfig.json";
        private string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ipswitch.log");

        public Form1()
        {
            InitializeComponent();
            LogMessage("程序启动");
            LoadIpConfigs();
            comboBoxIpConfig.SelectedIndexChanged += ComboBoxIpConfig_SelectedIndexChanged;
        }

        private void LoadIpConfigs()
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    var json = File.ReadAllText(configFilePath);
                    ipConfigs = JsonConvert.DeserializeObject<List<IpConfig>>(json);
                    comboBoxIpConfig.DataSource = ipConfigs;
                    comboBoxIpConfig.DisplayMember = "Name";

                    if (ipConfigs.Count > 0)
                    {
                        comboBoxIpConfig.SelectedIndex = 0;
                        DisplayIpConfigDetails(ipConfigs[0]);
                    }
                }
                else
                {
                    LogMessage($"配置文件 {configFilePath} 未找到");
                    MessageBox.Show("配置文件未找到！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                LogMessage($"加载配置失败: {ex}");
                MessageBox.Show($"加载配置失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxIpConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIpConfig.SelectedItem is IpConfig selectedConfig)
            {
                DisplayIpConfigDetails(selectedConfig);
            }
        }

        private void DisplayIpConfigDetails(IpConfig config)
        {
            displayConnectionName.Text = config.ConnectionName;
            displayBoxIpAddress.Text = config.IpAddress;
            displaySubnetMask.Text = config.SubnetMask;
            displayGateway.Text = config.Gateway;
            displayDns1.Text = config.Dns1;
            displayDns2.Text = config.Dns2;
        }

        private void ApplyIpConfig(IpConfig config)
        {
            try
            {
                LogMessage($"开始应用配置: {config.Name}");

                // 验证网络连接是否存在
                if (!IsInterfaceExists(config.ConnectionName))
                {
                    LogMessage($"网络连接不存在: {config.ConnectionName}");
                    MessageBox.Show($"网络连接 '{config.ConnectionName}' 不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 设置IP地址和子网掩码
                ExecuteNetshCommand($"interface ip set address name=\"{config.ConnectionName}\" static {config.IpAddress} {config.SubnetMask} {config.Gateway} 1");

                // 直接设置静态DNS
                ExecuteNetshCommand($"interface ip set dns name=\"{config.ConnectionName}\" static {config.Dns1} primary");
                if (!string.IsNullOrWhiteSpace(config.Dns2))
                {
                    ExecuteNetshCommand($"interface ip add dns name=\"{config.ConnectionName}\" {config.Dns2} index=2");
                }

                LogMessage("配置应用成功");
                MessageBox.Show("IP配置已成功应用！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogMessage($"配置应用失败: {ex}");
                MessageBox.Show($"应用IP配置时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsInterfaceExists(string interfaceName)
        {
            try
            {
                var interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (var ni in interfaces)
                {
                    if (ni.Name.Equals(interfaceName, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogMessage($"检查网络连接失败: {ex}");
                return false;
            }
        }

        private void ExecuteNetshCommand(string arguments)
        {
            ExecuteCommand("netsh", arguments);
        }

        private void ExecuteCommand(string fileName, string arguments)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = fileName,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        Verb = "runas" // 请求管理员权限
                    };

                    LogMessage($"执行命令: {fileName} {arguments}");
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrWhiteSpace(output))
                        LogMessage($"命令输出: {output}");
                    if (!string.IsNullOrWhiteSpace(error))
                        LogMessage($"命令错误: {error}");

                    if (process.ExitCode != 0)
                    {
                        throw new Exception($"命令执行失败，退出代码: {process.ExitCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessage($"执行命令异常: {ex}");
                throw;
            }
        }

        private void LogMessage(string message)
        {
            try
            {
                string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n";
                File.AppendAllText(logFilePath, logMessage);
            }
            catch (Exception ex)
            {
                // 如果日志写入失败，尝试输出到调试窗口或控制台
                Debug.WriteLine($"日志写入失败: {ex}");
                Console.WriteLine($"日志写入失败: {ex}");
            }
        }

        private void ApplyConfigBtn_Click(object sender, EventArgs e)
        {
            LogMessage($"点击应用按钮");
            if (comboBoxIpConfig.SelectedItem is IpConfig selectedConfig)
            {
                ApplyIpConfig(selectedConfig);
            }
        }
    }
}



