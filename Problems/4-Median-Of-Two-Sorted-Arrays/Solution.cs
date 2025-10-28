namespace Leetcode.Problems.DotNet._4_Median_Of_Two_Sorted_Arrays;

/// <summary>
/// Problem description: https://leetcode.com/problems/median-of-two-sorted-arrays/description/
/// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
/// The overall run time complexity should be O(log (m+n)).
/// </summary>
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var size = nums1.Length + nums2.Length;
        var i = -1;
        var j = -1;
        var k = -1;
        var median = (double)size / 2;
        var chetnoe = size % 2 == 0;
        double value = nums1.Length > 0 && nums2.Length > 0
            ? nums1[0] < nums2[0] ? nums1[0] : nums2[0]
            : nums1.Length > 0
                ? nums1[0]
                : nums2[0];
        var prevValue = value;
        while (true)
        {
            if (k == median && chetnoe)
            {
                return (value + prevValue) / 2;
            }

            if (k == (int)median && !chetnoe)
            {
                return value;
            }

            prevValue = value;

            if (i + 1 < nums1.Length && j + 1 < nums2.Length)
            {
                if (nums1[i + 1] > nums2[j + 1])
                {
                    value = nums2[j + 1];
                    j++;
                }
                else
                {
                    value = nums1[i + 1];
                    i++;
                }

                k++;
            }
            else if (i + 1 < nums1.Length)
            {
                value = nums1[i + 1];
                i++;
                k++;
            }
            else if (j + 1 < nums2.Length)
            {
                value = nums2[j + 1];
                j++;
                k++;
            }
        }
    }
}
