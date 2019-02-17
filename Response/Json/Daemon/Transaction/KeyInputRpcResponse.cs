using Newtonsoft.Json;

namespace TurtlecoinRpc.Response.Json.Daemon.Transaction
{
    public class KeyInputRpcResponse
    {
        [JsonProperty("amount")]
        public ulong Amount { get; set; }

        [JsonProperty("key_offsets")]
        public ulong[] OutputIndexes { get; set; }

        [JsonProperty("k_image")]
        public string KeyImage { get; set; }
    }
}