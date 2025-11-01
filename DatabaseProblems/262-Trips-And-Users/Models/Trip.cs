using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._262_Trips_And_Users.Models;

[Table("Trips")]
public class Trip
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("client_id")]
    public int ClientId { get; set; }
    
    [Column("driver_id")]
    public int DriverId { get; set; }
    
    [Column("city_id")]
    public int CityId { get; set; }
    
    [Column("status")]
    public string Status { get; set; }
    
    [Column("request_at")]
    public string RequestAt { get; set; }
}
