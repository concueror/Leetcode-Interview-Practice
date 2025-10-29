using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._215_Kth_Largest_Element_In_An_Array;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.FindKthLargest([3, 2, 1, 5, 6, 4], 2);

        result.Should().Be(5);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.FindKthLargest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4);

        result.Should().Be(4);
    }
}
