using Newtonsoft.Json;
using TurtlecoinRpc.Response.Json.Daemon.Transaction;

namespace TurtlecoinRpc.Response.Json.Daemon
{
    public class PoolChangesLiteRpcResponse : StatusRpcResponse
    {
        [JsonProperty("isTailBlockActual")]
        public bool IsTailBlockActual { get; set; }

        [JsonProperty("addedTxs")]
        public TransactionPrefixInfoRpcResponse[] AddedTransactions { get; set; }

        [JsonProperty("deletedTxsIds")]
        public string[] DeletedTransactionsIds { get; set; }
    }
}