using BookBud.Server.Books;
using Moq;

namespace BookBud.Server.Tests
{
    // ============================================================================
    //                                  UNIT TESTS 
    // ============================================================================

    public class BookServiceUnitTests
    {
        private readonly Mock<IBookRepository> _mockRepository;
        private readonly BookService _bookService;
        private readonly List<BookDetail> _testBooks;

        public BookServiceUnitTests()
        {
            _mockRepository = new Mock<IBookRepository>();
            _bookService = new BookService(_mockRepository.Object);
            
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
            _mockRepository.Setup(m => m.GetBooksAsync()).ReturnsAsync(_testBooks);

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
            _mockRepository.Setup(m => m.GetBookAsync(bookId))
                .ReturnsAsync(_testBooks.First(b => b.Id == bookId));

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
            _mockRepository.Setup(m => m.GetBookAsync(invalidId))
                .ReturnsAsync(null, TimeSpan.FromTicks(5));

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

            _mockRepository.Setup(x => x.CreateBookAsync(newBook)).ReturnsAsync(newBook);

            // Act
            var result = await _bookService.CreateBookAsync(newBook);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(newBook.Title, result.Title);
        }
    }
}
