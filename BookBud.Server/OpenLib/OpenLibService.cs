using BookBud.Server.Models;
namespace BookBud.Server.Services.OpenLib
{
    public class OpenLibService : IBookProviderService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<OpenLibService> _logger;
        public OpenLibService(ILogger<OpenLibService> logger, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://openlibrary.org/");
            _logger = logger;
        }

        public async Task<List<BookDetail>> GetBooks(string query)
        {
            var responseString = await _httpClient.GetStringAsync(string.Format("/search.json?q={)}",query));
            List<BookDetail> books = [];
            return books;

        }

        public async Task<BookDetail> GetBook(string query)
        {
            return new BookDetail() { Title = "", Author = "", ISBN10 = "" };

        }

    }
}
