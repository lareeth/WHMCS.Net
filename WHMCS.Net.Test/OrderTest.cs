using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Moq;
using WHMCS.Net.Interfaces;
using WHMCS.Net.Models;
using Xunit;

namespace WHMCS.Net.Test
{
    public class OrderTest
    {
        private readonly string _jsonData = "{}";
        private readonly Expression<Func<IDatastore, string>> _invoiceExpectation = datastore => datastore.GetData("Website", It.IsNotNull<NameValueCollection>());

        [Fact]
        public void TestGetSingleInvoice()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(_invoiceExpectation).Returns(_jsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            OrdersResponse singleInvoice = instance.GetOrders(123);
            Assert.NotNull(singleInvoice);
        }
    }
}
