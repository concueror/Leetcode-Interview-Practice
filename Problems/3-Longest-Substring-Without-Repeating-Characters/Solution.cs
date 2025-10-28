namespace Leetcode.Problems.DotNet._3_Longest_Substring_Without_Repeating_Characters;

/// <summary>
/// Problem description: 
/// Given a string s, find the length of the longest substring without duplicate characters.
/// </summary>
public class Solution
{
    public int LengthOfLongestSubstring(string s) 
    {
        int maxOutput = 0;
        int result = 0;
        var arr = Enumerable.Repeat(-1, 256).ToArray();;
        int output = 0;
            
        int subStart = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (arr[s[i]] == -1 || arr[s[i]] < subStart)
            {
                output++;
                arr[s[i]] = i ;
                continue;
            }

            if (maxOutput < output)
            {
                maxOutput = output;
            }
            
            subStart = arr[s[i]] + 1;
            output = i - subStart + 1;
            
            arr[s[i]] = i;
        }
        
        if (maxOutput < output)
        {
            maxOutput = output;
        }
        
        return maxOutput;
    }
}