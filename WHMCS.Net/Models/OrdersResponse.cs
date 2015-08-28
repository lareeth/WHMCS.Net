using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class OrdersResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public string TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumReturned { get; set; }

        [JsonProperty("orders")]
        public Orders Orders { get; set; }
    }
}
