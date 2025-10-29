using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._509_Fibonacci_Number;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.Fib(2);

        result.Should().Be(1);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.Fib(3);

        result.Should().Be(2);
    }

    [Test]
    public void Case3()
    {
        var solution = new Solution();
        var result = solution.Fib(4);

        result.Should().Be(3);
    }
}
