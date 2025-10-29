using FluentAssertions;
using Leetcode.Problems.Database._175_Combine_Two_Tables.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._175_Combine_Two_Tables;

public class Testcases : TestcasesBase<CombineTwoTableDbContext>
{
    [Test]
    public void Case1()
    {
        // Arrange
        using var context = GetContext();
        context.Person.Add(new Person {FirstName = "Allen", LastName = "Wang"});
        context.Person.Add(new Person {FirstName = "Bob", LastName = "Alice"});
        context.Address.Add(new Address { AddressId = 1, PersonId = 2, City = "New York City", State = "New York" });
        context.Address.Add(new Address { AddressId = 2, PersonId = 3, City = "Leetcode", State = "California" });
        context.SaveChanges();
        
        // Act from Solution.sql
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "175-Combine-Two-Tables", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        var results = context.Database.SqlQueryRaw<Output>(sqlScript).ToList();
        
        // Assert with Output model
        var expected = new[]
        {
            new Output { FirstName = "Allen", LastName = "Wang", City = null, State = null },
            new Output { FirstName = "Bob", LastName = "Alice", City = "New York City", State = "New York" }
        };
        
        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }
}