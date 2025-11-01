using Microsoft.EntityFrameworkCore;

namespace Leetcode.Problems.Database._196_Delete_Duplicate_Emails.Models;

public class DeleteDuplicateEmailsDbContext : DbContext
{
    public DbSet<Person> Person { get; set; }

    public DeleteDuplicateEmailsDbContext(DbContextOptions<DeleteDuplicateEmailsDbContext> options)
        : base(options)
    {
    }
}
