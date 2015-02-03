using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WHMCS.Net;
using WHMCS.Net.Interfaces;

namespace WHMCS.Net
{
    class Datastore : IDatastore
    {
        public string GetData(string url, NameValueCollection values)
        {
            try
            {
                byte[] webResponse = new WebClient().UploadValues(url, values);
                return Encoding.ASCII.GetString(webResponse);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to connect to WHMCS API. " + ex.Message.ToString());
            }

        }
    }
}
