using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._347_Top_K_Frequent_Elements;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.TopKFrequent([1, 1, 1, 2, 2, 3], 2);

        result.Should().BeEquivalentTo([1, 2]);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.TopKFrequent([1], 1);

        result.Should().BeEquivalentTo([1]);
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.TopKFrequent([1, 2, 1, 2, 1, 2, 3, 1, 3, 2], 2);

        result.Should().BeEquivalentTo([1, 2]);
    }
}
