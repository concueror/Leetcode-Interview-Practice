using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._175_Combine_Two_Tables;

public abstract class TestcasesBase<TContext> where TContext : DbContext
{
    private SqliteConnection? _connection;
    private DbContextOptions<TContext>? _options;
    
    [SetUp]
    public void Setup()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();

        _options = new DbContextOptionsBuilder<TContext>()
            .UseSqlite(_connection)
            .Options;

        using var context = GetContext();
        context.Database.EnsureCreated();
    }
    
    [TearDown]
    public void TearDown()
    {
        _connection?.Close();
        _connection?.Dispose();
    }

    protected TContext GetContext()
    {
        if (_options == null)
            throw new InvalidOperationException("Setup must be called before GetContext");
            
        return (TContext)Activator.CreateInstance(typeof(TContext), _options)!;
    }
}