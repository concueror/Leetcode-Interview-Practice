using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._262_Trips_And_Users.Models;

[Table("Users")]
public class User
{
    [Key]
    [Column("users_id")]
    public int UsersId { get; set; }
    
    [Column("banned")]
    public string Banned { get; set; }
    
    [Column("role")]
    public string Role { get; set; }
}
