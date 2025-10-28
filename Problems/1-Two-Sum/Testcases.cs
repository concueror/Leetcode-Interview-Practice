using NUnit.Framework;
using FluentAssertions;
namespace Leetcode.Problems.DotNet._1_Two_Sum;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.TwoSum([2, 7, 11, 15], 9);

        result.Should().Equal([0, 1]);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.TwoSum([3, 2, 4], 6);
        
        result.Should().Equal([1, 2]);
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.TwoSum([3, 3], 6);
        
        result.Should().Equal([0, 1]);
    }
}