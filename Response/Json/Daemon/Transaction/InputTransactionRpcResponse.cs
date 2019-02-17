using Newtonsoft.Json;

namespace TurtlecoinRpc.Response.Json.Daemon.Transaction
{
    public class InputTransactionRpcResponse<TValue> where TValue : class
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public TValue Value { get; set; }
    }
}