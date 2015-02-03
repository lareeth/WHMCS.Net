using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Transation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amountin")]
        public string Amountin { get; set; }

        [JsonProperty("fees")]
        public string Fees { get; set; }

        [JsonProperty("amountout")]
        public string Amountout { get; set; }

        [JsonProperty("rate")]
        public string Rate { get; set; }

        [JsonProperty("transid")]
        public string TransId { get; set; }

        [JsonProperty("invoiceid")]
        public string InvoiceId { get; set; }

        [JsonProperty("refundid")]
        public string RefundId { get; set; }
    }
}
