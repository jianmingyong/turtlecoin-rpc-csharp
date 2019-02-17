namespace TurtlecoinRpc.Request.Http.Daemon
{
    internal class HttpPostRpcRequest<TResponse, TRequest> : Http.HttpPostRpcRequest<TResponse, TRequest>
    {
        public HttpPostRpcRequest(RemoteDaemonRpcClient remoteDaemonRpcClient, string endpoint, TRequest request) : base(endpoint, request, remoteDaemonRpcClient.HttpClient, remoteDaemonRpcClient.HttpRpcRequestOptions)
        {
        }
    }
}