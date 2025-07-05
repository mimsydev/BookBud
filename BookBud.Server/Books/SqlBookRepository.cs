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

        public async Task<List<BookDetail>> GetBooksAsync()
        {
            return await _bookBudContext.Books.ToListAsync();
        }

        public async Task<BookDetail> GetBookAsync(Guid bookId)
        {
            return await _bookBudContext.Books.SingleAsync(b => b.Id == bookId);
        }

        public async Task<BookDetail> CreateBookAsync(BookDetail bookDetail)
        {
            await _bookBudContext.Books.AddAsync(bookDetail);
            await _bookBudContext.SaveChangesAsync();
            return bookDetail;
        }

        public async Task<BookDetail> UpdateBookAsync(Guid bookId, BookDetail bookDetail)
        {
            await _bookBudContext.Books
                .Where(b => b.Id.Equals(bookId))
                .ExecuteUpdateAsync(setters => setters
                .SetProperty(b => b.Title, bookDetail.Title)
                .SetProperty(b => b.ISBN10, bookDetail.ISBN10)
                .SetProperty(b => b.Author, bookDetail.Author)
                .SetProperty(b => b.ImageUrl, bookDetail.ImageUrl)
                .SetProperty(b => b.UpdateDate, bookDetail.UpdateDate)
                );

            return bookDetail;
        }

        public async Task<bool> DeleteBookAsync(Guid bookId)
        {
            await _bookBudContext.Books.Where(b => b.Id.Equals(bookId)).ExecuteDeleteAsync();
            return true;
        }
    }
}
