using BookBud.Server.Books;
using System.Text.Json;

namespace BookBud.Server.BookProvider.OpenLib
{
    public class OpenLibService : IBookProviderService<Book, BookResponse>
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<OpenLibService> _logger;
        public OpenLibService(ILogger<OpenLibService> logger, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<Book>> SearchBooksAsync(string query)
        {
            var responseString = await _httpClient.GetStringAsync(string.Format("/search.json?q={)}",query));
            var searchResult = JsonSerializer.Deserialize<SearchResponse>(responseString);
            ArgumentNullException.ThrowIfNull(searchResult?.Books);
            return searchResult.Books;

        }

        public async Task<BookResponse> GetBookAsync(string query)
        {
            return new BookResponse();

        }

    }
}
