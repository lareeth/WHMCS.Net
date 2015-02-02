using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web;

namespace WHMCS.net.Models
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
    }
}