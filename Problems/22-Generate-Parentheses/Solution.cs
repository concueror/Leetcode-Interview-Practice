namespace Leetcode.Problems.DotNet._22_Generate_Parentheses;

/// <summary>
/// Problem description: https://leetcode.com/problems/generate-parentheses/description/
/// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
/// </summary>
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        if (n == 1) return ["()"];
        var results = new List<string>();

        var left = n;
        var right = n;
        Rec(results, new Stack<char>(), n, ref left, ref right);

        return results;
    }

    public static void Rec(List<string> results, Stack<char> s, int n, ref int left, ref int right)
    {
        do
        {
            if (right > 0 && left < right)
            {
                s.Push(')');
                right--;
            }

            while (left > 0)
            {
                s.Push('(');
                left--;
            }

            if (left == 0 && right == 0)
            {
                var array = s.ToArray();
                Array.Reverse(array);
                results.Add(new string(array));
                Reduce(results, s, ref left, ref right);
            }
            else if (left > right)
            {
                Reduce(results, s, ref left, ref right);
            }
        } while (s.Count > 0);
    }

    public static void Reduce(List<string> results, Stack<char> s, ref int left, ref int right)
    {
        var pop = 'x';

        while (left >= right && s.Count > 0)
        {
            while (s.Count > 0 && (pop = s.Pop()) == ')') right++;

            if (pop == '(')
            {
                left++;
            }
        }
    }
}