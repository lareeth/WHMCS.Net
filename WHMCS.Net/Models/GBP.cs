using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS.Net.Models
{
    public class GBP
    {
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string MSetupFee { get; set; }
        public string WSetupFee { get; set; }
        public string SSetupFee { get; set; }
        public string ASetupFee { get; set; }
        public string BSetupFee { get; set; }
        public string TSetupFee { get; set; }
        public string Monthly { get; set; }
        public string Quarterly { get; set; }
        public string Semiannually { get; set; }
        public string Annually { get; set; }
        public string Biennially { get; set; }
        public string Triennially { get; set; }
    }
}
