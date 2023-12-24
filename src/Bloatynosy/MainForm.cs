using Bloatynosy.Views;
using HelperTool;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Bloatynosy
{
    public partial class MainForm : Form
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        // Declare nosyPage field
        private NosyPageView nosyPage;
        private System.Timers.Timer timer;
        private bool isMouseOverQRCode = false;

        public MainForm()
        {
            InitializeComponent();

            // Initialize NosyPageView
            nosyPage = new NosyPageView(this);

            //Load QR code
            GetQRCode();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

            // await Task.Delay(1000);

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
            // Some color styling
            BackColor = Color.FromArgb(243, 243, 243);
        }

        private void GetQRCode()
        {
            string imagePath = Path.Combine(HelperTool.Utils.Data.DataRootDir, "qr.png");

            if (File.Exists(imagePath))
            {
                picQR.Visible =
                lblQRInfo.Visible = true;
                picQR.Image = Image.FromFile(imagePath);
            }
            else
            {
                picQR.Visible =
                lblQRInfo.Visible = false;
            }

            // Set up QR code timer
            picQR.MouseEnter += picQR_MouseEnter;
            picQR.MouseLeave += picQR_MouseLeave;

            timer = new System.Timers.Timer();
            timer.Interval = 500; 
            timer.Elapsed += QRTimerElapsed;
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
            string fullVersion = Program.GetCurrentVersionTostring();

            // Display version based on the CheckBox state
            checkVersion.Text = checkVersion.Checked ? fullVersion : GetMinorVersion(fullVersion);

            // Optionally, check for updates when checked
            if (checkVersion.Checked)
            {
                HelperTool.Utils.CheckForUpdates();
            }
        }

        private void richLog_LinkClicked(object sender, LinkClickedEventArgs e)
            => Utils.LaunchUri(e.LinkText);

        private void picQR_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverQRCode = true;
            timer.Start();
        }

        private void picQR_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverQRCode = false;
            timer.Stop();
        }
        private void QRTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // This method will be called when timer elapses
            timer.Stop();

            if (isMouseOverQRCode)
            {
                DialogResult result = MessageBox.Show("Do you want to view the introduction directly in your Desktop Browser?", "Introducing Bloatynosy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Process.Start("https://www.builtbybel.com/blog/bloatynosy-is-now-x");
                }
            }
        }
    }
}