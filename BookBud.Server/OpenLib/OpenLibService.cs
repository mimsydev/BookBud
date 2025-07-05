namespace BookBud.Server.BookProvider.OpenLib
{
    public class OpenLibService : IBookProviderService<OpenLibBook>
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<OpenLibService> _logger;
        public OpenLibService(ILogger<OpenLibService> logger, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<List<OpenLibBook>> GetBooks(string query)
        {
            var responseString = await _httpClient.GetStringAsync(string.Format("/search.json?q={)}",query));
            List<OpenLibBook> books = [];
            return books;

        }

        public async Task<OpenLibBook> GetBook(string query)
        {
            return new OpenLibBook();

        }

    }
}
