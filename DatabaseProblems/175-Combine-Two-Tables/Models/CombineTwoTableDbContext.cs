using Microsoft.EntityFrameworkCore;

namespace Leetcode.Problems.Database._175_Combine_Two_Tables.Models;

public class CombineTwoTableDbContext : DbContext 
{
    public DbSet<Person> Person { get; set; }
    public DbSet<Address> Address { get; set; }
    
    public CombineTwoTableDbContext(DbContextOptions<CombineTwoTableDbContext> options) : base(options)
    {
    }
}