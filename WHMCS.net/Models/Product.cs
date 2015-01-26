using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMCS.net.Models
{
    public class ProductsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public int TotalResults { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }
    }

    public class Products
    {
        [JsonProperty("product")]
        public List<Product> Product { get; set; }
    }

    public class Product
    {
        [JsonProperty("pid")]
        public string PID { get; set; }

        [JsonProperty("gid")]
        public string GID { get; set; }

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