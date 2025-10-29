using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._2452_Words_Within_Two_Edits_Of_Dictionary;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.TwoEditWords(
            ["word", "note", "ants", "wood"], 
            ["wood", "joke", "moat"]
        );

        result.Should().Equal(["word", "note", "wood"]);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.TwoEditWords(
            ["yes"], 
            ["not"]
        );

        result.Should().BeEmpty();
    }
}
