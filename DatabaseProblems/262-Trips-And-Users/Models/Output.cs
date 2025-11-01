using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._262_Trips_And_Users.Models;

public class Output
{
    [Column("Day")]
    public string Day { get; set; }
    
    [Column("Cancellation Rate")]
    public decimal CancellationRate { get; set; }
}
