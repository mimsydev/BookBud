using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http.Json;
using BookBud.Server.BookProvider;
using BookBud.Server.BookProvider.OpenLib;
using Microsoft.Extensions.Logging;

namespace BookBud.Server.Tests
{
    public class OpenLibraryTest
    {
        private readonly OpenLibService _openLibraryService;
        private readonly HttpClient _httpClient;
        private readonly Mock<ILogger<OpenLibService>> _logger;
        private static readonly string[] _jsonGetBooksContent = [" "];
        private static readonly string _baseUri = "https://openlibrary.org/";

        public OpenLibraryTest()
        {
            var handlerMock = new Mock<HttpMessageHandler>();

            handlerMock.SetupSendAsync(HttpMethod.Get, $"{_baseUri}/search.json").ReturnsAsync(new HttpResponseMessage() 
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = JsonContent.Create(_jsonGetBooksContent)
                });

            _httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri(_baseUri)
            };

            _logger = new Mock<ILogger<OpenLibService>>();
            _openLibraryService = new OpenLibService(_logger.Object, _httpClient);

        }

        [Fact]
        public async Task GetBooksAsync_ReturnsBooks()
        {
            
        }
    }
}
