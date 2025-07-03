using BookBud.Server.Models;
using System.ComponentModel;
using System.Text.Json;

namespace BookBud.Server.Services
{
    public interface IBookProviderService
    {
        public Task<List<OpenLibBook>> SearchBooks(string query);
    }

    public class OpenLibService : IBookProviderService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<OpenLibService> _logger;
        public OpenLibService(ILogger<OpenLibService> logger, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://openlibrary.org/search.json");
            _logger = logger;
        }

        public async Task<List<OpenLibBook>> SearchBooks(string query)
        {
            var responseString = await _httpClient.GetStringAsync(query);
            List<OpenLibBook> books = [];
            return books;

        }

    }
}
