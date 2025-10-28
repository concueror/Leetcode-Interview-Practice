using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._120_Triangle;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var triangle = new List<IList<int>>
        {
            new List<int> { 2 },
            new List<int> { 3, 4 },
            new List<int> { 6, 5, 7 },
            new List<int> { 4, 1, 8, 3 }
        };
        var result = solution.MinimumTotal(triangle);

        result.Should().Be(11);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var triangle = new List<IList<int>>
        {
            new List<int> { -10 }
        };
        var result = solution.MinimumTotal(triangle);

        result.Should().Be(-10);
    }
}
