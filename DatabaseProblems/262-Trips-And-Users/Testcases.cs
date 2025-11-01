using FluentAssertions;
using Leetcode.Problems.Database._262_Trips_And_Users.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Leetcode.Problems.Database._262_Trips_And_Users;

public class Testcases : TestcasesBase<TripsAndUsersDbContext>
{
    [Test]
    public void Case1()
    {
        // Arrange
        using var context = GetContext();
        
        // Add Users
        context.Users.Add(new User { UsersId = 1, Banned = "No", Role = "client" });
        context.Users.Add(new User { UsersId = 2, Banned = "Yes", Role = "client" });
        context.Users.Add(new User { UsersId = 3, Banned = "No", Role = "client" });
        context.Users.Add(new User { UsersId = 4, Banned = "No", Role = "client" });
        context.Users.Add(new User { UsersId = 10, Banned = "No", Role = "driver" });
        context.Users.Add(new User { UsersId = 11, Banned = "No", Role = "driver" });
        context.Users.Add(new User { UsersId = 12, Banned = "No", Role = "driver" });
        context.Users.Add(new User { UsersId = 13, Banned = "No", Role = "driver" });
        
        // Add Trips
        context.Trips.Add(new Trip { Id = 1, ClientId = 1, DriverId = 10, CityId = 1, Status = "completed", RequestAt = "2013-10-01" });
        context.Trips.Add(new Trip { Id = 2, ClientId = 2, DriverId = 11, CityId = 1, Status = "cancelled_by_driver", RequestAt = "2013-10-01" });
        context.Trips.Add(new Trip { Id = 3, ClientId = 3, DriverId = 12, CityId = 6, Status = "completed", RequestAt = "2013-10-01" });
        context.Trips.Add(new Trip { Id = 4, ClientId = 4, DriverId = 13, CityId = 6, Status = "cancelled_by_client", RequestAt = "2013-10-01" });
        context.Trips.Add(new Trip { Id = 5, ClientId = 1, DriverId = 10, CityId = 1, Status = "completed", RequestAt = "2013-10-02" });
        context.Trips.Add(new Trip { Id = 6, ClientId = 2, DriverId = 11, CityId = 6, Status = "completed", RequestAt = "2013-10-02" });
        context.Trips.Add(new Trip { Id = 7, ClientId = 3, DriverId = 12, CityId = 6, Status = "completed", RequestAt = "2013-10-02" });
        context.Trips.Add(new Trip { Id = 8, ClientId = 2, DriverId = 12, CityId = 12, Status = "completed", RequestAt = "2013-10-03" });
        context.Trips.Add(new Trip { Id = 9, ClientId = 3, DriverId = 10, CityId = 12, Status = "completed", RequestAt = "2013-10-03" });
        context.Trips.Add(new Trip { Id = 10, ClientId = 4, DriverId = 13, CityId = 12, Status = "cancelled_by_driver", RequestAt = "2013-10-03" });
        
        context.SaveChanges();

        // Act from Solution.sql
        var sqlFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "..", "..", "..", "262-Trips-And-Users", "Solution.sql");
        var sqlScript = File.ReadAllText(sqlFilePath);
        var results = context.Database.SqlQueryRaw<Output>(sqlScript).ToList();

        // Assert with Output model
        var expected = new[]
        {
            new Output { Day = "2013-10-01", CancellationRate = 0.33m },
            new Output { Day = "2013-10-02", CancellationRate = 0.00m },
            new Output { Day = "2013-10-03", CancellationRate = 0.50m }
        };

        results.Should().BeEquivalentTo(expected, options => options.WithoutStrictOrdering());
    }
}
