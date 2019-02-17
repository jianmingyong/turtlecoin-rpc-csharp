using Newtonsoft.Json;

namespace TurtlecoinRpc.Response.Json.Daemon.Transaction
{
    public class TransactionPrefixInfoRpcResponse
    {
        [JsonProperty("transactionPrefixInfo.txHash")]
        public string TransactionHash { get; set; }

        [JsonProperty("transactionPrefixInfo.txPrefix")]
        public TransactionPrefixRpcResponse TransactionPrefix { get; set; }
    }
}