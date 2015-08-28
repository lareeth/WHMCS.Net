using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS.Net.Models
{
    public class ConfigOptions
    {
        [JsonProperty("configoption")]
        public List<object> ConfigOption { get; set; }
    }
}
