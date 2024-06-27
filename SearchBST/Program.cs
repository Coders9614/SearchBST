using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchBST
{
   public class Solution
    { 

        public TreeNodes SearchBST(TreeNodes root, int val)
        {
            if (root == null)
                return null;

            if (root.val == val)
                return root;

            if (val < root.val)
                return SearchBST(root.left, val);
            else
                return SearchBST(root.right, val);
        }

        public static void Main()
        {
            // Create a sample BST
           
            TreeNodes root = new TreeNodes(7);
            root.left = new TreeNodes(2);
            root.right = new TreeNodes(11);
            root.left.left = new TreeNodes(1);
            root.left.right = new TreeNodes(5);
            root.left.right.left = new TreeNodes(4);


            int targetValue = 5;

            TreeNodes result = new Solution().SearchBST(root, targetValue);


            if (result != null)
                Console.WriteLine($"Node with value {targetValue} found!");
            else
                Console.WriteLine($"Node with value {targetValue} not found.");
            Console.ReadKey();
        }
    }
}

