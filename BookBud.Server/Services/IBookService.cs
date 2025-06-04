using BookBud.Server.Models;

namespace BookBud.Server.Services
{
    public interface IBookService
    {
        public BookDetail GetBook(Guid bookId);
    }
}
