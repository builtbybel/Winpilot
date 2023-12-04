using Bloatynosy.Views;
using HelperTool;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bloatynosy
{
    public partial class MainForm : Form
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private Stargazers github;

        // Declare nosyPage field
        private NosyPageView nosyPage;

        public MainForm()
        {
            InitializeComponent();

            // Initialize NosyPageView
            nosyPage = new NosyPageView(this);
            // Fetch Github Stargazers
            github = new Stargazers();
            github.StargazersCountFetched += (sender, count) =>
            {
                if (count >= 0)
                    lnkStargazers.Text = $"{count} Stars on Github";
                else
                    lnkStargazers.Text = "Error fetching stargazers";
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Stargazers link Event listener
            lnkStargazers_LinkClicked(lnkStargazers, new LinkLabelLinkClickedEventArgs(lnkStargazers.Links[0]));
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Refer to instance NosyPageView
            pnlMain.Controls.Add(nosyPage);
            nosyPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            nosyPage.Dock = DockStyle.Fill;
            // Refer Main and default NavPage
            ViewHelper.SwitchView.INavPage = pnlForm.Controls[0];
            ViewHelper.SwitchView.mainForm = this;
            // Get versioning
            checkVersion.Text = GetMinorVersion(Program.GetCurrentVersionTostring());
            // Load styling
            this.SetStyle();
        }

        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnGithub.Text += "\uEB52";
            // Some color styling
            BackColor = Color.FromArgb(243, 243, 243);
            pnlRight.BackColor =
            pnlRightSettings.BackColor = Color.White;

            // Ref. SplitterContainer scaling bugs in .Net https://github.com/dotnet/winforms/issues/3168 OBSOLETE!
            // this.sc.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        public bool CheckIgnoreLowIssuesChecked
        {
            get { return checkIgnoreLowIssues.Checked; }
        }

        private void checkIgnoreLowIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIgnoreLowIssues.Checked)
            {
                nosyPage.SelectFeatureNodes(nosyPage.tvwFeatures.Nodes, true);
            }
        }

        private string GetMinorVersion(string version)
        {
            // Display everything until the second dot without the dot
            int secondDotIndex = version.IndexOf('.', version.IndexOf('.') + 1);
            if (secondDotIndex != -1)
            {
                version = version.Substring(0, secondDotIndex);
            }
            return $"Version {version}";
        }

        // Switch between minor and full app version
        private void checkVersion_CheckedChanged(object sender, EventArgs e)
        {
            // Get full version
            string fullVersion =  Program.GetCurrentVersionTostring();

            // Display version based on the CheckBox state
            checkVersion.Text = checkVersion.Checked ? fullVersion :  GetMinorVersion(fullVersion);

            // Optionally, check for updates when checked
            if (checkVersion.Checked)
            {
                HelperTool.Utils.CheckForUpdates();
            }
        }

        private void richLog_LinkClicked(object sender, LinkClickedEventArgs e)
            => Utils.LaunchUri(e.LinkText);

        private void lnkURLDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
           => Process.Start(HelperTool.Utils.Uri.URL_BUILTBYBEL);

        private void lnkURLTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         => Process.Start(HelperTool.Utils.Uri.URL_TWITTER);

        private void lnkURLReddit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         => Process.Start(HelperTool.Utils.Uri.URL_HELP);

        private void lnkURLPayPal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          => Process.Start(HelperTool.Utils.Uri.URL_DONATE);

        private void btnGithub_Click(object sender, EventArgs e)
            => Process.Start(HelperTool.Utils.Uri.URL_GITREPO);

        private void btnMenuChevronDown_Click(object sender, EventArgs e)
            => this.contextMenuChevron.Show(Cursor.Position.X, Cursor.Position.Y);

        private void btnAppBloatpilot_Click(object sender, EventArgs e)
            => ViewHelper.SwitchView.SetView(new BloatyPageView());

        private void menuWizard_Click(object sender, EventArgs e)
            => ViewHelper.SwitchView.SetView(new WizardPageView(this));

        private void menuPackages_Click(object sender, EventArgs e)
            => ViewHelper.SwitchView.SetView(new PackagesPageView());

        private async void lnkStargazers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //e.Link.Visited = true;
            await github.FetchStargazersAsync();
        }
    }
}