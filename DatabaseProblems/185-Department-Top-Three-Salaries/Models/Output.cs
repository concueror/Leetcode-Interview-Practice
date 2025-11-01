using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._185_Department_Top_Three_Salaries.Models;

public class Output
{
    [Column("Department")]
    public string Department { get; set; }
    
    [Column("Employee")]
    public string Employee { get; set; }
    
    [Column("Salary")]
    public int Salary { get; set; }
}
