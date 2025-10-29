namespace Leetcode.Problems.DotNet._1137_N_th_Tribonacci_Number;

/// <summary>
/// Problem description: https://leetcode.com/problems/n-th-tribonacci-number/description/
/// The Tribonacci sequence Tn is defined as follows:
/// T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
/// Given n, return the value of Tn.
/// </summary>
public class Solution
{
    public int Tribonacci(int n)
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

        table[n] = Step(n - 1, table) + Step(n - 2, table) + Step(n - 3, table);
        return table[n];
    }
}