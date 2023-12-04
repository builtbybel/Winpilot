using Bloatynosy.ITreeNode;
using Features.Feature;
using HelperTool;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloatynosy.Views
{
    public partial class NosyPageView : UserControl
    {
        private MainForm mainForm;
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private int progression = 0;
        private int progressionIncrease = 0;

        public NosyPageView(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            this.AddDefaultFeatures();
            this.SetStyle();
            this.SetProfile();
        }

        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnHamburger.Text = "\uE700";
            btnNotePlugins.Text = "\uE8C3";

            // Some color styling
            pnlNav.BackColor = Color.FromArgb(245, 241, 249);
            BackColor =
            border.BackColor =
            sc.Panel1.BackColor =
            sc.Panel2.BackColor =
            lblHeader.BackColor =
            lnkStatus.BackColor =
            rtbLog.BackColor = Color.FromArgb(243, 243, 243);
            // Log messages to target richLog
            logger.SetTarget(rtbLog);
            // Border of middle page navigation
            border.FlatAppearance.MouseOverBackColor = border.BackColor;
            border.BackColorChanged += (s, e) =>
            {
                border.FlatAppearance.MouseOverBackColor = border.BackColor;
            };
        }

        private void SetProfile()
        {
            cbProfiles.Items.Clear();
            cbProfiles.Items.Insert(0, "Select profile");
            cbProfiles.SelectedIndex = 0;

            try
            {
                string[] files = Directory.GetFiles(HelperTool.Utils.Data.DataRootDir, "*.bloos");
                cbProfiles.Items.AddRange(files.Select((string filePath) => Path.GetFileNameWithoutExtension(filePath)).ToArray());
            }
            catch { cbProfiles.Text = "No profiles found."; }
        }

        public void Reset()
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

        public void AddDefaultFeatures()
        {
            tvwFeatures.Nodes.Clear();
            tvwFeatures.BeginUpdate();

            // Root node
            TreeNode root = new TreeNode("Potential issues on Windows 11 " + OsHelper.GetVersion())
            {
                Checked = true,
            };

            TreeNode browser = new TreeNode("1. Browser", new TreeNode[] {
                 new FeatureNode(new Features.Feature.Browser.EdgeBingAIButton()),
                new FeatureNode(new Features.Feature.Browser.ChromeTelemetry()),
                new FeatureNode(new Features.Feature.Browser.FirefoxTelemetry()),
            })
            {
                Checked = true,
            };

            TreeNode explorer = new TreeNode("2. Explorer", new TreeNode[] {
                new FeatureNode(new Features.Feature.Explorer.HiddenFileFolder()),
                new FeatureNode(new Features.Feature.Explorer.HiddenFileExt()),
            })
            {
                Checked = true,
            };

            TreeNode desktop = new TreeNode("3. Desktop", new System.Windows.Forms.TreeNode[] {
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

            TreeNode taskbar = new TreeNode("4. Taskbar and Start menu", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.Taskbar.Copilot()),
                new FeatureNode(new Features.Feature.Taskbar.TaskbarSearch()),
                new FeatureNode(new Features.Feature.Taskbar.TaskbarChat()),
                new FeatureNode(new Features.Feature.Taskbar.TaskView()),
                new FeatureNode(new Features.Feature.Taskbar.MostUsedApps()),
                new FeatureNode(new Features.Feature.Taskbar.StartmenuLayout()),
                new FeatureNode(new Features.Feature.Taskbar.StartmenuSearch()),
            })
            {
                Checked = true,
            };

            TreeNode system = new TreeNode("5. System", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.System.FullContextMenus()),
                new FeatureNode(new Features.Feature.System.RemoveW11Watermark()),
                new FeatureNode(new Features.Feature.System.TeamsAutostart()),
                new FeatureNode(new Features.Feature.System.Fax()),
                new FeatureNode(new Features.Feature.System.XPSWriter()),
                new FeatureNode(new Features.Feature.System.TPMCheck()),
            })
            {
                Checked = true,
            };

            TreeNode gaming = new TreeNode("6. Gaming", new TreeNode[] {
                new FeatureNode(new Features.Feature.Gaming.GameDVR()),
                new FeatureNode(new Features.Feature.Gaming.PowerThrottling()),
                new FeatureNode(new Features.Feature.Gaming.VisualFX()),
            })
            {
                Checked = true,
            };

            TreeNode privacy = new TreeNode("7. Privacy", new TreeNode[] {
                new FeatureNode(new Features.Feature.Privacy.DiagnosticData()),
                new FeatureNode(new Features.Feature.Privacy.Telemetry()),
                new FeatureNode(new Features.Feature.Privacy.CompatibilityTelemetry()),
                new FeatureNode(new Features.Feature.Privacy.LocationTracking()),
                new FeatureNode(new Features.Feature.Privacy.Advertising()),
                new FeatureNode(new Features.Feature.Privacy.Feedback()),
                new FeatureNode(new Features.Feature.Privacy.SuggestedContent()),
                new FeatureNode(new Features.Feature.Privacy.AppsAutoInstall()),
                new FeatureNode(new Features.Feature.Privacy.WindowsTips()),
                new FeatureNode(new Features.Feature.Privacy.TailoredExperiences()),
                new FeatureNode(new Features.Feature.Privacy.BackgroundApps()),
            })
            {
                Checked = true
            };

            TreeNode bloatware = new TreeNode("8. Bloatware", new TreeNode[] {
                new FeatureNode(new Features.Feature.Bloatware.StoreApps()),
                new FeatureNode(new Features.Feature.Bloatware.StoreAppsPrivate()),
                new FeatureNode(new Features.Feature.Bloatware.OneDriveRemove()),
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
                bloatware,
            });

            tvwFeatures.Nodes.Add(root);

            // 9. Plugins
            List<string> pluginFiles = AddPluginFeatures(HelperTool.Utils.Data.PluginsRootDir);

            if (pluginFiles.Count > 0)
            {
                // Create node for the plugins
                TreeNode pluginsNode = new TreeNode("9. Plugins");

                // Add PowerShell plugin files to the plugins node
                foreach (string pluginFile in pluginFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(pluginFile);
                    pluginsNode.Nodes.Add(new TreeNode(fileName));
                }

                // Add plugins node to the root node
                root.Nodes.Add(pluginsNode);
            }

            // Some tvw nicety
            foreach (TreeNode tn in tvwFeatures.Nodes) { tn.Expand(); }
            tvwFeatures.Nodes[0].NodeFont = new Font(tvwFeatures.Font, FontStyle.Bold);
            tvwFeatures.EndUpdate();
        }

        private List<string> AddPluginFeatures(string directory)
        {
            List<string> pluginFiles = new List<string>();

            try
            {
                // Get all PowerShell script files (*.ps1) in Plugins directory
                string[] files = Directory.GetFiles(directory, "*.ps1", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    // Add script file path to list
                    pluginFiles.Add(file);
                }
            }
            catch (Exception ex)
            {
                logger.Log("Error searching for Plugin files: " + ex.Message);
            }

            return pluginFiles;
        }

        public List<TreeNode> GetCheckedPluginNodes()
        {
            List<TreeNode> checkedNodes = new List<TreeNode>();

            // Iterate through all root nodes in the tree view
            foreach (TreeNode rootNode in tvwFeatures.Nodes)
            {
                // Check if root node has child nodes
                if (rootNode.Nodes.Count > 0)
                {
                    // Iterate through child nodes of the root
                    foreach (TreeNode childNode in rootNode.Nodes)
                    {
                        // Check if  child node is a Plugins node
                        if (childNode.Text.Contains("Plugins"))
                        {
                            // Iterate through child nodes of Plugins node (plugin scripts) and add checked nodes
                            foreach (TreeNode scriptNode in childNode.Nodes)
                            {
                                // Debugging
                                //  Console.WriteLine($"Plugin Node Text: {scriptNode.Text}, Checked: {scriptNode.Checked}");

                                if (scriptNode.Checked)
                                {
                                    checkedNodes.Add(scriptNode);
                                }
                            }
                        }
                    }
                }
            }

            // No checked nodes found?
            if (checkedNodes.Count == 0)
            {         // Debugging
                      //  Console.WriteLine("No plugin script is checked");
            }

            return checkedNodes;
        }

        internal List<FeatureNode> CollectFeatureNodes()
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

        private void tvwFeatures_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tvwFeatures.BeginUpdate();

            foreach (TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }

            tvwFeatures.EndUpdate();
        }

        private void tvwFeatures_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is FeatureNode featureNode)
            {
                logger.ClearLog();
                logger.Log(featureNode.GetFeatureInfo());
            }
        }

        public void SelectFeatureNodes(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    SelectFeatureNodes(trNode.Nodes, isCheck);
            }
        }

        private void ResetColorNode(TreeNodeCollection nodes, Color Color)
        {
            foreach (System.Windows.Forms.TreeNode child in nodes)
            {
                child.BackColor = Color;
                if (child.Nodes != null && child.Nodes.Count > 0)
                    ResetColorNode(child.Nodes, Color);
            }
        }

        private void menuLoadProfile_Click(object sender, EventArgs e)
        {
            string filePath = HelperTool.Utils.Data.DataRootDir + "\\" + cbProfiles.Text + ".bloos";

            ResetColorNode(tvwFeatures.Nodes, Color.White);
            SelectFeatureNodes(tvwFeatures.Nodes, false);
            tvwFeatures.ExpandAll();
            tvwFeatures.Nodes[0].EnsureVisible();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        foreach (System.Windows.Forms.TreeNode treeNode in tvwFeatures.Nodes.All())
                        {
                            if (treeNode.Text.Contains(line))
                            {
                                treeNode.BackColor = Color.Yellow;
                                treeNode.Checked = true;
                                tvwFeatures.SelectedNode = treeNode;
                            }
                        }
                    }
                    if (new FileInfo(filePath).Length == 0) logger.Log("- Empty configuration loaded.");
                }

                btnAnalyze.PerformClick();
                logger.Log($"[{cbProfiles.Text} has been successfully loaded].\nWe have highlighted the configuration that would be enabled (no changes are done yet).");
            }
            catch { { MessageBox.Show("No profile selected."); } }
        }

        private void menuExportProfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = HelperTool.Utils.Data.DataRootDir;
            f.FileName = "Bloatynosy-profile";
            f.Filter = "Bloatynosy files *.bloos|*.bloos";

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

        private FeatureNode GetSelectedFeatureNode()
        {
            if (tvwFeatures.SelectedNode is FeatureNode featureNode)
            {
                return featureNode;
            }

            return null;
        }

        private async Task<int> AnalyzeNode(FeatureNode node)
        {
            var feature = node.Feature;
            ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => feature.CheckFeature()).ConfigureAwait(true);

            bool shouldPerform = await analyzeTask;

            // Console.WriteLine($"Analyzing feature: {feature.ID()}, shouldPerform: {shouldPerform}, node.Text: {node.Text}");

            if (feature != null)
            {
                lnkStatus.Text = "Check " + feature.ID();

                if (shouldPerform && (!mainForm.CheckIgnoreLowIssuesChecked || !node.Text.Contains("LOW")))
                {
                    logger.Log("Problem on " + node.Parent.Text + ": " + feature.ID());
                    node.ForeColor = Color.MediumVioletRed;
                    return 1;
                }
                else
                {
                    // Console.WriteLine($"No action required for feature: {feature.ID()}, shouldPerform: {shouldPerform}, node.Text: {node.Text}");
                    node.Checked = false;
                    node.ForeColor = Color.Gray;
                }
            }

            return 0;
        }

        private async void menuAnalyzeThis_Click(object sender, EventArgs e)
        {
            Reset();
            btnApply.Enabled = false;
            int performFeaturesCount = 0;

            // Check if any node is selected
            FeatureNode selectedNode = GetSelectedFeatureNode();

            if (selectedNode != null)
            {
                performFeaturesCount += await AnalyzeNode(selectedNode);
            }

            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);

            if (performFeaturesCount > 0)
            {
                sum.Append($"We've checked the selected feature of your Windows 11 installation.\r\n");
                sum.Append($"We recommend to disable this feature.\r\n");
            }
            else
            {
                sum.Append($"The selected feature does not require action.\r\n");
            }

            logger.Log(sum.ToString(), "");
            btnApply.Enabled = true;
            lnkStatus.Text = $"There are {performFeaturesCount} features that require your attention.\r\n";
        }

        private void tvwFeatures_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvwFeatures.SelectedNode = tvwFeatures.GetNodeAt(e.X, e.Y);

                contextAppMenuOptions.Show(tvwFeatures, e.Location);
            }
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to apply selected fixes?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                // Apply regular features
                List<FeatureNode> regularFeatureNodes = CollectFeatureNodes();
                ApplyFeatures(regularFeatureNodes);

                // Apply plugin features
                List<TreeNode> checkedPluginNodes = GetCheckedPluginNodes();

                if (checkedPluginNodes.Count > 0)
                {
                    // Apply features from the checked plugin nodes
                    await ApplyPlugins(checkedPluginNodes);
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore selected fixes to Windows default state?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                List<FeatureNode> performNodes = CollectFeatureNodes();
                UndoFeatures(performNodes);
            }
        }

        private async Task ApplyPlugins(List<TreeNode> pluginNodes)
        {
            foreach (TreeNode selectedPluginNode in pluginNodes)
            {
                string pluginFilePath = Path.Combine(HelperTool.Utils.Data.PluginsRootDir, selectedPluginNode.Text + ".ps1");

                try
                {
                    // Call WindowsHelper > RunPowerShellScriptAsync
                    logger.Log($"Running plugin {selectedPluginNode.Text}...");
                    await WindowsHelper.RunPowerShellScript(pluginFilePath);
                    logger.Log($"- Running with plugin {selectedPluginNode.Text} [Done]");
                }
                catch (Exception ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }

        private async void ApplyFeatures(List<FeatureNode> treeNodes)
        {
            tvwFeatures.Enabled = false;

            foreach (FeatureNode node in treeNodes)
            {
                var assessment = node.Feature;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.DoFeature()).ConfigureAwait(true);

                lnkStatus.Text = "Fixing " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkStatus.Text = "Fixing complete (click for details).";

            tvwFeatures.Enabled = true;
        }

        private async void UndoFeatures(List<FeatureNode> treeNodes)
        {
            tvwFeatures.Enabled = false;

            foreach (FeatureNode node in treeNodes)
            {
                var assessment = node.Feature;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.UndoFeature()).ConfigureAwait(true);

                lnkStatus.Text = "Restore " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkStatus.Text = "Undo complete (click for details).";

            tvwFeatures.Enabled = true;
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            Reset();
            btnApply.Enabled = false;
            int performFeaturesCount = 0;

            List<FeatureNode> selectedFeatures = CollectFeatureNodes();

            foreach (FeatureNode node in selectedFeatures)
            {
                var feature = node.Feature;
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => feature.CheckFeature()).ConfigureAwait(true);

                bool shouldPerform = await analyzeTask;
                if (feature != null)
                {
                    lnkStatus.Text = "Check " + feature.ID();

                    if (mainForm.CheckIgnoreLowIssuesChecked == true)
                        if (shouldPerform & !node.Text.Contains("LOW"))
                        {
                            logger.Log(node.Parent.Text + ": " + feature.ID());

                            performFeaturesCount += 1;
                            node.ForeColor = Color.MediumVioletRed;
                        }
                        else
                        {
                            node.Checked = false; // Uncheck all fixed
                            node.ForeColor = Color.Gray;
                        }
                    else if (shouldPerform)
                    {
                        logger.Log(node.Parent.Text + ": " + feature.ID());
                        performFeaturesCount += 1;
                        node.ForeColor = Color.MediumVioletRed;
                    }
                    else
                    {
                        node.Checked = false;
                        node.ForeColor = Color.Gray;
                    }
                }
            }

            tvwFeatures.ExpandAll();
            DoProgress(100);

            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("======= Summary =======\n");
            sum.Append($"We've checked {selectedFeatures.Count} features of your Windows 11 installation.\r\n");
            sum.Append($"We like {selectedFeatures.Count - performFeaturesCount} of these features (no need for action).\r\n");
            sum.Append($"We recommend to disable {performFeaturesCount} of these features (highlighted in color).\r\n");

            logger.Log(sum.ToString(), "");
            btnApply.Enabled = true;
            lnkStatus.Text = $"There are {performFeaturesCount} features which require your attention.\r\n";
        }

        private void btnHamburger_Click(object sender, EventArgs e)
             => this.contextKebapMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void btnNotePlugins_Click(object sender, EventArgs e)
        {
            string message = "This version introduces an integrated plugin function that replaces the old WinModder module. The plugin scripts still rely on PowerShell code. Please note that as of today, no analysis takes place, and the plugins can only be applied.";

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Extract summary from Status text
            string summary = lnkStatus.Text.Replace("======= Summary =======", "").Trim();

            DialogResult result = MessageBox.Show(
                "Summary of problems:\n" + summary + "\n\nDo you want to ask the community for advice on applying these changes?",
                "Analysis advice",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Process.Start(HelperTool.Utils.Uri.URL_HELP);
            }
        }
    }
}