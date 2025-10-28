namespace Leetcode.Problems.DotNet._9_Palindrome_Number;

/// <summary>
/// Problem description: https://leetcode.com/problems/palindrome-number/description/
/// Given an integer x, return true if x is a palindrome, and false otherwise.
/// </summary>
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        if (x < 10) return true;

        var m = 1;
        var z = x;

        while ((z = z / 10) > 0) m++;

        var res = true;
        for (var i = 0; i < m - 1; i++)
        {
            if (i > m - i - 1) break;
            if (GetDigit(x, i) != GetDigit(x, m - i - 1))
            {
                res = false;
                break;
            }
        }

        return res;
    }

    public int GetDigit(int value, int index)
    {
        return value / (int)Math.Pow(10, index) % 10;
    }
}
