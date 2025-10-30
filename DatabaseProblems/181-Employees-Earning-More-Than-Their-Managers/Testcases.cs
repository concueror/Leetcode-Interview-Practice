using FluentAssertions;
using Leetcode.Problems.Database._181_Employees_Earning_More_Than_Their_Managers.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._181_Employees_Earning_More_Than_Their_Managers;

public class Testcases : TestcasesBase<EmployeesEarningDbContext>
{
    [Test]
    public void Case1()
    {
        // Arrange
        using var context = GetContext();
        context.Employee.Add(new Employee { Id = 1, Name = "Joe", Salary = 70000, ManagerId = 3 });
        context.Employee.Add(new Employee { Id = 2, Name = "Henry", Salary = 80000, ManagerId = 4 });
        context.Employee.Add(new Employee { Id = 3, Name = "Sam", Salary = 60000, ManagerId = null });
        context.Employee.Add(new Employee { Id = 4, Name = "Max", Salary = 90000, ManagerId = null });
        context.SaveChanges();

        // Act from Solution.sql
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "181-Employees-Earning-More-Than-Their-Managers", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        var results = context.Database.SqlQueryRaw<Output>(sqlScript).ToList();

        // Assert with Output model
        var expected = new[]
        {
            new Output { Employee = "Joe" }
        };

        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }
}
