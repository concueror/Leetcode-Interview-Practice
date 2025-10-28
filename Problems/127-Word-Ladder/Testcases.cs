using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._127_Word_Ladder;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
        var result = solution.LadderLength("hit", "cog", wordList);

        result.Should().Be(5);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var wordList = new List<string> { "hot", "dot", "dog", "lot", "log" };
        var result = solution.LadderLength("hit", "cog", wordList);

        result.Should().Be(0);
    }
}
