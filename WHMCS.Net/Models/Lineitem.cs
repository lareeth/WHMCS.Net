using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Lineitem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public int RelId { get; set; }

        [JsonProperty("producttype")]
        public string ProductType { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("billingcycle")]
        public string BillingCycle { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
