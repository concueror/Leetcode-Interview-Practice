using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._4_Median_Of_Two_Sorted_Arrays;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.FindMedianSortedArrays([1, 3], [2]);

        result.Should().Be(2.00000);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.FindMedianSortedArrays([1, 2], [3, 4]);

        result.Should().Be(2.50000);
    }
}
