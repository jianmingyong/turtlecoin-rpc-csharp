using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Json.Daemon
{
    public class TransactionRpcRequest
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}