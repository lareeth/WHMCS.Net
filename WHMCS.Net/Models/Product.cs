using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Product
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("gid")]
        public string Gid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("module")]
        public string Module { get; set; }

        [JsonProperty("paytype")]
        public string PayType { get; set; }

        [JsonProperty("pricing")]
        public Pricing Pricing { get; set; }

        [JsonProperty("customfields")]
        public CustomFields CustomFields { get; set; }

        [JsonProperty("configoptions")]
        public ConfigOptions ConfigOptions { get; set; }

        [JsonProperty("stockcontrol")]
        public string StockControl { get; set; }

        [JsonProperty("stocklevel")]
        public string StockLevel { get; set; }
    }
}