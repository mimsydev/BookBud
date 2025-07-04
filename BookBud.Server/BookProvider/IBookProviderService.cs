using BookBud.Server.Models;
using System.ComponentModel;
using System.Text.Json;

namespace BookBud.Server.Services
{
    public interface IBookProviderService
    {
        public Task<List<BookDetail>> GetBooks(string query);
        public Task<List<BookDetail>> GetBook(string query);
        public BookDetail ConvertBook<T>(T book) where T : IProvidedBook;
    }

}
