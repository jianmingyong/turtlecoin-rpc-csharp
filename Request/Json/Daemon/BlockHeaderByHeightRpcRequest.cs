using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Json.Daemon
{
    public class BlockHeaderByHeightRpcRequest
    {
        [JsonProperty("height")]
        public ulong Height { get; set; }
    }
}