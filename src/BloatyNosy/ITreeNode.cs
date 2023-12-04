using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bloatynosy.ITreeNode
{
    public static class ITreeNode
    {
        //  Traverse tree and yields checked nodes
        public static IEnumerable<TreeNode> All(this TreeNodeCollection nodes)
        {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));

            foreach (TreeNode n in nodes)
            {
                yield return n;

                foreach (TreeNode child in n.Nodes.All())
                {
                    yield return child;
                }
            }
        }
    }
}