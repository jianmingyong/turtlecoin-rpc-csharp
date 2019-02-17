using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Json.Daemon
{
    public class BlockRpcRequest
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}