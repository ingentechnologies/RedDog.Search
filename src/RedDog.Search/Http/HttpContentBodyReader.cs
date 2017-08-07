using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;

namespace Ingen.RedDog.Search.Http
{
    /// <summary>
    ///     Wrapper that allows passing around the ReadAsAsync method.
    /// </summary>
    internal class HttpContentBodyReader : IBodyReader
    {
        private readonly HttpContent _content;

        private readonly JsonMediaTypeFormatter _formatter;

        public HttpContentBodyReader(HttpContent content, JsonMediaTypeFormatter formatter)
        {
            _content = content;
            _formatter = formatter;
        }

        public Task<T> ReadAsync<T>(CancellationToken cancellationToken)
        {
            return _content.ReadAsAsync<T>(new[] { _formatter }, cancellationToken);
        }
    }
}