using Microsoft.EntityFrameworkCore;
using BookBud.Server.Services;
using BookBud.Server.Models;
using Moq;
using Moq.EntityFrameworkCore;

namespace BookBud.Server.Tests
{
    // ============================================================================
    //                                  UNIT TESTS 
    // ============================================================================

    public class BookServiceUnitTests
    {
        private readonly Mock<BookBudContext> _mockContext;
        private readonly BookService _bookService;
        private readonly List<BookDetail> _testBooks;

        public BookServiceUnitTests()
        {
            _mockContext = new Mock<BookBudContext>(new DbContextOptions<BookBudContext>());
            _bookService = new BookService(_mockContext.Object);
            
            // Test data
            _testBooks = new List<BookDetail>
            {
                new BookDetail
                {
                    Id = new Guid("5C60F693-BEF5-E011-A485-80EE7300C692"),
                    Title = "Atlas Shrugged",
                    Author = "Ayn Rand",
                    CreateDate = DateTime.Now,
                    ISBN10 = "1234567890",
                    ImageUrl = "https://www.google.com"
                },
                new BookDetail
                {
                    Id = new Guid("6C60F693-BEF5-E011-A485-80EE7300C693"),
                    Title = "The Fountainhead",
                    Author = "Ayn Rand",
                    CreateDate = DateTime.Now,
                    ISBN10 = "0987654321",
                    ImageUrl = "https://www.example.com"
                }
            };
        }

        [Fact]
        public async Task GetBooksAsync_ReturnsAllBooks()
        {
            // Arrange
            _mockContext.Setup(x => x.Books).ReturnsDbSet(_testBooks);

            // Act
            var result = await _bookService.GetBooksAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, b => b.Title == "Atlas Shrugged");
            Assert.Contains(result, b => b.Title == "The Fountainhead");
        }

        [Fact]
        public async Task GetBookAsync_WithValidId_ReturnsCorrectBook()
        {
            // Arrange
            var bookId = new Guid("5C60F693-BEF5-E011-A485-80EE7300C692");
            _mockContext.Setup(x => x.Books).ReturnsDbSet(_testBooks);

            // Act
            var result = await _bookService.GetBookAsync(bookId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Atlas Shrugged", result.Title);
            Assert.Equal("Ayn Rand", result.Author);
        }

        [Fact]
        public async Task GetBookAsync_WithInvalidId_ThrowsException()
        {
            // Arrange
            var invalidId = Guid.NewGuid();
            _mockContext.Setup(x => x.Books).ReturnsDbSet(_testBooks);

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(
                () => _bookService.GetBookAsync(invalidId));
        }

        [Fact]
        public async Task CreateBookAsync_AddsBookToContext()
        {
            // Arrange
            var newBook = new BookDetail
            {
                Id = Guid.NewGuid(),
                Title = "New Book",
                Author = "New Author",
                CreateDate = DateTime.Now,
                ISBN10 = "1111111111",
                ImageUrl = "https://newbook.com"
            };

            _mockContext.Setup(x => x.Books).ReturnsDbSet(new List<BookDetail>());
            _mockContext.Setup(x => x.SaveChangesAsync(default)).ReturnsAsync(1);

            // Act
            var result = await _bookService.CreateBookAsync(newBook);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(newBook.Title, result.Title);
            _mockContext.Verify(x => x.Books.AddAsync(newBook, default), Times.Once);
            _mockContext.Verify(x => x.SaveChangesAsync(default), Times.Once);
        }
    }

    // ============================================================================
    //                              DATABASE TESTING
    // ============================================================================

    public class BookServiceDatabaseTests : IClassFixture<ImprovedTestDatabaseFixture>
    {
        private readonly BookService _bookService;
        private readonly BookBudContext _context;

        public BookServiceDatabaseTests(ImprovedTestDatabaseFixture fixture)
        {
            _context = fixture.CreateContext();
            _bookService = new BookService(_context);
            fixture.ResetDatabase(_context); // Clean state for each test
        }

        [Fact]
        public async Task GetBooksAsync_WithRealDatabase_ReturnsBooks()
        {
            // This test uses your original database setup
            // Act
            var result = await _bookService.GetBooksAsync();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }

    public class ImprovedTestDatabaseFixture : IDisposable
    {
        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=BookBudTest;Trusted_Connection=True;ConnectRetryCount=0;Encrypt=False";
        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public ImprovedTestDatabaseFixture()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using var context = CreateContext();
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                    _databaseInitialized = true;
                }
            }
        }

        public BookBudContext CreateContext() => new(
            new DbContextOptionsBuilder<BookBudContext>()
                .UseSqlServer(ConnectionString)
                .Options);

        public void ResetDatabase(BookBudContext context)
        {
            // Clean all data
            context.Books.RemoveRange(context.Books);
            
            // Add fresh test data
            context.Books.Add(new BookDetail
            {
                Id = new Guid("5C60F693-BEF5-E011-A485-80EE7300C692"),
                Title = "Atlas Shrugged",
                Author = "Ayn Rand",
                CreateDate = Convert.ToDateTime("07/01/2025 11:59"),
                ISBN10 = "1234567890",
                ImageUrl = "https://www.google.com"
            });
            
            context.SaveChanges();
        }

        public void Dispose()
        {
            using var context = CreateContext();
            context.Database.EnsureDeleted();
        }
    }
}
