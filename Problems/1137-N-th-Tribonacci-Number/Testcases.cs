using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._1137_N_th_Tribonacci_Number;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.Tribonacci(4);

        result.Should().Be(4);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.Tribonacci(25);

        result.Should().Be(1389537);
    }
}
