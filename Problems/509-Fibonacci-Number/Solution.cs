namespace Leetcode.Problems.DotNet._509_Fibonacci_Number;

/// <summary>
/// Problem description: https://leetcode.com/problems/fibonacci-number/description/
/// The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is
/// the sum of the two preceding ones, starting from 0 and 1.
/// Given n, calculate F(n).
/// </summary>
public class Solution
{
    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 1;

        var table = new int [n + 3];
        table[0] = 0;
        table[1] = 1;
        table[2] = 1;

        return Step(n, table);
    }

    public int Step(int n, int[] table)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 1;

        if (table[n] > 0)
        {
            return table[n];
        }

        table[n] = Step(n - 1, table) + Step(n - 2, table);
        return table[n];
    }
}