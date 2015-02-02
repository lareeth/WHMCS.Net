using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;
using WHMCS.net.Models;
using WHMCS.net;
using WHMCS.net.Interfaces;

namespace WHMCS.Net.Test
{
    [TestClass]
    public class InvoiceTest : IDatastore
    {
        [TestMethod]
        public void TestInvoice()
        {

        }

        public string GetData(string url, NameValueCollection values)
        {
            return null;
        }
    }
}
