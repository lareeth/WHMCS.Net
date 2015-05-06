using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS.Net.Models
{

    public class ClientsDetailsResponse
    {
        public string result { get; set; }
        public string userid { get; set; }
        public string id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string fullname { get; set; }
        public string companyname { get; set; }
        public string email { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string fullstate { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string countrycode { get; set; }
        public string country { get; set; }
        public string statecode { get; set; }
        public string countryname { get; set; }
        public int phonecc { get; set; }
        public string phonenumber { get; set; }
        public string phonenumberformatted { get; set; }
        public string billingcid { get; set; }
        public string notes { get; set; }
        public string password { get; set; }
        public bool twofaenabled { get; set; }
        public string currency { get; set; }
        public string defaultgateway { get; set; }
        public string cctype { get; set; }
        public string cclastfour { get; set; }
        public string securityqid { get; set; }
        public string securityqans { get; set; }
        public string groupid { get; set; }
        public string status { get; set; }
        public string credit { get; set; }
        public string taxexempt { get; set; }
        public string latefeeoveride { get; set; }
        public string overideduenotices { get; set; }
        public string separateinvoices { get; set; }
        public string disableautocc { get; set; }
        public string emailoptout { get; set; }
        public string overrideautoclose { get; set; }
        public string language { get; set; }
        public string lastlogin { get; set; }
        public string currency_code { get; set; }
    }

}
