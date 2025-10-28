using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._108_Convert_Sorted_Array_To_Binary_Search_Tree;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var result = solution.SortedArrayToBST([-10, -3, 0, 5, 9]);

        result.val.Should().Be(0);
        result.left.val.Should().Be(-10);
        result.left.right.val.Should().Be(-3);
        result.right.val.Should().Be(5);
        result.right.right.val.Should().Be(9);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var result = solution.SortedArrayToBST([1, 3]);

        result.val.Should().Be(1);
        result.right.val.Should().Be(3);
    }
}
