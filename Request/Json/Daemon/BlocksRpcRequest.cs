using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Json.Daemon
{
    public class BlocksRpcRequest
    {
        [JsonProperty("height")]
        public ulong Height { get; set; }
    }
}