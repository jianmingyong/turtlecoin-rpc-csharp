using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Http
{
    internal class HttpPostRpcRequest<TResponse, TRequest> : HttpRpcRequest
    {
        private TRequest Request { get; }

        protected HttpPostRpcRequest(string endpoint, TRequest request, HttpClient httpClient = null, HttpRpcRequestOptions httpRpcRequestOptions = null) : base(endpoint, httpClient, httpRpcRequestOptions)
        {
            Request = request;
        }

        public async Task<TResponse> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            var request = new StringContent(JsonConvert.SerializeObject(Request), Encoding.UTF8, "application/json");

            CancellationTokenSource cancellationTokenSource = null;

            if (cancellationToken == default)
            {
                cancellationTokenSource = new CancellationTokenSource(HttpRpcRequestOptions.RequestTimeoutDelay);
                cancellationToken = cancellationTokenSource.Token;
            }

            try
            {
                var response = await HttpClient.PostAsync(Endpoint, request, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var test = await response.Content.ReadAsStringAsync();

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