using HelperTool;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace BloatyNosy
{
    public partial class AboutPageView : UserControl
    {
        public AboutPageView()
        {
            InitializeComponent();

            SetStyle();
            CheckForUpdates();
        }

        // Some UI nicety
        private void SetStyle()
        {
            BackColor =
            _lblAppName.BackColor =
            _lblAssembly.BackColor =
            _lblWith.BackColor =
            _lblHeartFillEmoji.BackColor =
            _lblDev.BackColor =
              Color.FromArgb(245, 241, 249);

            btnBack.Text = "\uE72B";
            _lblAssembly.Text = "Version " + Program.GetCurrentVersionTostring();
            _lblHeartFillEmoji.Text = "\uEB52";
        }

        public void CheckForUpdates()
        {
            if (IsInet() == true)
            {
                try
                {
                    string assemblyInfo = new WebClient().DownloadString(Utils.Uri.URL_ASSEMBLY);

                    var readVersion = assemblyInfo.Split('\n');
                    var infoVersion = readVersion.Where(t => t.Contains("[assembly: AssemblyFileVersion"));
                    var latestVersion = "";
                    foreach (var item in infoVersion)
                    {
                        latestVersion = item.Substring(item.IndexOf('(') + 2, item.LastIndexOf(')') - item.IndexOf('(') - 3);
                    }

                    if (latestVersion ==
                        Program.GetCurrentVersionTostring())                      // Up-to-date
                    {
                        //logger.Log("No new release found.");
                        lnkUpdateAvailable.Visible = false;
                    }

                    if (latestVersion !=                                        // Update available
                          Program.GetCurrentVersionTostring())

                    {
                        lnkUpdateAvailable.Text = $"App version {latestVersion} available.";
                    }
                }
                catch (Exception ex)
                {
                    lnkUpdateAvailable.Text = $"Checking for App updates failed.\n{ex.Message}";
                }
            }
            else if (IsInet() == false)
            {
                lnkUpdateAvailable.Text = $"Problem on Internet connection: Checking for App updates failed";
            }
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

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.pnlForm.Controls.Add(mainForm.INavPage);
        }

        private void lblAppMediaGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_GITREPO);

        private void lblAppMediaTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_TWITTER);

        private void lblAppMediaPayPal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_DONATE);

        private void btnAppMediaTweetIntent_Click(object sender, System.EventArgs e)
             => Process.Start(HelperTool.Utils.TweetIntent);

        private void lnkUpdateAvailable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Utils.LaunchUri(Utils.Uri.URL_GITLATEST);

        private void btnHelp_Click(object sender, EventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_HELP);
        
    }
}