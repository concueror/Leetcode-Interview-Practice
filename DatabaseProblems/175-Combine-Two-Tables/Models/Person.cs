namespace Leetcode.Problems.Database._175_Combine_Two_Tables.Models;

/// <summary>
/// +-------------+---------+
/// | Column Name | Type    |
/// +-------------+---------+
/// | personId    | int     |
/// | lastName    | varchar |
/// | firstName   | varchar |
/// +-------------+---------+
/// </summary>
public class Person
{
    public int PersonId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
}

