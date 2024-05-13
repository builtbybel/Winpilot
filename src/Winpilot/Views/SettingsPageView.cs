using Winpilot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class SettingsPageView : UserControl
    {
        public SettingsPageView()
        {
            InitializeComponent();
        }

        private void SettingsPageView_Load(object sender, EventArgs e)
        {
            btnBack.Text = "\uE72B";
            linkFollow.Text = "\uE8E1 GitHub";
            lblVersion.Text = "Version " + Program.GetCurrentVersionTostring() + " Stargate";
        }

        private void linkAppInfos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start("https://www.builtbybel.com/blog/bloatynosy-is-now-winpilot");

        private void linkFollow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://github.com/builtbybel/Winpilot");

        private void linkCreditsAppIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start("https://github.com/FireCubeStudios/Clippy/tree/master/Clippy/Assets/Clippy");

        private void btnBack_Click(object sender, EventArgs e)
            => Views.SwitchView.SetMainFormAsView();

        private void linkLicensesClippit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         => Process.Start("https://github.com/FireCubeStudios/Clippy/tree/master/Clippy/Assets/Clippy");
    }
}