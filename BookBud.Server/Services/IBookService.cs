using BookBud.Server.Models;

namespace BookBud.Server.Services
{
    /// <summary>
    /// Provides contract for book-related business operations in the BookBud application.
    /// </summary>
    /// <remarks>
    /// This interface defines the core book management functionality including
    /// retrieval and creation of book records. Implementations should handle
    /// business logic, validation, and coordinate with data access layers.
    /// </remarks>
    public interface IBookService
    {
        /// <summary>
        /// Retrieves all books from the system.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains
        /// a <see cref="List{BookDetail}"/> of all books in the system. Returns an empty list if no books exist.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when there is an issue accessing the data store or processing the request.
        /// </exception>
        /// <example>
        /// <code>
        /// var allBooks = await bookService.GetBooksAsync();
        /// Console.WriteLine($"Found {allBooks.Count} books in the system");
        /// foreach (var book in allBooks)
        /// {
        ///     Console.WriteLine($"- {book.Title} by {book.Author}");
        /// }
        /// </code>
        /// </example>
        public Task<List<BookDetail>> GetBooksAsync();

        /// <summary>
        /// Retrieves a book by its unique identifier.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book to retrieve.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains
        /// the <see cref="BookDetail"/> if found; otherwise, null.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="bookId"/> is <see cref="Guid.Empty"/>.
        /// </exception>
        /// <example>
        /// <code>
        /// var bookId = Guid.Parse("12345678-1234-1234-1234-123456789abc");
        /// var book = await bookService.GetBookAsync(bookId);
        /// if (book != null)
        /// {
        ///     Console.WriteLine($"Found book: {book.Title}");
        /// }
        /// </code>
        /// </example>
        public Task<BookDetail> GetBookAsync(Guid bookId);

        /// <summary>
        /// Creates a new book record in the system.
        /// </summary>
        /// <param name="bookDetail">The book information to create. Must contain valid book data.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains
        /// the created <see cref="BookDetail"/> with any system-generated values (like ID, timestamps).
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="bookDetail"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="bookDetail"/> contains invalid data (e.g., empty title).
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when a book with the same identifier already exists or other business rules are violated.
        /// </exception>
        /// <example>
        /// <code>
        /// var newBook = new BookDetail
        /// {
        ///     Title = "The Great Gatsby",
        ///     Author = "F. Scott Fitzgerald",
        ///     ISBN = "978-0-7432-7356-5"
        /// };
        /// 
        /// var createdBook = await bookService.CreateBookAsync(newBook);
        /// Console.WriteLine($"Created book with ID: {createdBook.Id}");
        /// </code>
        /// </example>
        public Task<BookDetail> CreateBookAsync(BookDetail bookDetail);

        /// <summary>
        /// Updates an existing book record in the system.
        /// </summary>
        /// <param name="bookDetail">The book information to update. Must contain a valid ID and updated book data.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains
        /// the updated <see cref="BookDetail"/> with any system-modified values (like timestamps).
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="bookDetail"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="bookDetail"/> contains invalid data (e.g., empty ID or title).
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the book with the specified ID does not exist or cannot be updated.
        /// </exception>
        /// <example>
        /// <code>
        /// var existingBook = await bookService.GetBookAsync(bookId);
        /// existingBook.Title = "Updated Title";
        /// existingBook.PublicationYear = 2024;
        /// 
        /// var updatedBook = await bookService.UpdateBookAsync(existingBook);
        /// Console.WriteLine($"Updated book: {updatedBook.Title}");
        /// </code>
        /// </example>
        public Task<BookDetail> UpdateBookAsync(Guid bookId, BookDetail bookDetail);

        /// <summary>
        /// Deletes a book from the system by its unique identifier.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book to delete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains
        /// the deleted <see cref="BookDetail"/> if the operation was successful; otherwise, null if the book was not found.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="bookId"/> is <see cref="Guid.Empty"/>.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the book cannot be deleted due to business rules (e.g., book is referenced by other entities)
        /// or there is an issue accessing the data store.
        /// </exception>
        /// <example>
        /// <code>
        /// var bookId = Guid.Parse("12345678-1234-1234-1234-123456789abc");
        /// var deletedBook = await bookService.DeleteBookAsync(bookId);
        /// if (deletedBook != null)
        /// {
        ///     Console.WriteLine($"Successfully deleted book: {deletedBook.Title}");
        /// }
        /// else
        /// {
        ///     Console.WriteLine("Book not found or could not be deleted");
        /// }
        /// </code>
        /// </example>
        public Task<BookDetail> DeleteBookAsync(Guid bookId);
    }
}
