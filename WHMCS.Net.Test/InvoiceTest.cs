using System;
using Moq;
using System.Collections.Specialized;
using System.Linq;
using WHMCS.Net.Interfaces;
using WHMCS.Net.Models;
using System.Linq.Expressions;
using Xunit;

namespace WHMCS.Net.Test
{
    public class InvoiceTest
    {
        private string JsonData = "{\"result\":\"success\",\"invoiceid\":\"218\",\"invoicenum\":\"\",\"userid\":\"30\",\"date\":\"2015-01-29\",\"duedate\":\"2015-02-12\",\"datepaid\":\"2015-02-0218:43:58\",\"subtotal\":\"7.50\",\"credit\":\"0.00\",\"tax\":\"0.00\",\"tax2\":\"0.00\",\"total\":\"7.50\",\"balance\":\"0.00\",\"taxrate\":\"0.00\",\"taxrate2\":\"0.00\",\"status\":\"Paid\",\"paymentmethod\":\"paypal\",\"notes\":\"\",\"ccgateway\":false,\"items\":{\"item\":[{\"id\":\"311\",\"type\":\"Hosting\",\"relid\":\"37\",\"description\":\"Basic-R-example.com(12\\/02\\/2015-11\\/03\\/2015)\",\"amount\":\"7.50\",\"taxed\":\"0\"}]},\"transactions\":{\"transaction\":[{\"id\":\"162\",\"userid\":\"30\",\"currency\":\"0\",\"gateway\":\"paypal\",\"date\":\"2015-02-0218:43:58\",\"description\":\"InvoicePayment\",\"amountin\":\"7.50\",\"fees\":\"0.46\",\"amountout\":\"0.00\",\"rate\":\"1.00000\",\"transid\":\"1AB01234AB1234567\",\"invoiceid\":\"218\",\"refundid\":\"0\"}]}}";
        private Expression<Func<IDatastore, string>> InvoiceExpectation = datastore => datastore.GetData("Website", It.IsNotNull<NameValueCollection>());

        [Fact]
        public void TestSingleInvoiceItemAmount()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(InvoiceExpectation).Returns(JsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            InvoiceResponse singleInvoice = instance.GetInvoice(218);
            Assert.Equal("7.50", singleInvoice.Items.Item.SingleOrDefault().Amount);
        }

        [Fact]
        public void TestGetSingleInvoice()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(InvoiceExpectation).Returns(JsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            InvoiceResponse singleInvoice = instance.GetInvoice(218);
            Assert.NotNull(singleInvoice);
        }
    }
}
