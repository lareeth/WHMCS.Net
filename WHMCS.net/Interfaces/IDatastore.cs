﻿using System;
using System.Collections.Specialized;

namespace WHMCS.Net.Interfaces
{
    public interface IDatastore
    {
        string GetData(string url, NameValueCollection values);
    }
}
