using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Items
    {
        [JsonProperty("item")]
        public List<Item> Item { get; set; }
    }
}
