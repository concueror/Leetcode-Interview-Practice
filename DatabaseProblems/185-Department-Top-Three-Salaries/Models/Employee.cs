using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._185_Department_Top_Three_Salaries.Models;

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
    
    [Column("departmentId")]
    public int DepartmentId { get; set; }
}
