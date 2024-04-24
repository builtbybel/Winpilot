using Winpilot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Management.Automation;
using System.Threading.Tasks;

namespace Walks
{
    internal class CAppxPackages : WalksBase
    {
        private string jsonFilePath = @"app\appxData.json";

        public CAppxPackages(MainForm form, Logger logger) : base(form, logger)
        {
        }

        public class AppInfo
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string RemoveCommand { get; set; }
        }

        private readonly PowerShell powerShell = PowerShell.Create();

        public override string ID()
        {
            return "Remove crapware";
        }

        private List<AppInfo> LoadAppsFromJson(string jsonFilePath)
        {
            List<AppInfo> apps = new List<AppInfo>();

            try
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                apps = JsonConvert.DeserializeObject<List<AppInfo>>(jsonData);
            }
            catch (Exception ex)
            {
                logger.Log("[!] Error loading crapware database: " + ex.Message, Color.Red);
            }

            return apps;
        }

        private async Task ExecutePowerShellCommand(string command)
        {
            try
            {
                using (PowerShell powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(command);
                    await Task.Run(() => powerShell.Invoke());
                }
            }
            catch (Exception ex)
            {
                logger.Log("[!] Code red in PowerShell command: " + ex.Message, Color.Red);
            }
        }

        public override bool CheckFeature()
        {
            logger.Log($"Launching crapware scan, {Environment.UserName}.", Color.Green);

            List<AppInfo> apps = LoadAppsFromJson(jsonFilePath);

            bool foundMatch = false;

            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddCommand("get-appxpackage").AddCommand("Select").AddParameter("property", "name");

            
                foreach (var app in apps)
                {
                    foreach (PSObject result in powerShell.Invoke())
                    {
                        string current = result.ToString();

                        if (current.Contains(app.Name))
                        {
                            foundMatch = true;
                            logger.Log($"[Crapware] {app.Name} - {app.Description}", Color.PaleVioletRed);
                            break;
                        }
                    }
                }

                if (!foundMatch)
                {
                    logger.Log("Clippy says: Your PC is free of crapware.", Color.Green);
                }

                return foundMatch;
            }
        }

        public override bool DoFeature()
        {
            try
            {
                logger.Log($"The crapware removal was initiated again by you, {Environment.UserName}. Please wait...", Color.Green);

                List<AppInfo> apps = LoadAppsFromJson(jsonFilePath);

                using (PowerShell powerShell = PowerShell.Create())
                {
                    powerShell.AddCommand("get-appxpackage").AddCommand("Select").AddParameter("property", "name");

                    List<AppInfo> crapwareToRemove = new List<AppInfo>();

                    foreach (var app in apps)
                    {
                        foreach (PSObject result in powerShell.Invoke())
                        {
                            string current = result.ToString();

                            if (current.Contains(app.Name))
                            {
                                logger.Log($"[Removing Crapware] {app.Name}", Color.DeepPink);
                                crapwareToRemove.Add(app);
                                break;
                            }
                        }
                    }

                    if (crapwareToRemove.Count > 0)
                    {
                        RemoveApps(crapwareToRemove);
                        return true;
                    }

                    logger.Log("Clippy says: Crapware removal completed.", Color.Green);
                }

                logger.Log("Clippy says: Your PC is free of crapware.", Color.Green);
                return false;
            }
            catch (Exception ex)
            {
                logger.Log($"Code red in crapware removal: {ex.Message}", Color.Red);
                return false;
            }
        }

        private async Task RemoveApps(List<AppInfo> apps)
        {
            try
            {
                foreach (var app in apps)
                {
                    logger.Log($"Removing crapware: {app.Name} - {app.Description}", Color.Red);
                    await ExecutePowerShellCommand(app.RemoveCommand);
                    logger.Log("I did it.", Color.MediumSeaGreen);
                }

                logger.Log("I have finished everything.", Color.Green);
            }
            catch (Exception ex)
            {
                logger.Log("[!] Code red in PowerShell command: " + ex.Message, Color.Red);
            }
        }

        public override bool UndoFeature()
        {
            return false;
        }
    }
}