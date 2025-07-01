using Microsoft.EntityFrameworkCore;
using BookBud.Server.Services;
using BookBud.Server.Models;

namespace BookBud.Server.Tests
{
    public class TestDatabaseFixture : DbContext
    {
        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=BookBudTest;Trusted_Connection=True;ConnectRetryCount=0;Encrypt=False";
        private static readonly Lock _lock = new();
        private static bool _databaseInitialized;

        public TestDatabaseFixture()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext()) {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                        context.AddRange(
                            new BookDetail
                            {
                                Id = new Guid("5C60F693-BEF5-E011-A485-80EE7300C692"),
                                Title = "Atlas Shrugged",
                                Author = "Ayn Rand",
                                CreateDate = Convert.ToDateTime("07/01/2025 11:59"),
                                ISBN10 = "1234567890",
                                ImageUrl = "https://www.google.com"
                            }); 
                    }
                    _databaseInitialized = true;
                }
            }
        }
        public static BookBudContext CreateContext() => new (
            new DbContextOptionsBuilder<BookBudContext>()
            .UseSqlServer(ConnectionString)
            .Options);
    }
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

        }
    }
}
