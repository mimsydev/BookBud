using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Moq.Internals;
using Moq.Protected;

namespace BookBud.Server.Tests
{
    public static class MoqExtensions
    {
        public static ISetup<HttpMessageHandler, Task<HttpResponseMessage>> SetupSendAsync<Task<HttpResponseMessage>>(
            this Mock<HttpMessageHandler> handler, HttpMethod requestMethod, string requestUrl)
        {
            return handler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(r =>
                    r.Method == requestMethod &&
                    r.RequestUri != null &&
                    r.RequestUri.ToString() == requestUrl
                    ),
                    ItExpr.IsAny<CancellationToken>()
                );
        }
    }
}
