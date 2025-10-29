namespace Leetcode.Problems.Database._175_Combine_Two_Tables.Models;

/// <summary>
/// +-------------+---------+
/// | Column Name | Type    |
/// +-------------+---------+
/// | addressId   | int     |
/// | personId    | int     |
/// | city        | varchar |
/// | state       | varchar |
/// +-------------+---------+
/// </summary>
public class Address
{
    public int AddressId { get; set; }
    public int PersonId { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}