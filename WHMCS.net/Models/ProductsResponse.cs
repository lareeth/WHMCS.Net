using Newtonsoft.Json;
using WHMCS.net.Interfaces;

namespace WHMCS.net.Models
{
    public class ProductsResponse : IResponse<Products>
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public int TotalResults { get; set; }

        [JsonProperty("products")]
        public Products Content { get; set; }
    }
}