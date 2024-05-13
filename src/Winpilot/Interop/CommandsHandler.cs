using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Winpilot;

namespace Interop
{
    public class CommandsHandler
    {
        private Logger logger;

        public CommandsHandler(Logger logger)
        {
            this.logger = logger;
        }

        // Run processes (here also switching to taskmanager tabs) with optional parameter
        public void StartProcess(string fileName, string arguments, bool redirectOutput = false, bool createNoWindow = false)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = fileName,
                    Arguments = arguments,
                    RedirectStandardOutput = redirectOutput,
                    RedirectStandardError = redirectOutput,
                    UseShellExecute = false,
                    CreateNoWindow = createNoWindow,
                    WindowStyle = createNoWindow ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal
                };

                using (Process process = new Process() { StartInfo = psi })
                {
                    if (redirectOutput)
                    {
                        process.OutputDataReceived += (sender, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                            {
                                // Handle output data
                                logger.Log($"{e.Data}", Color.Green);
                            }
                        };

                        process.ErrorDataReceived += (sender, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                            {
                                // Handle error data
                                logger.Log($"Error: {e.Data}", Color.Red);
                            }
                        };

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                    }
                    else
                    {
                        process.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error starting process ({fileName}): {ex.Message}", Color.Red);
            }
        }

        public void ExecutePowerShellCommand(string command)
        {
            StartProcess("powershell.exe", $"-NoProfile -ExecutionPolicy unrestricted -Command \"{command}\"", true, createNoWindow: false);
        }

        // Run URIs (ms-settings), open links etc.
        public void ExecuteSettingsURI(string uri)
        {
            try
            {
                Process.Start(uri);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening settings with URI '{uri}': {ex.Message}");
            }
        }

        // Run command-line tools, e.g. REG.exe etc.
        public async Task ExecuteShellCommand(string command)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {command}", // /C carries out command specified and then terminates
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;

                    TaskCompletionSource<bool> processExited = new TaskCompletionSource<bool>();

                    process.Exited += (sender, args) =>
                    {
                        processExited.SetResult(true);
                    };

                    process.Start();

                    // Read output
                    string output = await process.StandardOutput.ReadToEndAsync();
                    Console.WriteLine(output);

                    await Task.Run(() => process.WaitForExit());

                    await processExited.Task;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing command '{command}': {ex.Message}");
            }
        }

        // Support for external PowerShell scripts in plugins directory
        public async Task RunPowerShellScript(string scriptName)
        {
            try
            {
                string pluginsFolderPath = @"plugins";
                string scriptPath = Path.Combine(pluginsFolderPath, scriptName);

                var startInfo = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Normal,
                    Arguments = $"-NoProfile -ExecutionPolicy Bypass -NoExit -File \"{scriptName}\"",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                };

                using (var process = new Process() { StartInfo = startInfo })
                {
                    process.OutputDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrWhiteSpace(e.Data))
                        {
                            logger.Log($"Interpreting: {e.Data}", Color.DarkGreen);
                        }
                    };

                    process.ErrorDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrWhiteSpace(e.Data))
                        {
                            //logger.Log($"Error: {e.Data}", Color.DarkRed); // Don't log errors yet
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    await Task.Run(() => process.WaitForExit());

                    logger.Log("Script execution completed.", Color.Magenta);
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error running PowerShell script: {ex.Message}", Color.DarkRed);
            }
        }

        // Support for executing PowerShell commands directly
        public async Task RunPowerShellCommand(string command)
        {
            try
            {
                var startInfo = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Normal,
                    Arguments = $"-NoProfile -ExecutionPolicy Bypass -NoExit -Command \"{command}\"",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                };

                using (var process = new Process() { StartInfo = startInfo })
                {
                    process.OutputDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrWhiteSpace(e.Data))
                        {
                            logger.Log($"Output: {e.Data}", Color.DarkGreen);
                        }
                    };

                    process.ErrorDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrWhiteSpace(e.Data))
                        {
                            logger.Log($"Error: {e.Data}", Color.DarkRed);
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    await Task.Run(() => process.WaitForExit());

                    logger.Log("PowerShell command execution completed.", Color.Magenta);
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error running PowerShell command: {ex.Message}", Color.DarkRed);
            }
        }
    }
}