using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._88_Merge_Sorted_Array;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new int[] { 2, 5, 6 };
        solution.Merge(nums1, 3, nums2, 3);

        nums1.Should().Equal([1, 2, 2, 3, 5, 6]);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var nums1 = new int[] { 1 };
        var nums2 = new int[] { };
        solution.Merge(nums1, 1, nums2, 0);

        nums1.Should().Equal([1]);
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var nums1 = new int[] { 0 };
        var nums2 = new int[] { 1 };
        solution.Merge(nums1, 0, nums2, 1);

        nums1.Should().Equal([1]);
    }
}
