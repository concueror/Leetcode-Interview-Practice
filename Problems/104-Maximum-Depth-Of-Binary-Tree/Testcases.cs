using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._104_Maximum_Depth_Of_Binary_Tree;

public class Testcases
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        var root = new TreeNode(3,
            new TreeNode(9),
            new TreeNode(20,
                new TreeNode(15),
                new TreeNode(7)
            )
        );
        var result = solution.MaxDepth(root);

        result.Should().Be(3);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var root = new TreeNode(1,
            null,
            new TreeNode(2)
        );
        var result = solution.MaxDepth(root);

        result.Should().Be(2);
    }
}
