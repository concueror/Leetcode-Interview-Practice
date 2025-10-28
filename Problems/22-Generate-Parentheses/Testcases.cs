using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._22_Generate_Parentheses;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.GenerateParenthesis(3);

        result.Should().BeEquivalentTo(["((()))", "(()())", "(())()", "()(())", "()()()"]);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.GenerateParenthesis(1);

        result.Should().BeEquivalentTo(["()"]);
    }
}
