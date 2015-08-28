using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS.Net.Models
{
    public class Stats
    {
        public string result { get; set; }
        public string income_today { get; set; }
        public string income_thismonth { get; set; }
        public string income_thisyear { get; set; }
        public string orders_pending { get; set; }
        public string orders_today_cancelled { get; set; }
        public string orders_today_pending { get; set; }
        public string orders_today_fraud { get; set; }
        public string orders_today_active { get; set; }
        public string orders_today_total { get; set; }
        public string orders_yesterday_cancelled { get; set; }
        public string orders_yesterday_pending { get; set; }
        public string orders_yesterday_fraud { get; set; }
        public string orders_yesterday_active { get; set; }
        public string orders_yesterday_total { get; set; }
        public string orders_thismonth_total { get; set; }
        public string orders_thisyear_total { get; set; }
        public string tickets_closed { get; set; }
        public string tickets_inprogress { get; set; }
        public string tickets_onhold { get; set; }
        public string tickets_customerreply { get; set; }
        public string tickets_answered { get; set; }
        public string tickets_open { get; set; }
        public string cancellations_pending { get; set; }
        public string todoitems_due { get; set; }
        public string networkissues_open { get; set; }
        public string billableitems_uninvoiced { get; set; }
        public string quotes_valid { get; set; }
        public string staff_online { get; set; }
    }
}
