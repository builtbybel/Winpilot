// Obsolete: Remove Intelligent/ AI Actions

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Winpilot;

namespace Interop
{
    public class StorageSettings
    {
        private Logger logger;

        public StorageSettings(Logger logger)
        {
            this.logger = logger;
        }

        public async Task RunStorageSense()
        {
            long spaceBefore = GetAvailableDiskSpace();
            Log($"Available space before cleanup: {FormatSize(spaceBefore)}", Color.Magenta);

            await Task.Run(async () =>
            {
                Log("Executing Storage Sense operations.", Color.Magenta);

                long tempFilesSpace = await CleanTemporaryFiles();
                long defenderHistorySpace = await CleanWindowsDefenderProtectionHistory();
                long updateCacheSpace = await CleanWindowsUpdateFiles();
                long errorReportingFiles = await CleanWindowsErrorReportingFiles();
                long deliveryOptimiationCache = await CleanDeliveryOptimizationCache();
                long edgeCacheSpace = await CleanEdgeBrowserCache();
            });

            long spaceAfter = GetAvailableDiskSpace();
            Log($"Available space after cleanup: {FormatSize(spaceAfter)}", Color.Green);

            long spaceGained = spaceAfter - spaceBefore;
            if (spaceGained > 0)
            {
                Log($"Space gained after cleaning: {FormatSize(spaceGained)}", Color.Green);
            }
            else
            {
                Log("No additional space gained or space lost after cleaning.", Color.Magenta);
            }

            Log("Storage Sense operations completed successfully.", Color.Green);
        }

        private long GetAvailableDiskSpace()
        {
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory));
            return drive.AvailableFreeSpace;
        }

        private string FormatSize(long sizeInBytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (sizeInBytes >= 1024 && order < sizes.Length - 1)
            {
                order++;
                sizeInBytes = sizeInBytes / 1024;
            }

            return $"{sizeInBytes:0.##} {sizes[order]}";
        }

        // AppData Temp directory
        private async Task<long> CleanTemporaryFiles()
        {
            Log("Cleaning temporary files..:", Color.Purple);
            string tempPath = Path.GetTempPath();
            await RunCommand("cleanmgr.exe", "/c");

            return await CleanDirectory(tempPath);
        }

        // Windows Defender Protection History
        private async Task<long> CleanWindowsDefenderProtectionHistory()
        {
            try
            {
                Log("Cleaning Windows Defender Protection History...", Color.HotPink);

                string protectionHistoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Microsoft", "Windows Defender", "Scans", "History");

                if (Directory.Exists(protectionHistoryPath))
                {
                    return await CleanDirectory(protectionHistoryPath);
                }
                else
                {
                    Log("Windows Defender Protection History folder not found.", Color.Red);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Log($"Error cleaning Windows Defender Protection History: {ex.Message}", Color.Red);
                return 0;
            }
        }

        // Delivery Optimization Cache
        private async Task<long> CleanDeliveryOptimizationCache()
        {
            try
            {
                Log("Cleaning Delivery Optimization Cache...", Color.HotPink);

                string deliveryOptimizationCachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "ServiceProfiles", "NetworkService", "AppData", "Local", "Microsoft", "Windows", "DeliveryOptimization", "Cache");

                if (Directory.Exists(deliveryOptimizationCachePath))
                {
                    return await CleanDirectory(deliveryOptimizationCachePath);
                }
                else
                {
                    Log("Delivery Optimization Cache folder not found.", Color.Red);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Log($"Error cleaning Delivery Optimization Cache: {ex.Message}", Color.Red);
                return 0;
            }
        }

        // System created Windows Error Reporting files (Archived and Queued Error reports)
        private async Task<long> CleanWindowsErrorReportingFiles()
        {
            try
            {
                Log("Cleaning System created Windows Error Reporting files...", Color.HotPink);

                string errorReportingPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Microsoft", "Windows", "WER");

                if (Directory.Exists(errorReportingPath))
                {
                    return await CleanDirectory(errorReportingPath);
                }
                else
                {
                    Log("Windows Error Reporting folder not found.", Color.Red);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Log($"Error cleaning Windows Error Reporting Files: {ex.Message}", Color.Red);
                return 0;
            }
        }

        //  Windows Update cache SoftwareDistribution
        private async Task<long> CleanWindowsUpdateFiles()
        {
            try
            {
                Log("Cleaning Windows Update cache...", Color.Green);

                string softwareDistributionPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "SoftwareDistribution");

                if (Directory.Exists(softwareDistributionPath))
                {
                    return await CleanDirectory(softwareDistributionPath);
                }
                else
                {
                    Log("Windows Update cache folder not found.", Color.Red);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Log($"Error cleaning Windows Update cache: {ex.Message}", Color.Red);
                return 0;
            }
        }

        // Edge Browser Cache
        private async Task<long> CleanEdgeBrowserCache()
        {
            try
            {
                Log("Cleaning Microsoft Edge browser cache...", Color.Green);

                // Check if msedge process is running
                if (Utils.IsProcessRunning("msedge"))
                {
                    Log($"Microsoft Edge browser is currently running. Please close it to proceed with the cleanup. I am waiting, {Environment.UserName}...", Color.DeepPink);

                    // Wait for msedge process to close
                    while (Utils.IsProcessRunning("msedge"))
                    {
                        await Task.Delay(1000); // Let us wait for 1 second before checking again
                    }

                    Log("Microsoft Edge browser has been closed. Proceeding with the cleanup...", Color.Green);
                }

                // Continue with cleanup
                string edgeCachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "Edge", "User Data", "Default");

                if (Directory.Exists(edgeCachePath))
                {
                    long spaceFreed = 0;

                    // Cache
                    string cachePath = Path.Combine(edgeCachePath, "Cache");
                    spaceFreed += await CleanDirectory(cachePath);

                    // Code Cache
                    string codeCachePath = Path.Combine(edgeCachePath, "Code Cache");
                    spaceFreed += await CleanDirectory(codeCachePath);

                    // GPUCache
                    string gpuCachePath = Path.Combine(edgeCachePath, "GPUCache");
                    spaceFreed += await CleanDirectory(gpuCachePath);

                    Log($"Edge browser cache cleaned. Total space freed: {spaceFreed} bytes", Color.Green);
                    return spaceFreed;
                }
                else
                {
                    Log("Edge cache folder not found.", Color.Red);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Log($"Error cleaning Edge browser cache: {ex.Message}", Color.Red);
                return 0;
            }
        }

        private async Task<long> CleanDirectory(string directoryPath)
        {
            try
            {
                long spaceFreed = 0;

                string[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        spaceFreed += fileInfo.Length;
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        Log($"Error deleting file '{file}': {ex.Message}", Color.Red);
                    }
                }

                string[] directories = Directory.GetDirectories(directoryPath);
                foreach (string directory in directories)
                {
                    try
                    {
                        spaceFreed += await CleanDirectory(directory);
                        Directory.Delete(directory, true);
                    }
                    catch (Exception ex)
                    {
                      Log($"Error deleting directory '{directory}': {ex.Message}", Color.Red);
                    }
                }

                return spaceFreed;
            }
            catch (Exception ex)
            {
                Log($"Error cleaning directory: {ex.Message}", Color.Red);
                return 0;
            }
        }

        private async Task RunCommand(string command, string arguments)
        {
            try
            {
                Log("Would you also like to optionally run the good old cleanmgr.exe? If so, please confirm now.", Color.Purple);
                Log($"Running command: {command} {arguments}", Color.Green);

                await Task.Run(() =>
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = command,
                        Arguments = arguments,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    using (Process process = new Process { StartInfo = startInfo })
                    {
                        process.Start();
                        process.WaitForExit();
                    }
                });

               Log($"Command executed successfully.", Color.Green);
            }
            catch (Exception ex)
            {
                 Log($"Error running command: {ex.Message}", Color.Red);
            }
        }

        private void Log(string message, Color color)
        {
            string aiSaying = GetPseudoAISaying();
            logger.Log($"{aiSaying} {message}", color);
        }

        private string GetPseudoAISaying()
        {
            string[] aiSayings = {
                "Processing information with quantum precision:",
                "Analyzing data like a neural network:",
                "Executing tasks with machine-like efficiency:",
                "Optimizing storage operations for maximum performance:",
                "Simulating human-like intelligence:",
                "Calculating possibilities in the digital realm:",
            };

            Random random = new Random();
            int index = random.Next(aiSayings.Length);
            return aiSayings[index];
        }
    }
}