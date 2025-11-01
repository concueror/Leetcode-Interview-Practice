using System.ComponentModel.DataAnnotations.Schema;

namespace Leetcode.Problems.Database._183_Customers_Who_Never_Order.Models;

public class Output
{
    [Column("Customers")]
    public string Customers { get; set; }
}
