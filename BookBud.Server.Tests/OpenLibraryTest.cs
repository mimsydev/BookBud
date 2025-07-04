using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using BookBud.Server.Models;
using BookBud.Server.Services;
using BookBud.Server.Services.OpenLib;
using Moq.Protected;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace BookBud.Server.Tests
{
    public class OpenLibraryTest
    {
        private readonly OpenLibService _openLibraryService;
        private readonly HttpClient _httpClient;
        private static readonly string[] _jsonGetBooksContent = [" "];

        public OpenLibraryTest()
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "GetBooksAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken> ())
                .ReturnsAsync(new HttpResponseMessage() 
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = JsonContent.Create(_jsonGetBooksContent)
                });

            _openLibraryService = new OpenLibService()
            _httpClient = httpClient;
        }

        [Fact]
        public async Task GetBooksAsync_ReturnsBooks()
        {
            
        }
    }
}
