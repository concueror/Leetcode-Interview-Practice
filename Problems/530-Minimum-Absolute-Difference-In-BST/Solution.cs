namespace Leetcode.Problems.DotNet._530_Minimum_Absolute_Difference_In_BST;

/// <summary>
/// Problem description: https://leetcode.com/problems/minimum-absolute-difference-in-bst/description/
/// Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two
/// different nodes in the tree.
/// </summary>
public class Solution
{
    public int minv = -10000000;
    public int maxv = 10000000;

    public int GetMinimumDifference(TreeNode root)
    {
        var allMin = maxv;

        DrillTree(root, ref allMin);

        return allMin;
    }

    public void DrillTree(TreeNode node, ref int allMin)
    {
        if (node == null) return;

        var left = GetMaxTree(node.left, minv);
        var right = GetMinTree(node.right, maxv);

        var min = Math.Abs(node.val - left) < Math.Abs(node.val - right)
            ? Math.Abs(node.val - left)
            : Math.Abs(node.val - right);
        allMin = Min(min, allMin);

        //var minValue = left != minv ? Min(node.val, left) : node.val; 

        DrillTree(node.left, ref allMin);
        DrillTree(node.right, ref allMin);

        //return minValue;
    }

    public int GetMinTree(TreeNode node, int val)
    {
        if (node == null) return val;

        var leftm = maxv;
        var rightm = maxv;
        if (node.left != null)
        {
            leftm = GetMinTree(node.left, val);
        }

        if (node.right != null)
        {
            rightm = GetMinTree(node.right, val);
        }

        var m = Min(val, node.val);
        m = Min(m, leftm);
        m = Min(m, rightm);
        return m;
    }

    public int GetMaxTree(TreeNode node, int val)
    {
        if (node == null) return val;

        var leftm = minv;
        var rightm = minv;
        if (node.left != null)
        {
            leftm = GetMaxTree(node.left, val);
        }

        if (node.right != null)
        {
            rightm = GetMaxTree(node.right, val);
        }

        var m = Max(val, node.val);
        m = Max(m, leftm);
        m = Max(m, rightm);
        return m;
    }

    public int Min(int a, int b)
    {
        return a < b ? a : b;
    }

    public int Max(int a, int b)
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