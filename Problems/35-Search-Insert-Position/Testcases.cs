using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._35_Search_Insert_Position;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.SearchInsert([1, 3, 5, 6], 5);

        result.Should().Be(2);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.SearchInsert([1, 3, 5, 6], 2);

        result.Should().Be(1);
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.SearchInsert([1, 3, 5, 6], 7);

        result.Should().Be(4);
    }
}
