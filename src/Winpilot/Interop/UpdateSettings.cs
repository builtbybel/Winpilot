using Winpilot;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using WUApiLib;

namespace Interop
{
    public class UpdateSettings : InteropBase
    {
        public UpdateSettings(MainForm form, Logger logger) : base(form, logger)
        {
        }

        // Run App update check
        public override void Execute()
        {
            Task.Run(() =>
            {
                logger.Log($"Checking for Winpilot (Current Version {Program.GetCurrentVersionTostring()}) updates. Please wait...", Color.Red);
                bool appUpdatesAvailable = CheckForAppUpdates();

                if (appUpdatesAvailable)
                {
                    logger.Log("Winpilot update is available. https://github.com/builtbybel/Winpilot/releases", Color.Magenta);
                }
                else
                {
                    logger.Log("No App updates found.", Color.Green);
                }
            });
        }

        // Run Windows update check
        public void RunWUpdateCheck()
        {
            Task.Run(() =>
            {
                bool windowsUpdatesAvailable = CheckForWindowsUpdates();

                if (windowsUpdatesAvailable)
                {
                    Process.Start("ms-settings:windowsupdate");
                    logger.Log("Windows updates are available. Consider installing them for improved system security.", Color.PaleVioletRed);
                }
                else
                {
                    logger.Log("No pending Windows updates found.", Color.Green);
                }
            });
        }

        private bool CheckForWindowsUpdates()
        {
            try
            {
                logger.Log($"Checking for Windows updates. Please wait...", Color.Red);

                UpdateSession updateSession = new UpdateSession();
                IUpdateSearcher updateSearcher = updateSession.CreateUpdateSearcher();

                // Search for pending updates
                ISearchResult searchResult = updateSearcher.Search("IsInstalled=0");

                return (searchResult.Updates.Count > 0);
            }
            catch (Exception ex)
            {
                logger.Log($"Code red for Windows updates check: {ex.Message}", Color.Red);
                return false;
            }
        }

        public bool CheckForAppUpdates()
        {
            if (IsInet() == true)
            {
                try
                {
                    string assemblyInfo = new WebClient().DownloadString("https://raw.githubusercontent.com/builtbybel/Winpilot/main/src/Winpilot/Properties/AssemblyInfo.cs");

                    var readVersion = assemblyInfo.Split('\n');
                    var infoVersion = readVersion.Where(t => t.Contains("[assembly: AssemblyFileVersion"));
                    var latestVersion = "";
                    foreach (var item in infoVersion)
                    {
                        latestVersion = item.Substring(item.IndexOf('(') + 2, item.LastIndexOf(')') - item.IndexOf('(') - 3);
                    }

                    if (latestVersion == Program.GetCurrentVersionTostring()) // Up-to-date
                    {
                        //MessageBox.Show($"No new updates available.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return false;
                    }

                    if (latestVersion != Program.GetCurrentVersionTostring()) // Update available
                    {
                        if (MessageBox.Show($"App version {latestVersion} available.\nDo you want to open the Download page?", "App update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/builtbybel/Winpilot/releases");
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    logger.Log($"Code red for App updates check: {ex.Message} Maybe the project is still too new.", Color.Red);
                }
            }
            else if (IsInet() == false)
            {
                logger.Log($"Problem on Internet connection: Checking for App updates failed", Color.Red);
            }

            // Return false if with exception or problem with inet
            return false;
        }

        // Check Inet
        public static bool IsInet()
        {
            try
            {
                using (var CheckInternet = new WebClient())
                using (CheckInternet.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}