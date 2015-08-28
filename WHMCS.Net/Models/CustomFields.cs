using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS.Net.Models
{
    public class CustomFields
    {
        [JsonProperty("customfield")]
        public List<object> CustomField { get; set; }
    }
}
