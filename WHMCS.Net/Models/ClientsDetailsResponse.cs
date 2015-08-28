using Newtonsoft.Json;

namespace WHMCS.Net.Models
{

    public class ClientsDetailsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("companyname")]
        public string CompanyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("fullstate")]
        public string FullState { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("countrycode")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("countryname")]
        public string CountryName { get; set; }

        [JsonProperty("phonecc")]
        public int PhoneCC { get; set; }

        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phonenumberformatted")]
        public string PhoneNumberFormatted { get; set; }

        [JsonProperty("billingcid")]
        public string BillingCid { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("twofaenabled")]
        public bool TwoFaEnabled { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("defaultgateway")]
        public string DefaultGateway { get; set; }

        [JsonProperty("cctype")]
        public string CCType { get; set; }

        [JsonProperty("cclastfour")]
        public string CCLastFour { get; set; }

        [JsonProperty("securityqid")]
        public string SecurityQId { get; set; }

        [JsonProperty("securityqans")]
        public string SecurityQAns { get; set; }

        [JsonProperty("groupid")]
        public string GroupId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("taxexempt")]
        public string TaxExempt { get; set; }

        [JsonProperty("latefeeoveride")]
        public string LateFeeOveride { get; set; }

        [JsonProperty("overideduenotices")]
        public string OverideDueNotices { get; set; }

        [JsonProperty("separateinvoices")]
        public string SeparateInvoices { get; set; }

        [JsonProperty("disableautocc")]
        public string DisableAutoCC { get; set; }

        [JsonProperty("emailoptout")]
        public string EmailOptOut { get; set; }

        [JsonProperty("overrideautoclose")]
        public string OverrideAutoclose { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lastlogin")]
        public string LastLogin { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }

}
