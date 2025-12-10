public class Solution {

    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/description/
    /// Given an integer array nums, find the subarray with the largest sum, and return its sum.
    /// </summary>
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int max = nums[0];
        int curSum = nums[0];

        for (int i = 1; i < n; i++) {
            curSum = nums[i] > curSum + nums[i] ? nums[i] : curSum + nums[i];
            max = curSum > max ? curSum : max;
        }
        return max;
    }
}