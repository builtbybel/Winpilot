using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Winpilot;

namespace Interop
{
    public class DownloadHandler
    {
        private Logger logger;

        public DownloadHandler(Logger logger)
        {
            this.logger = logger;
        }

        // Downloader (e.g. Localization files and optional for downloading files)
        public async Task DownloadFiles(Dictionary<string, string> downloadUri, string targetDirectory)
        {
            try
            {
                foreach (var kvp in downloadUri)
                {
                    string fileName = Path.GetFileName(kvp.Value);
                    string filePath = Path.Combine(targetDirectory, fileName);

                    logger.Log($"Downloading {fileName}...", Color.Magenta);

                    try
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            // Subscribe to the DownloadProgressChanged event
                            webClient.DownloadProgressChanged += (sender, e) =>
                            {
                                // Report progress in real-time
                                int percentage = e.ProgressPercentage;
                                long totalBytesToReceive = e.TotalBytesToReceive;
                                long bytesReceived = e.BytesReceived;

                                logger.Log($"{fileName} - {percentage}% completed ({bytesReceived}/{totalBytesToReceive} bytes)", Color.Blue);
                            };

                            // Download file asynchronously!
                            await webClient.DownloadFileTaskAsync(new Uri(kvp.Value), filePath);
                        }

                        // Done
                        logger.Log($"{fileName} downloaded successfully.", Color.Green);
                    }
                    catch (Exception ex)
                    {
                        logger.Log($"Error downloading {fileName}: {ex.Message}", Color.Red);
                    }
                }

                // All done
                // logger.Log("Downloads completed.", Color.Magenta);
            }
            catch (Exception ex)
            {
                logger.Log($"Error in Downloader: {ex.Message}", Color.Red);
            }
        }
    }
}