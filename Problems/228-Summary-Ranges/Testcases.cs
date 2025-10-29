using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._228_Summary_Ranges;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.SummaryRanges([0, 1, 2, 4, 5, 7]);

        result.Should().Equal(["0->2", "4->5", "7"]);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.SummaryRanges([0, 2, 3, 4, 6, 8, 9]);

        result.Should().Equal(["0", "2->4", "6", "8->9"]);
    }
}
