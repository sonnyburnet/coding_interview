namespace Algorithms.MaxDepth;


// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        int go(TreeNode? node, int x)
        {
            if (node == null)
                return x;
            var left_x = go(node.left, x + 1);
            var right_x = go(node.right, x + 1);
            return Math.Max(left_x, right_x);
        }
        return go(root, 0);
    }
}