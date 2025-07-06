using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http.Json;
using BookBud.Server.BookProvider;
using BookBud.Server.BookProvider.OpenLib;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace BookBud.Server.Tests
{
    public class OpenLibraryTest()
    {
        private static readonly string _baseUri = "https://openlibrary.org/";

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

            var books = await openLibraryService.SearchBooksAsync("title: Lord of the rings");
            var bookList = Enumerable.ToList<Book>(books);

            Assert.NotNull(books);
            Assert.True(bookList.Count > 10);
            Assert.Equal( "The Lord of the Rings", bookList[0].Title);
        }
    }
}
