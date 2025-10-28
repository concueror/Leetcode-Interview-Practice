namespace Leetcode.Problems.DotNet._104_Maximum_Depth_Of_Binary_Tree;

/// <summary>
/// Problem description: https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
/// Given the root of a binary tree, return its maximum depth.
/// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest
/// leaf node.
/// </summary>
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        return Go(root, 1, 1);
    }

    public int Go(TreeNode node, int depth, int max)
    {
        if (node == null) return max;

        if (node.left == null && node.right == null)
        {
            max = maxf(max, depth) < maxf(max, depth) ? maxf(max, depth) : maxf(max, depth);
            return max;
        }

        var d1 = Go(node.left, depth + 1, max);
        var d2 = Go(node.right, depth + 1, max);

        var m1 = maxf(max, depth);
        max = maxf(m1, d1) < maxf(m1, d2) ? maxf(m1, d2) : maxf(m1, d1);

        return max;
    }

    public int maxf(int a, int b)
    {
        return a < b ? b : a;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}