using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._433_Minimum_Genetic_Mutation;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.MinMutation("AACCGGTT", "AACCGGTA", ["AACCGGTA"]);

        result.Should().Be(1);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.MinMutation("AACCGGTT", "AAACGGTA", ["AACCGGTA", "AACCGCTA", "AAACGGTA"]);

        result.Should().Be(2);
    }
}
