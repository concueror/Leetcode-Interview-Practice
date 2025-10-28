namespace Leetcode.Problems.DotNet._20_Valid_Parentheses;

/// <summary>
/// Problem description: https://leetcode.com/problems/valid-parentheses/description/
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// An input string is valid if:
/// 1. Open brackets must be closed by the same type of brackets.
/// 2. Open brackets must be closed in the correct order.
/// 3. Every close bracket has a corresponding open bracket of the same type.
/// </summary>
public class Solution
{
    public bool IsValid(string s)
    {
        var valid = true;

        var stack = new Stack<char>();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]);
                continue;
            }

            var hasElement = stack.TryPop(out var cur);
            if (!hasElement) return false;

            if (s[i] == ')' && cur != '(') return false;
            if (s[i] == '}' && cur != '{') return false;
            if (s[i] == ']' && cur != '[') return false;
        }

        if (stack.Count > 0) return false;

        return valid;
    }
}
