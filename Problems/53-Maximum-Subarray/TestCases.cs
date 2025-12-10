using NUnit.Framework;
using FluentAssertions;
namespace Leetcode.Problems.DotNet._53_Maximum_Subarray;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]);

        result.Should().Be(6);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.MaxSubArray([1]);

        result.Should().Be(1);
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.MaxSubArray([5, 4, -1, 7, 8]);

        result.Should().Be(23);
    }
}
