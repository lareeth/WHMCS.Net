using Newtonsoft.Json;
using System.Collections.Generic;

namespace WHMCS.Net.Models
{
    public class Lineitems
    {
        [JsonProperty("lineitem")]
        public List<Lineitem> LineItem { get; set; }
    }
}
