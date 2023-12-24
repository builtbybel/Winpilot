using Bloatynosy;
using System;
using System.Windows.Forms;

namespace Features.Feature
{
    internal class FeatureNode : TreeNode
    {
        public FeatureBase Feature { get; }
        public string ScriptFilePath { get; set; } // Path to the external script file

        public FeatureNode(FeatureBase feature)
        {
            Feature = feature;
            Text = Feature.ID();
            Checked = true;
            ScriptFilePath = ""; // Initialize the script file path
        }

        public string GetFeatureInfo()
        {
            return Feature.Info();
        }
    }
}