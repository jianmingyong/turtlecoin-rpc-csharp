﻿using TurtlecoinRpc.Request.Json;
using TurtlecoinRpc.Response.Json;

namespace TurtlecoinRpc.Request.Http.Daemon
{
    internal class HttpJsonRpcRequest<TResponse> : HttpPostRpcRequest<JsonRpcResponse<TResponse>, JsonRpcRequest>
    {
        public HttpJsonRpcRequest(RemoteDaemonRpcClient remoteDaemonRpcClient, string method) : base(remoteDaemonRpcClient, "json_rpc", new JsonRpcRequest(method))
        {
        }
    }

    internal class HttpJsonRpcRequest<TResponse, TRequest> : HttpPostRpcRequest<JsonRpcResponse<TResponse>, JsonRpcRequest<TRequest>>
    {
        public HttpJsonRpcRequest(RemoteDaemonRpcClient remoteDaemonRpcClient, string method, TRequest request) : base(remoteDaemonRpcClient, "json_rpc", new JsonRpcRequest<TRequest>(method, request))
        {
        }
    }
}