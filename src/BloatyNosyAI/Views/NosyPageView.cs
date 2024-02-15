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

        // Store nodes that need to be removed in tvwFeatures
        private List<TreeNode> nodesToRemove = new List<TreeNode>();

        public NosyPageView(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.SetStyle();
            this.SetProfile();

            // Switch between default and plugin features
            if (checkLoadPlugins.Checked)
            {
                this.LoadPluginFeatures();
            }
            else
            {
                this.AddDefaultFeatures();
            }
        }

        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnMenuGripperBar.Text = "\uE784";
            btnAdd.Text = "\uE948";
            btnRemove.Text = "\uE921";
            btnAddAll.Text = "\uE76C";
            btnRemoveAll.Text = "\uE76B";
            btnLoadProfile.Text = "\uE71C";
            // Some color styling
            pnlNav.BackColor = Color.FromArgb(245, 241, 249);
            BackColor =
            sc.Panel1.BackColor =
            sc.Panel2.BackColor =
            rtbLog.BackColor = Color.FromArgb(243, 243, 243);
            // Log messages to target richLog
            logger.SetTarget(rtbLog);
            // Dynamically set OS information
            rtbLog.Text = $"Move all unwanted features of your Windows 11 {OsHelper.GetVersion()} " +
             "you don't plan to use on your device within Microsoft experiences to the right trash bin." +
             "\n\nYou can always revert these settings to default (except bloatware).";
            // Dynamically add trash bin text to right (bin) Treeview structure
            TreeNode binNode = new TreeNode("Trash bin     ");
            tvwFeaturesBin.Nodes.Add(binNode);
            tvwFeaturesBin.Nodes[0].NodeFont = new Font(tvwFeaturesBin.Font, FontStyle.Bold);
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
            TreeNode root = new TreeNode("Windows settings     ")
            {
                Checked = true,
            };

            TreeNode browser = new TreeNode("Browser", new TreeNode[] {
                 new FeatureNode(new Features.Feature.Browser.EdgeBingAIButton()),
                new FeatureNode(new Features.Feature.Browser.ChromeTelemetry()),
                new FeatureNode(new Features.Feature.Browser.FirefoxTelemetry()),
            })
            {
                Checked = true,
            };

            TreeNode explorer = new TreeNode("Explorer", new TreeNode[] {
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

            TreeNode system = new TreeNode("System", new System.Windows.Forms.TreeNode[] {
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
                new FeatureNode(new Features.Feature.Privacy.AppsAutoInstall()),
                new FeatureNode(new Features.Feature.Privacy.WindowsTips()),
                new FeatureNode(new Features.Feature.Privacy.TailoredExperiences()),
                new FeatureNode(new Features.Feature.Privacy.BackgroundApps()),
            })
            {
                Checked = true
            };

            TreeNode bloatware = new TreeNode("Bloatware", new TreeNode[] {
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

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore selected fixes to Windows default state?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                List<FeatureNode> performNodes = CollectFeatureNodes(tvwFeaturesBin);
                UndoFeatures(performNodes);
            }
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to apply selected fixes?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                // Apply regular features
                List<FeatureNode> regularFeatureNodes = CollectFeatureNodes(tvwFeaturesBin);
                ApplyFeatures(regularFeatureNodes);

                // Apply plugin features
                List<TreeNode> checkedPluginNodes = GetSelectedPluginNodes(tvwFeatures);
                await ApplyPlugins(checkedPluginNodes);
            }
        }

        // Retrieve checked nodes from the tvwFeatures in Plugins mode
        private List<TreeNode> GetSelectedPluginNodes(TreeView treeView)
        {
            List<TreeNode> checkedNodes = new List<TreeNode>();

            foreach (TreeNode rootNode in treeView.Nodes)
            {
                if (rootNode.Text == "Plugins")
                {
                    foreach (TreeNode pluginNode in rootNode.Nodes)
                    {
                        if (pluginNode.Checked)
                        {
                            checkedNodes.Add(pluginNode);
                        }
                    }
                }
            }

            return checkedNodes;
        }

        private void LoadPluginFeatures()
        {
            // Clear existing nodes
            tvwFeatures.Nodes.Clear();

            // Load plugins
            List<string> pluginFiles = AddPluginFeatures(HelperTool.Utils.Data.PluginsRootDir);

            if (pluginFiles.Count > 0)
            {
                // Create node for the plugins
                TreeNode pluginsNode = new TreeNode("Plugins");

                // Add PowerShell plugin files to the plugins node
                foreach (string pluginFile in pluginFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(pluginFile);
                    pluginsNode.Nodes.Add(new TreeNode(fileName));
                }

                // Add plugins node to the root node
                tvwFeatures.Nodes.Add(pluginsNode);
            }

            // Some tvw nicety
            foreach (TreeNode tn in tvwFeatures.Nodes) { tn.Expand(); }
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
            lnkStatus.Text = "Fixing completed.";

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
            lnkStatus.Text = "Undo completed.";

            tvwFeatures.Enabled = true;
        }

        private List<FeatureNode> CollectFeatureNodes(TreeView treeView)
        {
            List<FeatureNode> nodes = new List<FeatureNode>();

            // Iterate through each top-level node in the TreeView
            foreach (TreeNode rootNode in treeView.Nodes)
            {
                // Recursively collect nodes and child nodes
                CollectNodesRecursively(rootNode, nodes);
            }

            return nodes;
        }

        private void CollectNodesRecursively(TreeNode parentNode, List<FeatureNode> nodes)
        {
            // Assuming FeatureNode is actual type of nodes we are working with
            if (parentNode is FeatureNode featureNode)
            {
                nodes.Add(featureNode);
            }

            // Recursively collect child nodes
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                CollectNodesRecursively(childNode, nodes);
            }
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            // Check if empty
            if (tvwFeaturesBin.Nodes.Count == 1)
            {
                MessageBox.Show("The trash bin is empty.\n\nUnwanted features must be moved to the trash bin before analysis. Afterward, we can provide recommendations.", "Cutting-Edge Assistant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Reset();
            btnApply.Enabled = false;
            int performFeaturesCount = 0;

            // Collect feature nodes from the right TreeView
            List<FeatureNode> analyzedFeatures = CollectFeatureNodes(tvwFeaturesBin);
            // Console.WriteLine($"Number of nodes collected for analysis: {analyzedFeatures.Count}");

            foreach (FeatureNode node in analyzedFeatures)
            {
                var feature = node.Feature;

                // Console.WriteLine($"Collected node: {node.Text}");

                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => feature.CheckFeature()).ConfigureAwait(true);

                bool shouldPerform = await analyzeTask;

                lnkStatus.Text = "Check " + feature.ID();

                // logger.Log($"Analyzing feature: {feature.ID()}, shouldPerform: {shouldPerform}, node.Text: {node.Text}");

                if (shouldPerform)
                {
                    logger.Log(feature.ID());
                    performFeaturesCount += 1;
                    node.ForeColor = Color.MediumVioletRed;
                }
                else
                {
                    node.ForeColor = Color.Gray;
                }
            }

            DoProgress(100);

            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append($"We've checked {analyzedFeatures.Count} features.\r\n");
            sum.Append($"We recommend to disable {performFeaturesCount} of these features (highlighted in color).\r\n");

            logger.Log(sum.ToString(), "");
            btnApply.Enabled = true;
            lnkStatus.Text = $"There are {performFeaturesCount} features which require your attention.\r\n";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tvwFeatures.SelectedNode != null)
            {
                // Add everyrthing if root node to Tree structure
                if (tvwFeatures.SelectedNode.Level == 0)
                {
                    btnAddAll.PerformClick();
                }
                else
                {
                    // Add single nodes
                    AddNodeToRight(tvwFeatures.SelectedNode);

                    // Add selected node and its child nodes to right Tree structure
                    AddAllChildNodesToRight(tvwFeatures.SelectedNode);

                    // Analyze directly
                    btnAnalyze.PerformClick();

                    // When we remove a node, the collection is modified, and this can interfere with iteration. Therefor I've added this
                    RemoveNodesFromLeft();
                }
            }
        }

        private void AddNodeToRight(TreeNode node)
        {
            if (node is FeatureNode featureNode)
            {
                // Create new FeatureNode using FeatureBase from selected node
                FeatureNode newFeatureNode = new FeatureNode(featureNode.Feature);

                // Set Tag property to original parent node
                newFeatureNode.Tag = featureNode.Parent;

                // Add new FeatureNode to right TreeView
                tvwFeaturesBin.Nodes.Add(newFeatureNode);

                // Add original FeatureNode to removal list
                nodesToRemove.Add(featureNode);
            }
        }

        private void RemoveNodesFromLeft()
        {
            foreach (var node in nodesToRemove)
            {
                tvwFeatures.Nodes.Remove(node);
            }

            // Clear list after removal
            nodesToRemove.Clear();
        }

        private void AddAllChildNodesToRight(TreeNode parentNode)
        {
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                AddNodeToRight(childNode);

                // Recursively process child nodes
                AddAllChildNodesToRight(childNode);
            }
        }

        private void AddAll(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes.Cast<TreeNode>().ToArray())
            {
                if (node is FeatureNode featureNode)
                {
                    // Create new FeatureNode using FeatureBase the selected node
                    FeatureNode newFeatureNode = new FeatureNode(featureNode.Feature);

                    // Set Tag property to original parent node
                    newFeatureNode.Tag = featureNode.Parent;

                    // Add new FeatureNode to left TreeView
                    tvwFeaturesBin.Nodes.Add(newFeatureNode);

                    // Remove FeatureNode from left TreeView
                    tvwFeatures.Nodes.Remove(featureNode);
                }
                else
                {
                    //Console.WriteLine($"Skipped node of type: {node.GetType().Name}");
                }

                // Recursively process child nodes
                AddAll(node.Nodes);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            AddAll(tvwFeatures.Nodes);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if node is selected in right Tree structure
            if (tvwFeaturesBin.SelectedNode is FeatureNode selectedFeatureNode)
            {
                // Retrieve original parent node from Tag property
                if (selectedFeatureNode.Tag is TreeNode originalParentNode)
                {
                    // Create new FeatureNode using FeatureBase from selected node
                    FeatureNode newFeatureNode = new FeatureNode(selectedFeatureNode.Feature);

                    // Add new FeatureNode to original parent node
                    originalParentNode.Nodes.Add(newFeatureNode);

                    // Remove FeatureNode from right Tree stucture
                    tvwFeaturesBin.Nodes.Remove(selectedFeatureNode);
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (FeatureNode node in tvwFeaturesBin.Nodes.OfType<FeatureNode>().ToList())
            {
                // Retrieve original parent node from Tag property
                if (node.Tag is TreeNode originalParentNode)
                {
                    // Create new FeatureNode using FeatureBase from selected node
                    FeatureNode newFeatureNode = new FeatureNode(node.Feature);

                    // Add new FeatureNode to original parent node on left
                    originalParentNode.Nodes.Add(newFeatureNode);

                    // Remove FeatureNode from right Tree stucture
                    tvwFeaturesBin.Nodes.Remove(node);
                }
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

                                // Add marked feature to tvwFeatureBin
                                AddNodeToRight(treeNode);
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
                    foreach (TreeNode treeNode in tvwFeaturesBin.Nodes.All())
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

        private void btnLoadProfile_Click(object sender, EventArgs e)
             => this.contextMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void lnkAppBloatpilot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => ViewHelper.SwitchView.SetView(new BloatyPageView());

        private void btnMenuGripperBar_Click(object sender, EventArgs e)
             => ViewHelper.SwitchView.SetView(new SettingsPageView(mainForm));

        private void tvwFeatures_DoubleClick(object sender, EventArgs e)
             => btnAdd_Click(sender, e);

        private void tvwFeaturesBin_DoubleClick(object sender, EventArgs e)
             => btnRemove_Click(sender, e);

        private void checkLoadPlugins_CheckedChanged(object sender, EventArgs e)
        {
            // Reload features based on new state of the "Load plugins" checkbox
            if (checkLoadPlugins.Checked)
            {
                tvwFeatures.CheckBoxes = true;
                this.LoadPluginFeatures();
            }
            else
            {
                tvwFeatures.CheckBoxes = false;
                this.AddDefaultFeatures();
            }
        }
    }
}