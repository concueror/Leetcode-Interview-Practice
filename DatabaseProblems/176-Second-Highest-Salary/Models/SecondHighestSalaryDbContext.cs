using Microsoft.EntityFrameworkCore;

namespace Leetcode.Problems.Database._176_Second_Highest_Salary.Models;

public class SecondHighestSalaryDbContext : DbContext
{
    public DbSet<Employee> Employee { get; set; }

    public SecondHighestSalaryDbContext(DbContextOptions<SecondHighestSalaryDbContext> options)
        : base(options)
    {
    }
}
