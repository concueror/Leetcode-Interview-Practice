namespace Leetcode.Problems.DotNet._36_Valid_Sudoku;

/// <summary>
/// Problem description: https://leetcode.com/problems/valid-sudoku/description/
/// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following
/// rules:
/// 1. Each row must contain the digits 1-9 without repetition.
/// 2. Each column must contain the digits 1-9 without repetition.
/// 3. Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
/// </summary>
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        //rows

        for (var i = 0; i < 9; i++)
        {
            int[] sourceRow = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] sourceColumn = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] sourceQuad = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            var i1 = i / 3 * 3;
            var j1 = i % 3 * 3;

            for (var j = 0; j < 9; j++)
            {
                var i1i = i1;
                var j1j = j1;

                var n = board[i][j] - '0';
                if (board[i][j] != '.')
                {
                    sourceRow[n - 1]++;
                }

                n = board[j][i] - '0';
                if (board[j][i] != '.')
                {
                    sourceColumn[n - 1]++;
                }

                i1i += j / 3;
                j1j += j % 3;

                n = board[i1i][j1j] - '0';
                if (board[i1i][j1j] != '.')
                {
                    sourceQuad[n - 1]++;
                }
            }

            if (!CheckSource(sourceRow)) return false;
            if (!CheckSource(sourceColumn)) return false;
            if (!CheckSource(sourceQuad)) return false;
        }

        return true;
    }

    public bool CheckSource(int[] source)
    {
        for (var i = 0; i < 9; i++)
            if (source[i] > 1)
                return false;

        return true;
    }
}