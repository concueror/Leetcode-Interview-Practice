using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._70_Climbing_Stairs;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.ClimbStairs(2);

        result.Should().Be(2);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.ClimbStairs(3);

        result.Should().Be(3);
    }
}
