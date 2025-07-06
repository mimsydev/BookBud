using Microsoft.EntityFrameworkCore;

namespace BookBud.Server.Books
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly BookBudContext _bookBudContext;
        public SqlBookRepository(BookBudContext bookBudContext)
        {
            _bookBudContext = bookBudContext;
        }

        public async Task<List<BookDetail>?> GetBooksAsync()
        {
            return await _bookBudContext.GetBooksAsync();
        }

        public async Task<BookDetail?> GetBookAsync(Guid bookId)
        {
            return await _bookBudContext.GetBookAsync(bookId);
        }

        public async Task<BookDetail?> CreateBookAsync(BookDetail bookDetail)
        {
            await _bookBudContext.CreateBookAsync(bookDetail);
            var newBookDetail = await GetBookAsync(bookDetail.Id);
            return newBookDetail;
        }

        public async Task<BookDetail?> UpdateBookAsync(Guid bookId, BookDetail bookDetail)
        {
            await _bookBudContext.UpdateBookAsync(bookId, bookDetail);
            var updatedBook = await GetBookAsync(bookId);
            return updatedBook;
        }

        public async Task<bool> DeleteBookAsync(Guid bookId)
        {
            await _bookBudContext.DeleteBookAsync(bookId);
            return true;
        }
    }
}
