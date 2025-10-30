using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._181_Employees_Earning_More_Than_Their_Managers.Models;

public class Output
{
    [Column("Employee")]
    public string Employee { get; set; }
}
