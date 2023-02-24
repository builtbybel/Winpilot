using BloatyNosy.ITreeNode;
using Features.Feature;
using HelperTool;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatyNosy
{
    public partial class MainForm : Form
    {
        public Control INavPage;
        private int progression = 0;
        private int progressionIncrease = 0;
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public MainForm()
           => InitializeComponent();

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.AddDefaultFeatures();
            this.AddMoreApps();

            this.SetStyle();
        }

        private void SetStyle()
        {
            btnAppOptions.Text = "\uE70D";
            btnKebapMenu.Text = "\u22ee";
            btnSettings.Text = "\uE713";
            btnAnalyze.Text += "\x20" + OsHelper.thisOS;

            BackColor =
            tvwFeatures.BackColor =
            rtbLog.BackColor =
                Color.FromArgb(244, 241, 249);
            logger.SetTarget(rtbLog);          // Log messages to target richLog
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

        private void AddMoreApps()
        {
            cmbTools.Items.Add("InstaPackage");
            cmbTools.Items.Add("BloatFinder");
            cmbTools.Items.Add("WinModder");
            cmbTools.Items.Insert(0, "More Apps");
            cmbTools.SelectedIndex = 0;
        }

        /// <summary>
        /// Register some more Tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = Convert.ToString(cmbTools.SelectedItem);
            string[] keys = new string[] { "Insta", "Bloat", "Mod" };

            string sKeyResult = keys.FirstOrDefault<string>(s => message.Contains(s));

            switch (sKeyResult)
            {
                case "Insta":
                    this.SetView(new PackagesPageView());            // Packages > InstaPackages view
                    break;

                case "Bloat":
                    this.SetView(new AppsPageView());                // In-box apps > BloatFinder view
                    break;

                case "Mod":
                    this.SetView(new ModsPageView());               // Mods > WinModder view
                    break;

                default:
                    break;
            }
        }

        private void lnkRunSetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => this.SetView(new SetupPageView(this));               // Mods > Setup view

        private void btnSettings_Click(object sender, EventArgs e)
            => this.SetView(new AboutPageView());                    // Settings view

        public void AddDefaultFeatures()
        {
            tvwFeatures.Nodes.Clear();
            tvwFeatures.BeginUpdate();

            // Root node
            TreeNode root = new TreeNode("Problems to be checked ")
            {
                Checked = true,
            };

            TreeNode browser = new TreeNode("Browser", new TreeNode[] {
                new FeatureNode(new Features.Feature.Browser.ChromeTelemetry()),
                new FeatureNode(new Features.Feature.Browser.FirefoxTelemetry()),
            })
            {
                Checked = true,
            };

            TreeNode explorer = new TreeNode("Explorer", new TreeNode[] {
                new FeatureNode(new Features.Feature.Explorer.FileExplorer()),
                new FeatureNode(new Features.Feature.Explorer.HiddenFileFolder()),
                new FeatureNode(new Features.Feature.Explorer.HiddenFileExt()),
            })
            {
                Checked = true,
            };

            TreeNode desktop = new TreeNode("Desktop", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.Desktop.AppsTheme()),
                new FeatureNode(new Features.Feature.Desktop.WindowsTheme()),
                new FeatureNode(new Features.Feature.Desktop.Transparency()),
                new FeatureNode(new Features.Feature.Desktop.SnapAssistFlyout()),
                new FeatureNode(new Features.Feature.Desktop.Widgets()),
                new FeatureNode(new Features.Feature.Desktop.WidgetsRemove()),
                new FeatureNode(new Features.Feature.Desktop.Stickers()),
            })
            {
                Checked = true,
            };

            TreeNode taskbar = new TreeNode("Taskbar and Start menu", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.Taskbar.TaskbarSearch()),
                new FeatureNode(new Features.Feature.Taskbar.TaskbarChat()),
                new FeatureNode(new Features.Feature.Taskbar.TaskView()),
                new FeatureNode(new Features.Feature.Taskbar.MostUsedApps()),
                new FeatureNode(new Features.Feature.Taskbar.StartmenuLayout()),
            })
            {
                Checked = true,
            };

            TreeNode system = new TreeNode("System", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.System.FullContextMenus()),
                new FeatureNode(new Features.Feature.System.RemoveW11Watermark()),
                new FeatureNode(new Features.Feature.System.TeamsAutostart()),
                new FeatureNode(new Features.Feature.System.Fax()),
                new FeatureNode(new Features.Feature.System.XPSWriter()),
                new FeatureNode(new Features.Feature.System.TPMCheck()),
                new FeatureNode(new Features.Feature.System.OneDriveRemove()),
            })
            {
                Checked = true,
            };

            TreeNode gaming = new TreeNode("Gaming", new TreeNode[] {
                new FeatureNode(new Features.Feature.Gaming.GameDVR()),
                new FeatureNode(new Features.Feature.Gaming.PowerThrottling()),
                new FeatureNode(new Features.Feature.Gaming.VisualFX()),
            })
            {
                Checked = true,
            };

            TreeNode privacy = new TreeNode("Privacy", new TreeNode[] {
                new FeatureNode(new Features.Feature.Privacy.DiagnosticData()),
                new FeatureNode(new Features.Feature.Privacy.Telemetry()),
                new FeatureNode(new Features.Feature.Privacy.CompatibilityTelemetry()),
                new FeatureNode(new Features.Feature.Privacy.LocationTracking()),
                new FeatureNode(new Features.Feature.Privacy.Advertising()),
                new FeatureNode(new Features.Feature.Privacy.Feedback()),
                new FeatureNode(new Features.Feature.Privacy.SuggestedContent()),
                new FeatureNode(new Features.Feature.Privacy.Biometrics()),
                new FeatureNode(new Features.Feature.Privacy.AppsAutoInstall()),
                new FeatureNode(new Features.Feature.Privacy.WindowsTips()),
                new FeatureNode(new Features.Feature.Privacy.TailoredExperiences()),
            })
            {
                Checked = true
            };

            TreeNode components = new TreeNode("Feature Recommendation", new TreeNode[] {
                new FeatureNode(new Features.Feature.Recommendation.EnableWSL()),
            })
            {
                Checked = true,
            };

            TreeNode apps = new TreeNode("Bloatware (from Microsoft, ASUS, Adobe, HP, Meta etc.)", new TreeNode[] {
                new FeatureNode(new Features.Feature.Apps.StoreApps()),
            })
            {
                Checked = true,
            };

            root.Nodes.AddRange(new TreeNode[]
            {
                browser,
                explorer,
                desktop,
                taskbar,
                system,
                gaming,
                privacy,
                components,
                apps,
            });

            tvwFeatures.Nodes.Add(root);

            // Some tvw nicety
            foreach (TreeNode tn in tvwFeatures.Nodes) { tn.Expand(); }
            tvwFeatures.Nodes[0].NodeFont = new Font(tvwFeatures.Font, FontStyle.Bold);
            tvwFeatures.EndUpdate();
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            Reset();
            btnAnalyze.Enabled = false;
            int performFeaturesCount = 0;

            List<FeatureNode> selectedFeatures = CollectFeatureNodes();

            foreach (FeatureNode node in selectedFeatures)
            {
                var feature = node.Feature;
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => feature.CheckFeature()).ConfigureAwait(true);
                // logger.Log("Check {0}", node.Text);

                bool shouldPerform = await analyzeTask;
                lnkSubHeader.Text = "Check " + feature.ID();

                if (menuIgnoreLowLevelP.Checked == true)
                    if (shouldPerform & !node.Text.Contains("LOW"))
                    {
                        logger.Log("Problem on " + node.Parent.Text + ": " + feature.ID());
                        //logger.Log("- {0}", node.Text);

                        performFeaturesCount += 1;
                        node.ForeColor = Color.MediumVioletRed;
                    }
                    else
                    {
                        node.Checked = false; // Uncheck all fixed
                        node.ForeColor = Color.Gray;
                        //logger.Log("Problem fixed: {0}", node.Text);
                    }
                else if (shouldPerform)
                {
                    logger.Log("Problem on " + node.Parent.Text + ": " + feature.ID());
                    performFeaturesCount += 1;
                    node.ForeColor = Color.MediumVioletRed;
                }
                else
                {
                    node.Checked = false;
                    node.ForeColor = Color.Gray;
                }
            }

            tvwFeatures.ExpandAll();
            tvwFeatures.SelectedNode = tvwFeatures.Nodes[0];
            DoProgress(100);

            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("======= Summary =======\n");
            sum.Append($"We've checked {selectedFeatures.Count} features of your Windows 11 installation.\r\n");
            sum.Append($"We like {selectedFeatures.Count - performFeaturesCount} of these features (no need for action).\r\n");

            logger.Log(sum.ToString(), ""); btnAnalyze.Enabled = true;
            lnkSubHeader.Text = $"There are {performFeaturesCount} features we don't like and which should be fixed (click for details).\r\n";
        }

        private void SelectFeatureNodes(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    SelectFeatureNodes(trNode.Nodes, isCheck);
            }
        }

        private List<FeatureNode> CollectFeatureNodes()
        {
            List<FeatureNode> selectedFeatures = new List<FeatureNode>();

            foreach (TreeNode treeNode in tvwFeatures.Nodes.All())
            {
                if (treeNode.Checked && treeNode.GetType() == typeof(FeatureNode))
                {
                    selectedFeatures.Add((FeatureNode)treeNode);
                }
            }

            progressionIncrease = (int)Math.Floor(100.0f / selectedFeatures.Count);

            return selectedFeatures;
        }

        private void Reset()
        {
            progression = 0;
            progressionIncrease = 0;

            progress.Value = 0;
            progress.Visible = true;
            rtbLog.Visible = true;
            rtbLog.Text = "";
        }

        private void DoProgress(int value)
        {
            progression = value;
            progress.Value = progression;
        }

        private void IncrementProgress()
        {
            progression += progressionIncrease;
            progress.Value = progression;
        }

        private async void ApplyFeatures(List<FeatureNode> treeNodes)
        {
            tvwFeatures.Enabled = false;

            foreach (FeatureNode node in treeNodes)
            {
                var assessment = node.Feature;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.DoFeature()).ConfigureAwait(true);

                lnkSubHeader.Text = "Fixing " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            tvwFeatures.Enabled = true;
        }

        private async void UndoFeatures(List<FeatureNode> treeNodes)
        {
            tvwFeatures.Enabled = false;

            foreach (FeatureNode node in treeNodes)
            {
                var assessment = node.Feature;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.UndoFeature()).ConfigureAwait(true);

                lnkSubHeader.Text = "Restore " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            tvwFeatures.Enabled = true;
        }

        private void menuFix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbLog.Text))
            {
                MessageBox.Show("No analyze has taken place yet.");
                return;
            }

            Reset();

            List<FeatureNode> performNodes = CollectFeatureNodes();
            ApplyFeatures(performNodes);
        }

        private void menuRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore selected features to Windows default state?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                List<FeatureNode> performNodes = CollectFeatureNodes();
                UndoFeatures(performNodes);
            }
        }

        private void treeFeatures_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tvwFeatures.BeginUpdate();

            foreach (TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }

            tvwFeatures.EndUpdate();
        }

        private void menuAdvanced_Click(object sender, EventArgs e)
        {
            menuAdvanced.Checked = !(menuAdvanced.Checked);

            if (menuAdvanced.Checked == true)
            {
                tvwFeatures.Visible = true;
                tvwFeatures.BringToFront();
            }
            else if (menuAdvanced.Checked == false)
                tvwFeatures.Visible = false;
            rtbLog.Visible = true;
        }

        private void menuIgnoreLowLevelP_Click(object sender, EventArgs e)
        {
            menuIgnoreLowLevelP.Checked = !(menuIgnoreLowLevelP.Checked);
            SelectFeatureNodes(tvwFeatures.Nodes, true);
        }

        private void richLog_LinkClicked(object sender, LinkClickedEventArgs e)
            => Utils.LaunchUri(e.LinkText);

        private void btnAppOptions_Click(object sender, EventArgs e)
             => this.contextAppMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void btnMenu_Click(object sender, EventArgs e)
            => this.contextKebapMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => menuAdvanced.PerformClick();

        private void menuImportProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = HelperTool.Utils.Data.DataRootDir;
            f.Filter = "BloatyNosy files (*.bloos)|*.bloos|ThisIsWin11 files (*.tiw1)|*.tiw1";

            if (f.ShowDialog() == DialogResult.OK)
            {
                SelectFeatureNodes(tvwFeatures.Nodes, false);
                tvwFeatures.ExpandAll();
                tvwFeatures.Nodes[0].EnsureVisible();
                menuAdvanced.PerformClick();

                using (StreamReader reader = new StreamReader(f.OpenFile()))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        foreach (TreeNode treeNode in tvwFeatures.Nodes.All())
                        {
                            if (treeNode.Text.Contains(line))
                            {
                                treeNode.BackColor = Color.Yellow;
                                treeNode.Text += "\x20" + "(" + Path.GetFileNameWithoutExtension(f.FileName) + ")";
                                treeNode.Checked = true;
                            }
                        }
                    }

                    MessageBox.Show("Profile has been successfully imported.\n\nWe have highlighted the configuration that would be enabled (no changes are done yet).", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuExportProfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = HelperTool.Utils.Data.DataRootDir;
            f.FileName = "debloos-profile";
            f.Filter = "BloatyNosy files *.bloos|*.bloos";

            if (f.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(f.OpenFile()))
                {
                    foreach (TreeNode treeNode in tvwFeatures.Nodes.All())
                    {
                        if (!treeNode.Checked)
                            continue;
                        writer.WriteLine(String.Format("{0}", treeNode.Text));
                    }

                    writer.Close();
                }
                MessageBox.Show("Profile has been successfully exported.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}