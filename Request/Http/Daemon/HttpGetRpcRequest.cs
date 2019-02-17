namespace TurtlecoinRpc.Request.Http.Daemon
{
    internal class HttpGetRpcRequest<TResponse> : Http.HttpGetRpcRequest<TResponse>
    {
        public HttpGetRpcRequest(RemoteDaemonRpcClient remoteDaemonRpcClient, string endpoint) : base(endpoint, remoteDaemonRpcClient.HttpClient, remoteDaemonRpcClient.HttpRpcRequestOptions)
        {
        }
    }
}