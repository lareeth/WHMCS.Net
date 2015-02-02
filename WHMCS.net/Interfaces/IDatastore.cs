using System;
using System.Collections.Specialized;

namespace WHMCS.net.Interfaces
{
    public interface IDatastore
    {
        string GetData(string url, NameValueCollection values);
    }
}
