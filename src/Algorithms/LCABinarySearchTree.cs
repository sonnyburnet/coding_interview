namespace Algorithms.LCABinarySearchTree;

// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/

//  Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int x) { val = x; }
}


public class Solution
{
    public TreeNode? LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode? go(TreeNode node)
        {
            if (node.left == null &&
              node.right == null)
                return node;
            var left = node.left;
            var right = node.right;
            if ((left == p && right == q) ||
               (left == q && right == p) || 
               (node == p && right == q) ||
               (node == q && right == p) ||
                (node == p && left == q) ||
               (node == q && left == p))
                return node;
            if(node.left != null) { return go(node.left); }
            if(node.right != null) { return go(node.right); }
            return null;
        }
        return go(root);
    }
}
