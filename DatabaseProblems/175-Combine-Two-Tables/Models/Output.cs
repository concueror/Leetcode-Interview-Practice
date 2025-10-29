namespace Leetcode.Problems.Database._175_Combine_Two_Tables.Models;

/// <summary>
/// +-----------+----------+---------------+----------+
/// | firstName | lastName | city          | state    |
/// +-----------+----------+---------------+----------+
/// | Allen     | Wang     | Null          | Null     |
/// | Bob       | Alice    | New York City | New York |
/// +-----------+----------+---------------+----------+
/// </summary>
public class Output
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}