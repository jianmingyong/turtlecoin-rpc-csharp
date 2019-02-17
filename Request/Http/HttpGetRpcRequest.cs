using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Http
{
    internal class HttpGetRpcRequest<TResponse> : HttpRpcRequest
    {
        protected HttpGetRpcRequest(string endpoint, HttpClient httpClient = null, HttpRpcRequestOptions httpRpcRequestOptions = null) : base(endpoint, httpClient, httpRpcRequestOptions)
        {
        }

        public async Task<TResponse> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            CancellationTokenSource cancellationTokenSource = null;

            if (cancellationToken == default)
            {
                cancellationTokenSource = new CancellationTokenSource(HttpRpcRequestOptions.RequestTimeoutDelay);
                cancellationToken = cancellationTokenSource.Token;
            }

            try
            {
                var response = await HttpClient.GetAsync(Endpoint, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                using (var streamReader = new StreamReader(await response.Content.ReadAsStreamAsync().ConfigureAwait(false)))
                {
                    using (var jsonReader = new JsonTextReader(streamReader))
                    {
                        var serializer = new JsonSerializer();
                        return serializer.Deserialize<TResponse>(jsonReader);
                    }
                }
            }
            finally
            {
                cancellationTokenSource?.Dispose();
            }
        }
    }
}