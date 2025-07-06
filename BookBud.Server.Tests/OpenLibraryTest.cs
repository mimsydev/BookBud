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
        private readonly HttpClient _httpClient;
        private readonly Mock<ILogger<OpenLibService>> _logger;
        private static readonly string _baseUri = "https://openlibrary.org/";

        public OpenLibraryTest()
        {

        }

        [Fact]
        public async Task GetBooksAsync_ReturnsBooks()
        {

            var handlerMock = new Mock<HttpMessageHandler>();

            handlerMock.SetupSendAsync(HttpMethod.Get, $"{_baseUri}/search.json").ReturnsAsync(new HttpResponseMessage() 
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = JsonContent.Create(OpenLibTestContent.SearchTestContent)
                });

            var httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri(_baseUri)
            };

            var logger = new Mock<ILogger<OpenLibService>>();
            var openLibraryService = new OpenLibService(logger.Object, httpClient);

            var books = openLibraryService.SearchBooksAsync("title: Lord of the rings");

            
        }
    }
}
