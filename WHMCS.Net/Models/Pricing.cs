using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Pricing
    {
        [JsonProperty("GBP")]
        public GBP GBP { get; set; }
    }
}
