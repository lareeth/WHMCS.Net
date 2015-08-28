using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ordernum")]
        public string OrderNum { get; set; }

        [JsonProperty("userid")]
        public int UserId { get; set; }

        [JsonProperty("contactid")]
        public string ContactId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("nameservers")]
        public string NameServers { get; set; }

        [JsonProperty("transfersecret")]
        public string TransferSecret { get; set; }

        [JsonProperty("renewals")]
        public string Renewals { get; set; }

        [JsonProperty("promocode")]
        public string PromoCode { get; set; }

        [JsonProperty("promotype")]
        public string PromoType { get; set; }

        [JsonProperty("promovalue")]
        public string PromoValue { get; set; }

        [JsonProperty("orderdata")]
        public string OrderData { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("paymentmethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("invoiceid")]
        public string InvoiceId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ipaddress")]
        public string IPAddress { get; set; }

        [JsonProperty("fraudmodule")]
        public string FraudModule { get; set; }

        [JsonProperty("fraudoutput")]
        public string FraudOutput { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("paymentmethodname")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("paymentstatus")]
        public string PaymentStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("currencyprefix")]
        public string CurrencyPrefix { get; set; }

        [JsonProperty("currencysuffix")]
        public string CurrencySuffix { get; set; }

        [JsonProperty("frauddata")]
        public string FraudData { get; set; }

        [JsonProperty("lineitems")]
        public Lineitems LineItems { get; set; }
    }
}
