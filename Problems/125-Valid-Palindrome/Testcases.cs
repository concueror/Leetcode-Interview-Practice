using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._125_Valid_Palindrome;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.IsPalindrome("A man, a plan, a canal: Panama");

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.IsPalindrome("race a car");

        result.Should().BeFalse();
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.IsPalindrome(" ");

        result.Should().BeTrue();
    }
}
