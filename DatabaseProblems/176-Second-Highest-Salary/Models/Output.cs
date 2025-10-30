using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._176_Second_Highest_Salary.Models;

public class Output
{
    [Column("SecondHighestSalary")]
    public int? SecondHighestSalary { get; set; }
}
