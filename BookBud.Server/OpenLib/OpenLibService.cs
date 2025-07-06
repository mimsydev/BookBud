using BookBud.Server.Books;
using BookBud.Server.OpenLib;
using System.Text.Json;

namespace BookBud.Server.BookProvider.OpenLib
{
    public class OpenLibService : IBookProviderService<Book, BookDetail>
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
            ArgumentNullException.ThrowIfNullOrWhiteSpace(query, nameof(query));
            var responseString = await _httpClient.GetStringAsync($"/search.json?q={query}") 
                ?? throw new InvalidOperationException($"There was a problemt retrieving books for query: {query}");
            var searchResult = JsonSerializer.Deserialize<SearchResponse>(responseString);
            return searchResult?.Books 
                ?? throw new InvalidCastException($"There was a problem deserializing the response: {responseString}");
        }

        public async Task<IEnumerable<Edition>> GetEditionsAsync(string workId)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(workId, nameof(workId));
            var responseString = await _httpClient.GetStringAsync($"/works/{workId}/editions.json") 
                ?? throw new InvalidOperationException($"There was a problem retrieving the editions for work: {workId}");
            var editionResponses = JsonSerializer.Deserialize<EditionsResponse>(responseString);
            return editionResponses?.Entries 
                ?? throw new InvalidCastException($"There was a problem deserializing the response: {responseString}");
        }

        public async Task<BookDetail> GetBookAsync(string bookId)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(bookId, nameof(bookId));
            var responseString = await _httpClient.GetStringAsync($"/books/{bookId}.json")
                ?? throw new InvalidOperationException($"There was a problem retrieving the detials for book: {bookId}");
            var bookResponse = JsonSerializer.Deserialize<BookDetail>(responseString);
            return bookResponse
                ?? throw new InvalidCastException($"There was a problem deserializing the response: {responseString}");
        }

    }
}
