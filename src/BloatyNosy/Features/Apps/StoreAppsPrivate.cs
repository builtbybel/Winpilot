using BloatyNosy;
using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;

namespace Features.Feature.Apps
{
    internal class StoreAppsPrivate : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private readonly PowerShell powerShell = PowerShell.Create();

        public override string ID()
        {
            return "*[LOW] Remove bloatware based on private signature (Configure with a right-click)";
        }

        public override string Info()
        {
            return "Open the bloaty.txt file in the app directory of BloatyNosy to edit your signature or right click on this feature";
        }

        private void RemoveApps(string str)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = str;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        public override bool CheckFeature()
        {
            logger.Log("The following apps would be removed based on your private signature:");
            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            try
            {
                string[] num = File.ReadAllLines(HelperTool.Utils.Data.DataRootDir + "/bloaty.txt");

                foreach (PSObject result in powerShell.Invoke())
                {
                    string current = result.ToString(); // Get the current app

                    for (int i = 0; i < num.Length; i++)
                    {
                        string[] package = num[i].Split(':');
                        string appx = package[0];

                        if (current.Contains(appx))
                            logger.Log("[-] App would be removed: " + appx);
                    }
                }
            }
            catch
            { logger.Log("[!] Could not find private signature file \"bloaty.txt\" in " + HelperTool.Utils.Data.DataRootDir); }
            return true;
        }

        public override bool DoFeature()
        {
            string[] num = File.ReadAllLines(HelperTool.Utils.Data.DataRootDir + "/bloaty.txt");
            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString(); // Get the current app

                for (int i = 0; i < num.Length; i++)
                {
                    string[] package = num[i].Split(':');
                    string appx = package[0];
                    string command = package[1];
                    try
                    {
                        if (current.Contains(appx))
                        {
                            logger.Log("[?] Removing: " + appx + " (Wait...)");
                            RemoveApps(command);
                            logger.Log("[-] Removed: " + appx);
                        }
                    }
                    catch (Exception ex)
                    { logger.Log("Error removing " + ex); }
                }
            }
            return true;
        }

        public override bool UndoFeature()
        {
            logger.Log("- [Remove Store Apps] This feature does not provide a restore mode.");
            return false;
        }
    }
}