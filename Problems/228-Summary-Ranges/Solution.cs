namespace Leetcode.Problems.DotNet._228_Summary_Ranges;

/// <summary>
/// Problem description: https://leetcode.com/problems/summary-ranges/description/
/// You are given a sorted unique integer array nums.
/// A range [a,b] is the set of all integers from a to b (inclusive).
/// Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
/// That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one
/// of the ranges but not in nums.
/// Each range [a,b] in the list should be output as:
/// "a->b" if a != b
/// "a" if a == b
/// </summary>
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0) return new string[] { };
        if (nums.Length == 1) return new[] { nums[0].ToString() };

        var res = new List<string>(nums.Length);

        var from = 0;
        var to = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i + 1 < nums.Length && nums[i + 1] - nums[i] == 1)
            {
                to = i + 1;
                continue;
            }

            if (from == to)
            {
                res.Add(nums[to].ToString());
                from = i + 1;
                to = i + 1;
                continue;
            }

            res.Add($"{nums[from]}->{nums[to]}");
            from = i + 1;
            to = i + 1;
        }

        return res;
    }
}