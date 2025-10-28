using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._50_Pow_x_n;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.MyPow(2.00000, 10);

        result.Should().BeApproximately(1024.00000, 0.00001);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.MyPow(2.10000, 3);

        result.Should().BeApproximately(9.26100, 0.00001);
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.MyPow(2.00000, -2);

        result.Should().BeApproximately(0.25000, 0.00001);
    }
}
