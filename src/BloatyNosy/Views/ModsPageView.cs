using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatyNosy
{
    public partial class ModsPageView : UserControl
    {
        private ModsManifest _Modsmanifest = new ModsManifest();
        private List<string> ModsList = new List<string>();

        public Control INavPage;

        public ModsPageView()
        {
            InitializeComponent();

            InitializeMods();
            listMods.Items.AddRange(ModsList.ToArray());

            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            HideTabsOnTabControl(tabD);

            BackColor =
            listMods.BackColor =
            tabD.BackColor =
            tabDescription.BackColor =
            tabCode.BackColor =
            rtbDesc.BackColor =
            rtbCode.BackColor =
                Color.FromArgb(245, 241, 249);

            btnHMenu.Text = "\uE700";
            btnBack.Text = "\uE72B";

            INavPage = pnlForm.Controls[0];     // Set default NavPage
        }

        public void SetView(Control View)
        {
            var control = View as Control;

            control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            control.Dock = DockStyle.Fill;
            INavPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            INavPage.Dock = DockStyle.Fill;

            pnlForm.Controls.Clear();
            pnlForm.Controls.Add(View);
        }

        private void HideTabsOnTabControl(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void InitializeMods()
        {
            listMods.Items.Clear();

            try
            {
                string[] manifests = Directory.GetFiles(HelperTool.Utils.Data.ModsRootDir, "*.ini");
                foreach (string manifest in manifests)
                {
                    ModsList.Add(Path.GetFileNameWithoutExtension(manifest));
                }
            }
            catch { lblStatus.Text = "No Mods installed"; btnApply.Visible = false; btnCancel.Visible = false; }
        }

        private async void DoMods(string language)
        {
            var scriptPath = HelperTool.Utils.Data.ModsRootDir + _Modsmanifest.ConditionScript;
            // Check e.g. -noexit switch to prevent the PowerShell Console window from closing
            var scriptParam = _Modsmanifest.ini.ReadString("Info", "ScriptParam", "");

            lblStatus.Text = $"Processing \"{scriptPath}\"";

            btnApply.Enabled = false;
            btnCancel.Visible = true;
            progress.Visible = true;
            progress.Style = ProgressBarStyle.Marquee;
            progress.MarqueeAnimationSpeed = 30;

            try
            {
                switch (language)
                {
                    case "PowerShell":

                        var startInfo = new ProcessStartInfo()
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-executionpolicy bypass {scriptParam} -file \"{scriptPath}\"",
                            UseShellExecute = false,
                            CreateNoWindow = Convert.ToBoolean(_Modsmanifest.ini.ReadString("Info", "CreateNoWindow", ""))
                        };

                        await Task.Run(() =>
                        {
                            Process.Start(startInfo).WaitForExit();
                        });

                        break;

                    case "Command-line":
                        var process = Process.Start(new ProcessStartInfo("cmd", "/C " + scriptPath)
                        {
                            RedirectStandardOutput = true,
                            WorkingDirectory = HelperTool.Utils.Data.ModsRootDir,
                            UseShellExecute = false,
                            CreateNoWindow = Convert.ToBoolean(_Modsmanifest.ini.ReadString("Info", "CreateNoWindow", ""))
                        });

                        await Task.Run(() =>
                        {
                            process.WaitForExit();
                        });

                        break;
                }
                lblStatus.Text = "Installed Mods";
                progress.Visible = false;
                btnCancel.Visible = false;
                btnApply.Enabled = true;
                MessageBox.Show("Mod has been successfully applied.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException ex)
            {
                string title = "This did not work...";
                string logger = "Exception in \"" + language + "\"\n\n" + ex + "\n\nPlease report this issue to Builtbybel........";
                MessageBox.Show(this, logger, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
            => DoMods(_Modsmanifest.ScriptLanguage);

        private void btnCancel_Click(object sender, EventArgs e)
        {
            String CurrentUser = Environment.UserName;
            Process[] allProcesses = Process.GetProcessesByName("powershell");
            if (null != allProcesses)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C TASKKILL /F /FI \"USERNAME eq " + CurrentUser + "\" /IM powershell.exe";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }

            btnCancel.Visible = false;
        }

        private void menuModEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string scriptPath = HelperTool.Utils.Data.ModsRootDir + _Modsmanifest.ConditionScript;

                Process process = new Process();
                process.StartInfo.FileName = "powershell_ise.exe";
                process.StartInfo.Arguments = scriptPath;
                process.Start();
            }
            catch { MessageBox.Show("No Mod selected."); }
        }

        private void listMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scriptManifestFile = HelperTool.Utils.Data.ModsRootDir + listMods.Text + ".ini";
            _Modsmanifest.ini = new ModsParser(scriptManifestFile);
            string scriptPath = HelperTool.Utils.Data.ModsRootDir + _Modsmanifest.ConditionScript;

            try
            {
                // Catch description
                // Script name
                //listMods.Items.Add(_Modsmanifest.DisplayName);
                // Script description/publisher
                rtbDesc.Text = _Modsmanifest.AboutScript.Replace("\\n", "\r\n") +
                                  Environment.NewLine + Environment.NewLine + "Author of this Mod: " + _Modsmanifest.Publisher;

                // Catch Code
                using (StreamReader sr = new StreamReader(scriptPath, Encoding.Default))
                {
                    StringBuilder content = new StringBuilder();

                    while (!sr.EndOfStream)
                        content.AppendLine(sr.ReadLine());

                    rtbCode.Text = string.Join(Environment.NewLine, File.ReadAllLines(scriptPath));
                }
            }
            catch { }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listMods.Items.Clear();

            foreach (string str in ModsList)
            {
                if (str.IndexOf(textSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    listMods.Items.Add(str);
                }
            }
        }

        private void textSearch_Click(object sender, EventArgs e)
             => textSearch.Text = "";

        private void rtbDesc_LinkClicked(object sender, LinkClickedEventArgs e)
             => HelperTool.Utils.LaunchUri(e.LinkText);

        public void lnkExploreMods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => this.SetView(new IModsPageView(this));

        private void lnkDesc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => tabD.SelectedIndex = 0;

        private void lnkCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => tabD.SelectedIndex = 1;

        private void btnHMenu_Click(object sender, EventArgs e)
            => this.contextAppMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.pnlForm.Controls.Add(mainForm.INavPage);
        }
    }
}