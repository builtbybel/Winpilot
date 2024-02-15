using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bloatynosy.Views
{
    public partial class SettingsPageView : UserControl
    {
        private MainForm mainForm;
        private Stargazers github;

        public SettingsPageView(MainForm mainForm)
        {
            InitializeComponent();
            SetStyle();

            // Fetch Github Stargazers
            GetGitHubStargazers();
        }

        // Some UI nicety
        private void SetStyle()
        {
            btnBack.Text = "\uE72B";
            // Some color styling
            BackColor =
                Color.FromArgb(245, 241, 249);
        }

        private void GetGitHubStargazers()
        {
            github = new Stargazers();
            github.StargazersCountFetched += (sender, count) =>
            {
                if (count >= 0)
                    btnGithub.Text = $"{count}";
                else
                    lnkStargazers.Visible = true;
            };

            // Stargazers link Event listener
            lnkStargazers_LinkClicked(lnkStargazers, new LinkLabelLinkClickedEventArgs(lnkStargazers.Links[0]));
        }

        private void btnEditBloatESignature_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = System.IO.Path.Combine(HelperTool.Utils.Data.DataRootDir, "BLOAT-E.txt");

                if (System.IO.File.Exists(filePath))
                {
                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("Private Signature file for BLOAT-E could not be found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
           => ViewHelper.SwitchView.SetMainFormAsView();

        private void btnAppWizard_Click(object sender, EventArgs e)
           => ViewHelper.SwitchView.SetView(new WizardPageView(mainForm));

        private void btnAppPackages_Click(object sender, EventArgs e)
           => ViewHelper.SwitchView.SetView(new PackagesPageView());

        private void lnkURLTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
           => Process.Start(HelperTool.Utils.Uri.URL_TWITTER);

        private void lnkURLDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_BUILTBYBEL);

        private void lnkURLHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(HelperTool.Utils.Uri.URL_HELP);

        private void btnURLDonate_Click(object sender, EventArgs e)
            => Process.Start(HelperTool.Utils.Uri.URL_DONATE);

        private void btnOpenPluginsDir_Click(object sender, EventArgs e)
            => Process.Start(new ProcessStartInfo("explorer.exe", HelperTool.Utils.Data.PluginsRootDir) { UseShellExecute = true });

        private void btnOpenProfilesDir_Click(object sender, EventArgs e)
            => Process.Start(new ProcessStartInfo("explorer.exe", HelperTool.Utils.Data.DataRootDir) { UseShellExecute = true });

        private void lnkVoting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://www.builtbybel.com/blog/bloatynosy-is-now-x");

        private async void lnkStargazers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //e.Link.Visited = true;
            await github.FetchStargazersAsync();
        }

        private void btnGithub_Click(object sender, EventArgs e)
            => Process.Start(HelperTool.Utils.Uri.URL_GITREPO);
    }
}