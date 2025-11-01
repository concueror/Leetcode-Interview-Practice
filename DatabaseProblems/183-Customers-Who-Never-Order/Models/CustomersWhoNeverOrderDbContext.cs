using Microsoft.EntityFrameworkCore;

namespace Leetcode.Problems.Database._183_Customers_Who_Never_Order.Models;

public class CustomersWhoNeverOrderDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    public CustomersWhoNeverOrderDbContext(DbContextOptions<CustomersWhoNeverOrderDbContext> options)
        : base(options)
    {
    }
}
