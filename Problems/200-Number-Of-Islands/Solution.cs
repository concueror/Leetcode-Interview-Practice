namespace Leetcode.Problems.DotNet._200_Number_Of_Islands;

/// <summary>
/// Problem description: https://leetcode.com/problems/number-of-islands/description/
/// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of
/// islands.
/// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
/// You may assume all four edges of the grid are all surrounded by water.
/// </summary>
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var count = 0;

        var m = grid.Length;
        var n = grid[0].Length;
 
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (grid[i][j] == '1')
            {
                Go(grid, i, j);
                count++;
            }


        return count;
    }

    public void Go(char[][] grid, int i, int j)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        if (grid[i][j] == '1') grid[i][j] = 'X';

        if (i - 1 > -1 && grid[i - 1][j] == '1')
        {
            Go(grid, i - 1, j);
        }

        if (i + 1 < m && grid[i + 1][j] == '1')
        {
            Go(grid, i + 1, j);
        }

        if (j - 1 > -1 && grid[i][j - 1] == '1')
        {
            Go(grid, i, j - 1);
        }

        if (j + 1 < n && grid[i][j + 1] == '1')
        {
            Go(grid, i, j + 1);
        }
    }
}