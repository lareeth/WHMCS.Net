using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public string RelId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("taxed")]
        public string Taxed { get; set; }
    }
}
