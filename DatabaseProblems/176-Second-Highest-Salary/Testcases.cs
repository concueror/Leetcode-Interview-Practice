using FluentAssertions;
using Leetcode.Problems.Database._176_Second_Highest_Salary.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._176_Second_Highest_Salary;

public class Testcases : TestcasesBase<SecondHighestSalaryDbContext>
{
    [Test]
    public void Case1()
    {
        // Arrange
        using var context = GetContext();
        context.Employee.Add(new Employee { Id = 1, Salary = 100 });
        context.Employee.Add(new Employee { Id = 2, Salary = 200 });
        context.Employee.Add(new Employee { Id = 3, Salary = 300 });
        context.SaveChanges();

        // Act from Solution.sql
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "176-Second-Highest-Salary", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        var results = context.Database.SqlQueryRaw<Output>(sqlScript).ToList();

        // Assert with Output model
        var expected = new[]
        {
            new Output { SecondHighestSalary = 200 }
        };

        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }

    [Test]
    public void Case2()
    {
        // Arrange
        using var context = GetContext();
        context.Employee.Add(new Employee { Id = 1, Salary = 100 });
        context.SaveChanges();

        // Act from Solution.sql
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "176-Second-Highest-Salary", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        var results = context.Database.SqlQueryRaw<Output>(sqlScript).ToList();

        // Assert with Output model
        var expected = new[]
        {
            new Output { SecondHighestSalary = null }
        };

        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }
}
