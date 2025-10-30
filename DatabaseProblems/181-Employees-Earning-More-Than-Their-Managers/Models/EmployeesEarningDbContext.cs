using Microsoft.EntityFrameworkCore;

namespace Leetcode.Problems.Database._181_Employees_Earning_More_Than_Their_Managers.Models;

public class EmployeesEarningDbContext : DbContext
{
    public DbSet<Employee> Employee { get; set; }

    public EmployeesEarningDbContext(DbContextOptions<EmployeesEarningDbContext> options)
        : base(options)
    {
    }
}
