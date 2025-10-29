using NUnit.Framework;
using FluentAssertions;

namespace Leetcode.Problems.DotNet._637_Average_Of_Levels_In_Binary_Tree;

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
        var result = solution.AverageOfLevels(root);

        result.Should().Equal([3.00000, 14.50000, 11.00000]);
    }

    [Test]
    public void Case2()
    {
        var solution = new Solution();
        var root = new TreeNode(3,
            new TreeNode(9,
                new TreeNode(15),
                new TreeNode(7)
            ),
            new TreeNode(20)
        );
        var result = solution.AverageOfLevels(root);

        result.Should().Equal([3.00000, 14.50000, 11.00000]);
    }
}
