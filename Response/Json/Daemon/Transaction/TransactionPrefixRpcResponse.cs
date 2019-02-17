using Newtonsoft.Json;

namespace TurtlecoinRpc.Response.Json.Daemon.Transaction
{
    public class TransactionPrefixRpcResponse
    {
        [JsonProperty("version")]
        public ulong Version { get; set; }

        [JsonProperty("unlock_time")]
        public ulong UnlockTime { get; set; }

        [JsonProperty("vin")]
        public InputTransactionRpcResponse<KeyInputRpcResponse>[] Inputs { get; set; }

        [JsonProperty("vout")]
        public OutputTransactionRpcResponse[] Outputs { get; set; }

        [JsonProperty("extra")]
        public string Extra { get; set; }
    }
}