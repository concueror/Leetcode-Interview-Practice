using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._200_Number_Of_Islands;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var grid = new char[][]
        {
            ['1','1','1','1','0'],
            ['1','1','0','1','0'],
            ['1','1','0','0','0'],
            ['0','0','0','0','0']
        };
        var result = solution.NumIslands(grid);

        result.Should().Be(1);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var grid = new char[][]
        {
            ['1','1','0','0','0'],
            ['1','1','0','0','0'],
            ['0','0','1','0','0'],
            ['0','0','0','1','1']
        };
        var result = solution.NumIslands(grid);

        result.Should().Be(3);
    }
}
