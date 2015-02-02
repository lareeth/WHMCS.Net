using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WHMCS.net;
using WHMCS.net.Interfaces;

namespace WHMCS.net
{
    class Datastore : IDatastore
    {
        public string GetData(string url, NameValueCollection values)
        {
            byte[] webResponse = new WebClient().UploadValues(url, values);
            return Encoding.ASCII.GetString(webResponse);
        }
    }
}
