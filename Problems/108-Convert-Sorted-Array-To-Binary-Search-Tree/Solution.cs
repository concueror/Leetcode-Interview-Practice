namespace Leetcode.Problems.DotNet._108_Convert_Sorted_Array_To_Binary_Search_Tree;

/// <summary>
/// Problem description: https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/
/// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
/// </summary>
public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums) {
        int to = nums.Length - 1;

        TreeNode tree = GetTree(nums, 0, to);

        return tree;
    }

    public TreeNode GetTree(int[] nums, int from, int to) {
        int center = (to - from) / 2;

        TreeNode left = null;
        if (from <= from + center - 1) {
            left = GetTree(nums, from, from + center - 1);
        }

        TreeNode right = null;

        if (from + center + 1 <= to) {
            right = GetTree(nums, from + center + 1, to);
        }

        TreeNode tree = new TreeNode(nums[from + center], left, right);

        return tree;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
