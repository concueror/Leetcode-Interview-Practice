namespace Leetcode.Problems.DotNet._88_Merge_Sorted_Array;

/// <summary>
/// Problem description: https://leetcode.com/problems/merge-sorted-array/description/
/// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
/// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
/// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
/// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
/// </summary>
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (k > -1) {
            if (i > -1 && j > -1)
            {
                if (nums1[i] > nums2[j]) {
                    nums1[k] = nums1[i];                    
                    i--;
                } else {
                    nums1[k] = nums2[j];
                    j--;
                }
            } else if (i > -1) {
                nums1[k] = nums1[i];
                i--;
            } else if (j > -1) {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
    }
}
