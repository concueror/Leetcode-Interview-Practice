using FluentAssertions;
using Leetcode.Problems.Database._185_Department_Top_Three_Salaries.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._185_Department_Top_Three_Salaries;

public class Testcases : TestcasesBase<DepartmentTopThreeSalariesDbContext>
{
    [Test]
    public void Case1()
    {
        // Arrange
        using var context = GetContext();
        context.Department.Add(new Department { Id = 1, Name = "IT" });
        context.Department.Add(new Department { Id = 2, Name = "Sales" });
        context.Employee.Add(new Employee { Id = 1, Name = "Joe", Salary = 85000, DepartmentId = 1 });
        context.Employee.Add(new Employee { Id = 2, Name = "Henry", Salary = 80000, DepartmentId = 2 });
        context.Employee.Add(new Employee { Id = 3, Name = "Sam", Salary = 60000, DepartmentId = 2 });
        context.Employee.Add(new Employee { Id = 4, Name = "Max", Salary = 90000, DepartmentId = 1 });
        context.Employee.Add(new Employee { Id = 5, Name = "Janet", Salary = 69000, DepartmentId = 1 });
        context.Employee.Add(new Employee { Id = 6, Name = "Randy", Salary = 85000, DepartmentId = 1 });
        context.Employee.Add(new Employee { Id = 7, Name = "Will", Salary = 70000, DepartmentId = 1 });
        context.SaveChanges();

        // Act from Solution.sql
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "185-Department-Top-Three-Salaries", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        var results = context.Database.SqlQueryRaw<Output>(sqlScript).ToList();

        // Assert with Output model
        var expected = new[]
        {
            new Output { Department = "IT", Employee = "Max", Salary = 90000 },
            new Output { Department = "IT", Employee = "Joe", Salary = 85000 },
            new Output { Department = "IT", Employee = "Randy", Salary = 85000 },
            new Output { Department = "IT", Employee = "Will", Salary = 70000 },
            new Output { Department = "Sales", Employee = "Henry", Salary = 80000 },
            new Output { Department = "Sales", Employee = "Sam", Salary = 60000 }
        };

        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }
}
