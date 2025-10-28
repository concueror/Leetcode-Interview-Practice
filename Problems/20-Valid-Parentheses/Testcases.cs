using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._20_Valid_Parentheses;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.IsValid("()");

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.IsValid("()[]{}");

        result.Should().BeTrue();
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.IsValid("(]");

        result.Should().BeFalse();
    }

    [Test]
    public void Case4()
    {
        var solution = new Solution();
        var result = solution.IsValid("([])");

        result.Should().BeTrue();
    }

    [Test]
    public void Case5()
    {
        var solution = new Solution();
        var result = solution.IsValid("([)]");

        result.Should().BeFalse();
    }
}
