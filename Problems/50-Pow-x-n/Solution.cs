namespace Leetcode.Problems.DotNet._50_Pow_x_n;

/// <summary>
/// Problem description: https://leetcode.com/problems/powx-n/description/
/// Implement pow(x, n), which calculates x raised to the power n (i.e., x^n).
/// </summary>
public class Solution
{
    public double MyPow(double x, int n)
    {
        if (x == 0) return 0;
        if (n == 0) return 1;
        if (x == 1) return 1;
        if (x == -1) return n % 2 == 0 ? 1 : -1;
        if (n == int.MinValue) return 0;
        var b = n < 0 ? -1 : 1;
        var n1 = (long)n * b;
        var z = x < 0 ? -1 : 1;
        x = x * z;
        var res = x;
        for (long i = 0; i < n1 - 1; i++)
        {
            if (x > 1 && res * x < res)
            {
                res = double.MaxValue;
                break;
            }

            res = res * x;
        }

        return (b < 0 ? 1 / res : res) * (n1 % 2 == 0 ? 1 : z);
    }
}