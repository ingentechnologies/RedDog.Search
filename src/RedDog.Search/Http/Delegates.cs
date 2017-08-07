using System.Threading;
using System.Threading.Tasks;

namespace Ingen.RedDog.Search.Http
{
    public delegate Task<TResponse> ResultFormatter<TResponse>(IBodyReader reader, CancellationToken cancellationToken);
}