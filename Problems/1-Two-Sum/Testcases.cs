using System.Diagnostics;

namespace Leetcode.Problems.DotNet._1_Two_Sum;

public class Testcases
{
    void Case1()
    {
        var solution = new Solution();
        var result = solution.TwoSum([2, 7, 11, 15], 9);

        Debug.Assert(result.SequenceEqual([0, 1]));
    }

    void Case2()
    {
        var solution = new Solution();
        var result = solution.TwoSum([3, 2, 4], 6);
        
        Debug.Assert(result.SequenceEqual([1, 2]));
    }

    void Case3()
    {
        var solution = new Solution();
        var result = solution.TwoSum([3, 3], 6);
        
        Debug.Assert(result.SequenceEqual([0, 1]));
    }

    public void Run()
    {
        Case1();
        Case2();
        Case3();
    }
}