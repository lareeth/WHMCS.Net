using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class GBP
    {
        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("msetupfee")]
        public string MSetupFee { get; set; }

        [JsonProperty("qsetupfee")]
        public string QSetupFee { get; set; }

        [JsonProperty("ssetupfee")]
        public string SSetupFee { get; set; }

        [JsonProperty("asetupfee")]
        public string ASetupFee { get; set; }

        [JsonProperty("bsetupfee")]
        public string BSetupFee { get; set; }

        [JsonProperty("tsetupfee")]
        public string TSetupFee { get; set; }

        [JsonProperty("monthly")]
        public string Monthly { get; set; }

        [JsonProperty("quarterly")]
        public string Quarterly { get; set; }

        [JsonProperty("semiannually")]
        public string Semiannually { get; set; }

        [JsonProperty("annually")]
        public string Annually { get; set; }

        [JsonProperty("biennially")]
        public string Biennially { get; set; }

        [JsonProperty("triennially")]
        public string Triennially { get; set; }
    }
}
