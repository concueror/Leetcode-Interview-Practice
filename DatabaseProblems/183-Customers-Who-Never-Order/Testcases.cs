using FluentAssertions;
using Leetcode.Problems.Database._183_Customers_Who_Never_Order.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._183_Customers_Who_Never_Order;

public class Testcases : TestcasesBase<CustomersWhoNeverOrderDbContext>
{
    [Test]
    public void Case1()
    {
        // Arrange
        using var context = GetContext();
        context.Customers.Add(new Customer { Id = 1, Name = "Joe" });
        context.Customers.Add(new Customer { Id = 2, Name = "Henry" });
        context.Customers.Add(new Customer { Id = 3, Name = "Sam" });
        context.Customers.Add(new Customer { Id = 4, Name = "Max" });
        context.Orders.Add(new Order { Id = 1, CustomerId = 3 });
        context.Orders.Add(new Order { Id = 2, CustomerId = 1 });
        context.SaveChanges();

        // Act from Solution.sql
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "183-Customers-Who-Never-Order", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        var results = context.Database.SqlQueryRaw<Output>(sqlScript).ToList();

        // Assert with Output model
        var expected = new[]
        {
            new Output { Customers = "Henry" },
            new Output { Customers = "Max" }
        };

        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }
}
