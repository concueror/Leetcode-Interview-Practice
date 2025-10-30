using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._176_Second_Highest_Salary.Models;

[Table("Employee")]
public class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("salary")]
    public int Salary { get; set; }
}
