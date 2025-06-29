using Microsoft.EntityFrameworkCore;
using BookBud.Server.Models;

namespace BookBud.Server.Services
{
    public class BookBudContext(DbContextOptions<BookBudContext> options) : DbContext(options)
    {
        public DbSet<BookDetail> Books { get; set; }
    }
}
