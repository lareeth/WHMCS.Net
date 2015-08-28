using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS.Net.Models
{
    public class Orders
    {
        [JsonProperty("order")]
        public List<Order> Order { get; set; }
    }
}
