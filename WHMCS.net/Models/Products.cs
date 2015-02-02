using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.net.Models
{
    public class Products
    {
        [JsonProperty("product")]
        public List<Product> Product { get; set; }
    }
}