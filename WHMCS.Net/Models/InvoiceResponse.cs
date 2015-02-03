using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class InvoiceResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("invoiceid")]
        public string InvoiceId { get; set; }

        [JsonProperty("invoicenum")]
        public string InvoiceNum { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("duedate")]
        public string DueDate { get; set; }

        [JsonProperty("datepaid")]
        public string DatePaid { get; set; }

        [JsonProperty("subtotal")]
        public string SubTotal { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }

        [JsonProperty("tax2")]
        public string Tax2 { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("taxrate")]
        public string TaxRate { get; set; }

        [JsonProperty("taxrate2")]
        public string TaxRate2 { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("paymentmethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("ccgateway")]
        public string CcGateway { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }

        [JsonProperty("transactions")]
        public Transactions Transactions { get; set; }
    }
}
