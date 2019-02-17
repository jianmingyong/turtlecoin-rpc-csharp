using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Json.Daemon
{
    public class BlockHeaderByHashRpcRequest
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}