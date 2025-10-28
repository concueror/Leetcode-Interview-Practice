using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._67_Add_Binary;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.AddBinary("11", "1");

        result.Should().Be("100");
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.AddBinary("1010", "1011");

        result.Should().Be("10101");
    }
}
