using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using RawCritic2.Data;
using RawCritic2.Models;
using Xunit;

namespace RawCritic.UnitTests
{
    public class DatabaseAccessTest
    {
        [Fact]
        public async Task GetMessagesAsync_MessagesAreReturned()
        {
            using (var db = new ApplicationDbContext(Utility.TestDbContextOptions()))
            {
                // Arrange
                var expectedMessages = ApplicationDbContext.GetSeedingMessages();
                await db.AddRangeAsync(expectedMessages);
                await db.SaveChangesAsync();

                // Act
                var result = await db.GetGamesAsync();

                // Assert
                var actualMessages = Assert.IsAssignableFrom<List<Game>>(result);
                Assert.Equal(
                    expectedMessages.OrderBy(m => m.Id).Select(m => m.Title),
                    actualMessages.OrderBy(m => m.Id).Select(m => m.Title));
            }
        }


        // Create a new service provider to create a new in-memory database.
      
    }
}
