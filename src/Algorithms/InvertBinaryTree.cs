namespace Algorithms.InvertBinaryTree;

// https://leetcode.com/problems/invert-binary-tree/


// Definition for a binary tree node.
public class TreeNode
{
    static readonly int COUNT = 10;
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(
      int val = 0,
      TreeNode left = null,
      TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    static void print2DUtil(TreeNode root, int space)
    {
        // Base case
        if (root == null) {
          return;
        }

        // Increase distance between levels
        space += COUNT;

        // Process right child first
        print2DUtil(root.right, space);

        // Print current node after space
        // count
        Console.Write("\n");
        for (int i = COUNT; i < space; i++)
            Console.Write(" ");
        Console.Write(root.val + "\n");

        // Process left child
        print2DUtil(root.left, space);
    }

    // Wrapper over print2DUtil()
    public static void print2D(TreeNode root)
    {
        // Pass initial space count as 0
        print2DUtil(root, 0);
    }
}


public class Solution
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        void swap(TreeNode node)
        {
            if (node.left != null &&
              node.right != null)
            {
                var tmp = node.left;
                node.left = node.right;
                node.right = tmp;
                swap(node.left);
                swap(node.right);
            }
        } 
        if(root != null) swap(root);
        return root;
    }
}