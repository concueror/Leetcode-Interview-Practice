namespace Leetcode.Problems.DotNet._70_Climbing_Stairs;

/// <summary>
/// Problem description: https://leetcode.com/problems/climbing-stairs/description/
/// You are climbing a staircase. It takes n steps to reach the top.
/// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
/// </summary>
public class Solution
{
    public int ClimbStairs(int n) {        
        int [] table = new int [n + 2]; 
        table[0] = 0;          
        table[1] = 1;        
        return Step(n+1, table);
    }

    public int Step(int n, int [] table) {
        if (n == 0) return 0;
        if (n == 1) return 1;

        if (table[n] > 0) {
            return table[n];
        }

        table[n] = Step(n-1, table) + Step(n-2, table);
        return table[n];
    }
}
