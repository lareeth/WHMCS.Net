using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS.Net.Models
{
    public enum OrderStatus
    {
        Pending,
        Active,
        Fraud,
        Cancelled
    }

    public class OrdersResponse
    {
        public string result { get; set; }
        public string totalresults { get; set; }
        public int startnumber { get; set; }
        public int numreturned { get; set; }
        public Orders orders { get; set; }
    }

    public class Orders
    {
        public Order[] order { get; set; }
    }

    public class Order
    {
        public string id { get; set; }
        public string ordernum { get; set; }
        public int userid { get; set; }
        public string contactid { get; set; }
        public string date { get; set; }
        public string nameservers { get; set; }
        public string transfersecret { get; set; }
        public string renewals { get; set; }
        public string promocode { get; set; }
        public string promotype { get; set; }
        public string promovalue { get; set; }
        public string orderdata { get; set; }
        public string amount { get; set; }
        public string paymentmethod { get; set; }
        public string invoiceid { get; set; }
        public string status { get; set; }
        public string ipaddress { get; set; }
        public string fraudmodule { get; set; }
        public string fraudoutput { get; set; }
        public string notes { get; set; }
        public string paymentmethodname { get; set; }
        public string paymentstatus { get; set; }
        public string name { get; set; }
        public string currencyprefix { get; set; }
        public string currencysuffix { get; set; }
        public string frauddata { get; set; }
        public Lineitems lineitems { get; set; }
    }

    public class Lineitems
    {
        public Lineitem[] lineitem { get; set; }
    }

    public class Lineitem
    {
        public string type { get; set; }
        public int relid { get; set; }
        public string producttype { get; set; }
        public string product { get; set; }
        public string domain { get; set; }
        public string billingcycle { get; set; }
        public string amount { get; set; }
        public string status { get; set; }
    }
}
