namespace Algorithms.DiameterOfBinaryTree;

// https://leetcode.com/problems/diameter-of-binary-tree/

// Given the root of a binary tree, return the length of the diameter of the tree.
// The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
// The length of a path between two nodes is represented by the number of edges between them.

using System;
using D = System.Diagnostics;

// Definition for a binary tree node.
public class TreeNode
{

    static readonly int COUNT = 10;

    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(
      int val = 0,
      TreeNode? left = null,
      TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    // Function to print binary tree in 2D
    // It does reverse inorder traversal
    static void print2DUtil(TreeNode? root, int space)
    {
        // Base case
        if (root == null)
            return;

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
    public static int DiameterOfBinaryTree(TreeNode root)
    {
        int go(TreeNode? node, int x)
        {
            if (node == null)
                return 0;
            var left_x = node.left != null ? go(node.left, x + 1) : 0;
            var right_x = node.right != null ? go(node.right, x + 1) : 0;
            return x + Math.Max(left_x, right_x);
        }
        return go(root, 0);
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        bool go(TreeNode first, TreeNode second)
        {
            
            if(first == null && second == null)
              return true;
            if(first == null && second != null)
              return false;
            if(first != null && second == null)
              return false;
            return first.val == second.val;
            go(first.left, second.left);
            go(first.right, second.right);
        }
        return go(p, q);
    }
}