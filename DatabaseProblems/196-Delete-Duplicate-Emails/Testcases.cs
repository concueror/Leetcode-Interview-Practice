using FluentAssertions;
using Leetcode.Problems.Database._196_Delete_Duplicate_Emails.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._196_Delete_Duplicate_Emails;

public class Testcases : TestcasesBase<DeleteDuplicateEmailsDbContext>
{
    [Test]
    public void Case1()
    {
        // Arrange
        using var context = GetContext();
        context.Person.Add(new Person { Id = 1, Email = "john@example.com" });
        context.Person.Add(new Person { Id = 2, Email = "bob@example.com" });
        context.Person.Add(new Person { Id = 3, Email = "john@example.com" });
        context.SaveChanges();

        // Act from Solution.sql (DELETE statement)
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "196-Delete-Duplicate-Emails", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        context.Database.ExecuteSqlRaw(sqlScript);

        // Read remaining data after deletion
        var results = context.Person.Select(p => new Output { Id = p.Id, Email = p.Email }).ToList();

        // Assert with Output model
        var expected = new[]
        {
            new Output { Id = 1, Email = "john@example.com" },
            new Output { Id = 2, Email = "bob@example.com" }
        };

        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }
}
