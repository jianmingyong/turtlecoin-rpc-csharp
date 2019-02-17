using Newtonsoft.Json;

namespace TurtlecoinRpc.Request.Json.Daemon
{
    public class PoolChangesLiteRpcRequest
    {
        [JsonProperty("tailBlockId")]
        public string TailBlockId { get; set; }

        [JsonProperty("knownTxsIds")]
        public string[] KnownTransactionsIds { get; set; }
    }
}