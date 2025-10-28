namespace Leetcode.Problems.DotNet._1_Two_Sum;

/// <summary>
/// Problem description: https://leetcode.com/problems/two-sum/description/
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// </summary>
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for (int i = 0; i < nums.Length - 1; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return [i, j];
                }
            }
        }

        return [];
    }
}