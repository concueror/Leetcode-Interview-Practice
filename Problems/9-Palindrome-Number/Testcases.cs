using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._9_Palindrome_Number;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.IsPalindrome(121);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.IsPalindrome(-121);

        result.Should().BeFalse();
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.IsPalindrome(10);

        result.Should().BeFalse();
    }
}
