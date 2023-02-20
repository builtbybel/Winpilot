using System.Windows.Forms;

namespace Features.Feature
{
    internal class FeatureNode : TreeNode
    {
        public FeatureBase Feature { get; }

        public FeatureNode(FeatureBase feature)
        {
            Feature = feature;
            Text = Feature.ID();
            ToolTipText = Feature.Info();
            Checked = true;
        }
    }
}