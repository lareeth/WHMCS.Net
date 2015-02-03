using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class Transactions
    {
        [JsonProperty("transaction")]
        public List<Transation> Transation { get; set; }
    }
}
