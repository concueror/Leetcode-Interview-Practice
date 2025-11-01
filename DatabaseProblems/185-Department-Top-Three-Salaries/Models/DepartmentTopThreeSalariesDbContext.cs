using Microsoft.EntityFrameworkCore;

namespace Leetcode.Problems.Database._185_Department_Top_Three_Salaries.Models;

public class DepartmentTopThreeSalariesDbContext : DbContext
{
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }

    public DepartmentTopThreeSalariesDbContext(DbContextOptions<DepartmentTopThreeSalariesDbContext> options)
        : base(options)
    {
    }
}
