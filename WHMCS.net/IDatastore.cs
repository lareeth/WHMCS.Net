using System;
using System.Collections.Specialized;

namespace WHMCS.net
{
    public interface IDatastore
    {
        string GetData(string url, NameValueCollection values);
    }
}
