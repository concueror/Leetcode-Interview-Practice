namespace Leetcode.Problems.DotNet._120_Triangle;

/// <summary>
/// Problem description: https://leetcode.com/problems/triangle/description/
/// Given a triangle array, return the minimum path sum from top to bottom.
/// For each step, you may move to an adjacent number of the row below.
/// More formally, if you are on index i on the current row, you may move to either index i or index i + 1 on the next row.
/// </summary>
public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle) {
        int tl = triangle.Count;
        if (tl == 1) return triangle[0][0];

        for (int i = 1; i < tl; i++) {
            for(int j = 0; j < triangle[i].Count; j++) {
                long ul = j-1 > -1 ? triangle[i-1][j-1] : int.MaxValue;
                long ur = j < triangle[i-1].Count ? triangle[i-1][j] : int.MaxValue;

                triangle[i][j] = (int)Math.Min(ul + triangle[i][j], ur + triangle[i][j]);
            }
        }

        int min = triangle[tl - 1][0];
        for (int i = 0; i < triangle[tl-1].Count; i++) {
            min = Math.Min(min, triangle[tl-1][i]);
        }

        return min;
    }  
}
