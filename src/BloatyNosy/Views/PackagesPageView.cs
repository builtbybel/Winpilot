using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatyNosy
{
    public partial class PackagesPageView : UserControl
    {
        private List<string> Packages = new List<string>();
        private List<string> remoteApps = new List<string>();

        public PackagesPageView()
        {
            InitializeComponent();

            RequestPackagesRemote();
            listRemote.Items.AddRange(remoteApps.ToArray());

            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            BackColor =
            listRemote.BackColor =
            listLocal.BackColor =
            richStatus.BackColor =
              Color.FromArgb(245, 241, 249);
            btnBack.Text = "\uE72B";
        }

        public void RequestPackagesRemote()
        {
            try
            {
                var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/builtbybel/BloatyNosy/main/assets/packages.git");
                string app;

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var sr = new StreamReader(content))
                {
                    while ((app = sr.ReadLine()) != null)
                    {
                        {
                            if (!app.StartsWith("#") && (!string.IsNullOrEmpty(app)))
                            {
                                remoteApps.Add(app);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRemote.Items.Clear();

            foreach (string str in remoteApps)
            {
                if (str.IndexOf(textSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    listRemote.Items.Add(str);
                }
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listRemote.Items)
            {
                listLocal.Items.Add(item);
            }
            listRemote.Items.Clear();
            RefreshPackages();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listRemote.Items.Count != 0)
            {
                if (listRemote.SelectedItem == null) listRemote.SelectedIndex = 0;
                while (listRemote.SelectedItem != null)
                {
                    listLocal.Items.Add(listRemote.SelectedItem);
                    listRemote.Items.Remove(listRemote.SelectedItem);
                }
                RefreshPackages();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listLocal.Items.Count != 0)
            {
                if (listLocal.SelectedItem == null) listLocal.SelectedIndex = 0;
                while (listLocal.SelectedItem != null)
                {
                    listRemote.Items.Add(listLocal.SelectedItem);
                    listLocal.Items.Remove(listLocal.SelectedItem);
                }
                RefreshPackages();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listLocal.Items)
            {
                listRemote.Items.Add(item);
            }
            listLocal.Items.Clear();
            RefreshPackages();
        }

        public void WingetInstallPackage(string packageid)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = HelperTool.Utils.Paths.ShellPS,
                    Arguments = "winget install --id " + packageid + " --accept-source-agreements --accept-package-agreements",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            proc.Start();
            proc.WaitForExit();
        }

        private void RefreshPackages()
        {
            if (listLocal.Items.Count == 0)
            {
                richStatus.Visible = true;
                listLocal.Visible = false;
            }
            else
            {
                listLocal.Visible = true;
                richStatus.Visible = false;
            }
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            richStatus.Visible = true;
            listLocal.Visible = false;
            btnInstall.Enabled = false;

            StringBuilder message = new StringBuilder();

            foreach (string p in listLocal.Items)
            {
                Packages.Add(p);
            }

            foreach (string p in Packages)
            {
                richStatus.Text += Environment.NewLine + "Installing -" + p;
                await Task.Run(() => WingetInstallPackage(p));
            }

            groupBox1.Text = "The following apps have been installed";
            listLocal.Visible = true;
            btnInstall.Enabled = true;
            richStatus.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.pnlForm.Controls.Add(mainForm.INavPage);
        }

        private void textSearch_Click(object sender, EventArgs e)
            => textSearch.Text = "";
    }
}