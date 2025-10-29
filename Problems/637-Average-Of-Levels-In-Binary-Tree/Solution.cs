namespace Leetcode.Problems.DotNet._637_Average_Of_Levels_In_Binary_Tree;

/// <summary>
/// Problem description: https://leetcode.com/problems/average-of-levels-in-binary-tree/description/
/// Given the root of a binary tree, return the average value of the nodes on each level in the form of an array.
/// Answers within 10-5 of the actual answer will be accepted.
/// </summary>
public class Solution
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var levels = new Dictionary<TreeNode, int>();
        var nodes = new Queue<TreeNode>();

        nodes.Enqueue(root);
        levels.Add(root, 0);

        var averages = Go(nodes, levels);

        return averages;
    }

    public double[] Go(Queue<TreeNode> nodes, Dictionary<TreeNode, int> levels)
    {
        var maxLevels = 1;
        while (nodes.Count > 0)
        {
            var node = nodes.Dequeue();

            if (node.left != null)
            {
                nodes.Enqueue(node.left);
                levels.Add(node.left, levels[node] + 1);
                maxLevels = maxLevels < levels[node] + 1 + 1 ? levels[node] + 1 + 1 : maxLevels;
            }

            if (node.right != null)
            {
                nodes.Enqueue(node.right);
                levels.Add(node.right, levels[node] + 1);
                maxLevels = maxLevels < levels[node] + 1 + 1 ? levels[node] + 1 + 1 : maxLevels;
            }
        }

        var sums = new double [maxLevels];
        var counts = new int [maxLevels];
        var averages = new double [maxLevels];

        foreach (var pair in levels)
        {
            var level = pair.Value;

            sums[level] += pair.Key.val;
            counts[level] += 1;

            averages[level] = sums[level] / counts[level];
        }

        return averages;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}