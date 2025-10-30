using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._181_Employees_Earning_More_Than_Their_Managers.Models;

[Table("Employee")]
public class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("salary")]
    public int Salary { get; set; }
    
    [Column("managerId")]
    public int? ManagerId { get; set; }
}
