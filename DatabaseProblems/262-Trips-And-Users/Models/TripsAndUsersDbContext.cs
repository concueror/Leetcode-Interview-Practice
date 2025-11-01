using Microsoft.EntityFrameworkCore;

namespace Leetcode.Problems.Database._262_Trips_And_Users.Models;

public class TripsAndUsersDbContext : DbContext
{
    public DbSet<Trip> Trips { get; set; }
    public DbSet<User> Users { get; set; }

    public TripsAndUsersDbContext(DbContextOptions<TripsAndUsersDbContext> options)
        : base(options)
    {
    }
}
