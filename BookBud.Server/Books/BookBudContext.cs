using Microsoft.EntityFrameworkCore;

namespace BookBud.Server.Books
{
    public class BookBudContext(DbContextOptions<BookBudContext> options) : DbContext(options)
    {
        public virtual DbSet<BookDetail> Books { get; set; }
    }
}
