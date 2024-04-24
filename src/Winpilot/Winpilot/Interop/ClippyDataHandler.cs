using Winpilot;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interop
{
    public class ClippyDataHandler
    {
        // Using P/Invoke(Platform Invocation Services) to simulate pressing Win + Shift + S and take a screenshot
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const int VK_LWIN = 0x5B;
        private const int VK_SHIFT = 0x10;
        private const int VK_S = 0x53;

        private const int KEYEVENTF_KEYDOWN = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;

        private Logger logger;
        private CommandsHandler command;

        public ClippyDataHandler(Logger logger)
        {
            this.logger = logger;
            command = new CommandsHandler(logger);
        }

        // E.g. Support for my own Apps, like Appcopier
        public void OpenAppFromPackagesFolder(string appPath)
        {
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, appPath);
                Process.Start(fullPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening the application: {ex.Message}");
                Console.WriteLine($"Exception Details: {ex}");
            }
        }

        public void SwitchToAutostartTab()
        {
            command.StartProcess("taskmgr.exe", "/0 /startup", true, createNoWindow: true);
        }

        public void TakeScreenshot()
        {
            try
            {
                // Simulate pressing Win + Shift + S
                keybd_event((byte)VK_LWIN, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
                keybd_event((byte)VK_SHIFT, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
                keybd_event((byte)VK_S, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);

                // Release keys again
                keybd_event((byte)VK_S, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
                keybd_event((byte)VK_SHIFT, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
                keybd_event((byte)VK_LWIN, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
            }
            catch (Exception ex)
            {
                logger.Log($"Error taking desktop screenshot: {ex.Message}", Color.Red);
            }
        }

        public void ShowDiskSpace()
        {
            try
            {
                DriveInfo drive = new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory));

                long totalSpace = drive.TotalSize;
                long usedSpace = totalSpace - drive.TotalFreeSpace;
                long freeSpace = drive.TotalFreeSpace;

                string formattedTotalSpace = $"{totalSpace / (1024L * 1024L * 1024L)} GB";
                string formattedUsedSpace = $"{usedSpace / (1024L * 1024L * 1024L)} GB";
                string formattedFreeSpace = $"{freeSpace / (1024L * 1024L * 1024L)} GB";

                logger.Log($"Total Disk Space: {formattedTotalSpace}\nUsed Space: {formattedUsedSpace}\nFree Space: {formattedFreeSpace}", Color.DarkGreen);
            }
            catch (Exception ex)
            {
                logger.Log($"Error retrieving disk space: {ex.Message}", Color.Red);
            }
        }

        public async Task ShowWindowsVersion()
        {
            logger.Log("Just a moment...", Color.Red);

            await Task.Run(() =>
            {
                try
                {
                    using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                        // Retrieve general OS information
                        PowerShellInstance.AddScript("Get-CimInstance -ClassName Win32_OperatingSystem");

                        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

                        foreach (PSObject outputItem in PSOutput)
                        {
                            if (outputItem != null)
                            {
                                string version = outputItem.Properties["Version"]?.Value?.ToString();
                                string buildNumber = outputItem.Properties["BuildNumber"]?.Value?.ToString();
                                string productName = outputItem.Properties["Caption"]?.Value?.ToString();

                                if (!string.IsNullOrEmpty(productName))
                                {
                                    string osVersion = productName.Contains("Windows 10") ? "Windows 10" : "Windows 11";

                                    if (osVersion == "Windows 11")
                                    {
                                        logger.Log($"Welcome to the future with Windows 11! 🚀 (Very nice, {Environment.UserName})", Color.Blue);
                                    }
                                    else if (osVersion == "Windows 10")
                                    {
                                        logger.Log("You are using Windows 10. Consider upgrading to Windows 11 for a modern experience.", Color.Magenta);
                                    }

                                    // Check if running a Windows Insider build
                                    RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\UpdateOrchestrator");
                                    if (key != null)
                                    {
                                        object value = key.GetValue("EnableInsiderBuilds");
                                        if (value != null && Convert.ToInt32(value) == 1)
                                        {
                                            string ring = key.GetValue("Ring")?.ToString();
                                            logger.Log($"You are running a Windows Insider build in the {ring} ring.", Color.Green);
                                        }
                                        key.Close();
                                    }

                                    // Retrieve display version
                                    RegistryKey displayVersionKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
                                    if (displayVersionKey != null)
                                    {
                                        object displayVersion = displayVersionKey.GetValue("DisplayVersion");
                                        if (displayVersion != null)
                                        {
                                            logger.Log($"You are on Build: {buildNumber} (Display Version: {displayVersion})", Color.Red);
                                        }
                                        else
                                        {
                                            logger.Log($"You are on Build: {buildNumber} (Display version not found)", Color.Red);
                                        }
                                    }
                                    else
                                    {
                                        logger.Log("Failed to retrieve display version.", Color.Red);
                                    }
                                }
                                else
                                {
                                    logger.Log("Failed to retrieve OS information.", Color.Yellow);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Log($"Error occurred: {ex.Message}", Color.Red);
                }
            });
        }

        public void ShowProcessesWithHighRamUsage(int thresholdMB)
        {
            try
            {
                // Get all running processes
                Process[] processes = Process.GetProcesses();

                // Filter processes with high RAM usage
                var highRamProcesses = processes
                    .Where(process => process.WorkingSet64 > thresholdMB * 1024 * 1024) // Convert threshold to bytes
                    .OrderByDescending(process => process.WorkingSet64);

                // Log the list of processes with high RAM usage
                logger.Log($">={thresholdMB} MB:", Color.DarkGreen);
                foreach (Process process in highRamProcesses)
                {
                    logger.Log($"{process.ProcessName} (PID: {process.Id}, RAM Usage: {process.WorkingSet64 / (1024 * 1024)} MB)", Color.DarkGreen);
                }

                // You can perform additional actions on these processes if needed
            }
            catch (Exception ex)
            {
                logger.Log($"Error handling processes: {ex.Message}", Color.DarkRed);
            }

        }
        public async Task CheckIPAddress()
        {
            try
            {
                // Retrieve public IP address using a web service or API
                using (WebClient client = new WebClient())
                {
                    string ipAddress = await client.DownloadStringTaskAsync("https://api.ipify.org");

                    // Log the IP address
                    logger.Log($"Your public IP address is: {ipAddress}", Color.DarkGreen);
                }
            }
            catch (Exception ex)
            {
                // Log error message
                logger.Log($"Error checking IP address: {ex.Message}", Color.DarkRed);
            }
        }

        public async Task RunWindowsDefenderScan()
        {
            try
            {
                // Get path to Program Files folder
                string programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                string defenderPath = Path.Combine(programFilesPath, "Windows Defender", "MpCmdRun.exe");

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = defenderPath;
                    process.StartInfo.Arguments = "-Scan -ScanType 1"; // -ScanType 1 for a quick scan
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    // Handle real-time output
                    process.OutputDataReceived += (sender, e) => logger.Log(e.Data, Color.DarkGreen);
                    process.ErrorDataReceived += (sender, e) => logger.Log(e.Data, Color.DarkRed);

                    // Start process!
                    process.Start();

                    // Begin reading output streams asynchronously
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    // Wait for process to exit via ProcessExtensions
                    await process.WaitForExitAsync();
                    logger.Log("Windows Defender scan completed.", Color.DarkGreen);
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error running Windows Defender scan: {ex.Message}", Color.DarkRed);
            }
        }
    }
}

// Extension method to make WaitForExit in Defender Scan asynchronous
public static class ProcessExtensions
{
    public static Task WaitForExitAsync(this Process process)
    {
        var tcs = new TaskCompletionSource<object>();

        process.EnableRaisingEvents = true;
        process.Exited += (sender, args) => tcs.TrySetResult(null);

        if (process.HasExited)
        {
            tcs.TrySetResult(null);
        }

        return tcs.Task;
    }
}