namespace Leetcode.Problems.DotNet._125_Valid_Palindrome;

/// <summary>
/// Problem description: https://leetcode.com/problems/valid-palindrome/description/
/// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.
/// Given a string s, return true if it is a palindrome, or false otherwise.
/// </summary>
public class Solution
{
    public bool IsPalindrome(string s) {
        bool res = true;
        int i = -1;
        int j = s.Length;

        while (res && i < j) {
            
            do {
                i = i + 1;
            } while(i < s.Length && i > -1 && Char.IsLetterOrDigit(s[i]) == false);
        
            do {
                j = j - 1;
            } while(j < s.Length && j > -1 && Char.IsLetterOrDigit(s[j]) == false);
        
            if (i < s.Length && j > -1) {
                res = char.ToLower(s[i]) == char.ToLower(s[j]);
            }            
        }   
        return res;
    }

    public int move(string s, int index, int direction) {
        do {
            index = index + direction;
        } while(index < s.Length && index > -1 && Char.IsLetterOrDigit(s[index]) == false);
        return index;
    }
}
