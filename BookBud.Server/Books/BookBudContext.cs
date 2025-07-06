using Microsoft.EntityFrameworkCore;

namespace BookBud.Server.Books
{
    public class BookBudContext(DbContextOptions<BookBudContext> options) : DbContext(options)
    {
        public virtual DbSet<BookDetail> Books { get; set; }
        public async Task<List<BookDetail>> GetBooksAsync()
        {
            return await Books.ToListAsync();
        }

        public async Task<BookDetail> GetBookAsync(Guid bookId)
        {
            return await Books.SingleAsync(b => b.Id == bookId);
        }

        public async Task<BookDetail> CreateBookAsync(BookDetail bookDetail)
        {
            await Books.AddAsync(bookDetail);
            await SaveChangesAsync();
            return bookDetail;
        }

        public async Task<BookDetail> UpdateBookAsync(Guid bookId, BookDetail bookDetail)
        {
            await Books
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
            await Books.Where(b => b.Id.Equals(bookId)).ExecuteDeleteAsync();
            return true;
        }
    }
}
