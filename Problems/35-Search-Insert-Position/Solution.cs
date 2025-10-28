namespace Leetcode.Problems.DotNet._35_Search_Insert_Position;

/// <summary>
/// Problem description: https://leetcode.com/problems/search-insert-position/description/
/// Given a sorted array of distinct integers and a target value, return the index if the target is found.
/// If not, return the index where it would be if it were inserted in order.
/// You must write an algorithm with O(log n) runtime complexity.
/// </summary>
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var index = 0;
        index = GetIndex(nums, target, 0, nums.Length - 1);
        return index;
    }

    public int GetIndex(int[] nums, int target, int from, int to)
    {
        var index = from + (to - from) / 2;

        if (nums[index] == target) return index;
        if (nums[index] < target && index + 1 <= to) return GetIndex(nums, target, index + 1, to);
        if (nums[index] > target && index - 1 >= from) return GetIndex(nums, target, from, index - 1);

        return nums[index] > target ? index : index + 1;
    }
}