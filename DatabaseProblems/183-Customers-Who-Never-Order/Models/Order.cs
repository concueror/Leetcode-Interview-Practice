using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._183_Customers_Who_Never_Order.Models;

[Table("Orders")]
public class Order
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("customerId")]
    public int CustomerId { get; set; }
}
