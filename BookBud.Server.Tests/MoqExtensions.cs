using Moq;
using Moq.Language;
using Moq.Protected;

namespace BookBud.Server.Tests
{
    public static class MoqExtensions
    {
        public static IReturns<HttpMessageHandler, Task<HttpResponseMessage>> SetupSendAsync(
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
