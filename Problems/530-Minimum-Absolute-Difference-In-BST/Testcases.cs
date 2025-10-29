using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._530_Minimum_Absolute_Difference_In_BST;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var root = new TreeNode(4,
            new TreeNode(2,
                new TreeNode(1),
                new TreeNode(3)
            ),
            new TreeNode(6)
        );
        var result = solution.GetMinimumDifference(root);

        result.Should().Be(1);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var root = new TreeNode(1,
            new TreeNode(0),
            new TreeNode(48,
                new TreeNode(12),
                new TreeNode(49)
            )
        );
        var result = solution.GetMinimumDifference(root);

        result.Should().Be(1);
    }
}
