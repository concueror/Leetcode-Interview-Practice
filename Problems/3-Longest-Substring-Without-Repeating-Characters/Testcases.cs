using FluentAssertions;
using NUnit.Framework;

namespace Leetcode.Problems.DotNet._3_Longest_Substring_Without_Repeating_Characters;

public class Testcases
{
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase("", 0)]
    [TestCase(" ", 1)]
    [TestCase("au", 2)]
    [TestCase("dvdf", 3)]
    [TestCase("abcdef", 6)]
    [TestCase("aab", 2)]
    [TestCase("tmmzuxt", 5)]
    public void Case(string s, int expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.LengthOfLongestSubstring(s);

        // Assert
        result.Should().Be(expected);
    }
}