using Moq;
using System.Net;
using System.Net.Http.Json;
using BookBud.Server.BookProvider;
using BookBud.Server.BookProvider.OpenLib;
using Microsoft.Extensions.Logging;
using System.Linq;
using Moq.Contrib;
using Moq.Contrib.HttpClient;

namespace BookBud.Server.Tests
{
    public class OpenLibraryTest
    {
        private const string BaseUrl = "https://openlibrary.org";
        private readonly HttpClient _httpClient;
        private const string LotrWorkId = "OL27448W";
        private const string LotrBookId = "OL42871495M";
        private const string SearchQuery = "title: Lord of the rings";
        private readonly Mock<ILogger<OpenLibService>> _logger;
        private readonly OpenLibService _openLibraryService;
        public OpenLibraryTest()
        {

            var handlerMock = new Mock<HttpMessageHandler>();
            _httpClient = handlerMock.CreateClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);

            handlerMock.SetupRequest(HttpMethod.Get, $"{BaseUrl}/search.json?q={SearchQuery}")
                .ReturnsResponse(HttpStatusCode.OK, OpenLibTestContent.SearchTestContent);
            handlerMock.SetupRequest(HttpMethod.Get, $"{BaseUrl}/works/{LotrWorkId}/editions.json")
                .ReturnsResponse(OpenLibTestContent.EditionsTestResult);
            handlerMock.SetupRequest(HttpMethod.Get, $"{BaseUrl}/books/{LotrBookId}.json")
                .ReturnsResponse(OpenLibTestContent.BookTestResult);

            _logger = new Mock<ILogger<OpenLibService>>();
            _openLibraryService = new OpenLibService(_logger.Object, _httpClient);
        }

        [Fact]
        public async Task SearchBooksAsync_ReturnsIEnumerableBook()
        {
            var books = await _openLibraryService.SearchBooksAsync(SearchQuery);
            var bookList = Enumerable.ToList(books);

            Assert.NotNull(books);
            Assert.True(bookList.Count > 10);
            Assert.Equal( "The Lord of the Rings", bookList[0].Title);
        }
        [Fact]
        public async Task GetEditionsAsync_ReturnsIEnumberableEdition()
        {
            var editions = await _openLibraryService.GetEditionsAsync(LotrWorkId);
            var editionList = Enumerable.ToList(editions);

            Assert.NotNull(editions);
            Assert.True(editionList.Count > 10);
            Assert.Equal( "O Senhor dos Anéis", editionList[0].Title);
        }
        [Fact]
        public async Task GetBookAsync_ReturnsBookDetail()
        {
            var book = await _openLibraryService.GetBookAsync(LotrBookId);

            Assert.NotNull(book);
            Assert.Equal("0261103938", book.Isbn10?[0]);
        }
    }
}
