using Winpilot;
using System;
using System.Diagnostics;
using System.Drawing;

namespace Interop
{
    public class AppPackages : InteropBase
    {
        private string appId;
        private string wingetId;

        // Default constructor without additional arguments
        public AppPackages(MainForm form, Logger logger)
            : base(form, logger)
        {
            // Default values......
            this.appId = "defaultAppId";
            this.wingetId = "defaultWingetId";
        }

        // Constructor with additional arguments
        public AppPackages(MainForm form, Logger logger, string appId, string wingetId)
            : base(form, logger)
        {
            this.appId = appId;
            this.wingetId = wingetId;
        }

        public override void Execute()
        {
            try
            {
                logger.Log($"Installing {wingetId}...", Color.HotPink);
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\WindowsApps\\wt.exe",
                        Arguments = $"winget install --id {wingetId} --accept-source-agreements --accept-package-agreements",
                        UseShellExecute = false,
                        CreateNoWindow = false,
                    }
                };

                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                logger.Log($"Error installing {appId} with winget: {ex.Message}", Color.Red);
            }
        }
    }
}