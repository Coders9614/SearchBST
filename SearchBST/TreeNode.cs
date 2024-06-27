using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchBST
{
    public class TreeNodes
    {
        public int val;
        public TreeNodes left;
        public TreeNodes right;

        public TreeNodes(int val = 0, TreeNodes left = null, TreeNodes right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

    }
}
