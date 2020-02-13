using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using RawCritic2.Data;
using RawCritic2.Models;
using RawCritic2.Pages.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RawCritic.UnitTests
{
    public class IndexPageTests
    {

        public IMemoryCache _memoryCache;
        [Fact]
        public async Task OnGetAsync_PopulatesThePageModel_WithAListOfMessages()
        {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("InMemoryDb");
            #region arrange
            var mockAppDbContext = new Mock<ApplicationDbContext>(optionsBuilder.Options);
            var expectedMessages = ApplicationDbContext.GetSeedingMessages();
            mockAppDbContext.Setup(
                db => db.GetGamesAsync()).Returns(Task.FromResult(expectedMessages));
            var pageModel = new IndexModel(mockAppDbContext.Object,_memoryCache);
            #endregion

            #region act
            // Act
            await pageModel.OnGetAsync();
            #endregion

            #region assert
            // Assert
            var actualMessages = Assert.IsAssignableFrom<List<Game>>(pageModel.Data);
            Assert.Equal(
                expectedMessages.OrderBy(m => m.Id).Select(m => m.Title),
                actualMessages.OrderBy(m => m.Id).Select(m => m.Title));
            #endregion
        }
    }
}
