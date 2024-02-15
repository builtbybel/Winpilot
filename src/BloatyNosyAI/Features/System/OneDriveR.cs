using BloatyNosy;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Features.Feature.System
{
    internal class OneDriveRemove : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public override string ID()
        {
            return "[MIDDLE] Uninstall OneDrive";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckFeature()
        {
            var appPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\OneDrive\OneDrive.exe";

            if (!File.Exists(appPath))
            {
                return false;
            }

            return true;
        }

        public override bool DoFeature()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false;

                logger.Log("Uninstalling OneDrive...Please wait.");
                string sysEnv = Environment.GetEnvironmentVariable("SYSTEMROOT");
                proc.StartInfo.FileName = "taskkill"; proc.StartInfo.Arguments = "/F /IM OneDrive.exe";
                proc.Start();

                proc.StartInfo.FileName = (sysEnv + @"\System32\OneDriveSetup.exe");
                proc.StartInfo.Arguments = "/uninstall";
                proc.Start();

                proc.WaitForExit();
                logger.Log("Onedrive has been successfully uninstalled.");
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                using (var client = new WebClient())
                {
                    logger.Log("= We've opened the download link in your Browser.\n\nPlease install the package \"OneDrive\". ");
                    Process.Start("https://www.microsoft.com/microsoft-365/onedrive/download");

                    return true;
                }
            }
            catch (Exception ex)
            { logger.Log("{0}", ex.Message); }

            return false;
        }
    }
}