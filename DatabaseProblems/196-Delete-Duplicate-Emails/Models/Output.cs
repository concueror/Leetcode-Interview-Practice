using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._196_Delete_Duplicate_Emails.Models;

public class Output
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("email")]
    public string Email { get; set; }
}
