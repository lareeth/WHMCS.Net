using Moq;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using WHMCS.Net.Interfaces;
using WHMCS.Net.Models;
using Xunit;

namespace WHMCS.Net.Test
{
    public class ProductTest
    {
        private string JsonData = "{\"result\":\"success\",\"totalresults\":1,\"products\":{\"product\":[{\"pid\":\"1\",\"gid\":\"1\",\"type\":\"hostingaccount\",\"name\":\"Basic cPanel Shared Hosting\",\"description\":\"    Perfect for those getting started online\r\n    2.5GB Storage\r\n    25GB Bandwidth\r\n    Free Domain *\r\n    2 Hosted Website\r\n    Support Online & Offline\r\n\",\"module\":\"cpanel\",\"paytype\":\"recurring\",\"pricing\":{\"GBP\":{\"prefix\":\"\u00a3\",\"suffix\":\"GBP\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"2.50\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"25.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"}},\"customfields\":{\"customfield\":[]},\"configoptions\":{\"configoption\":[]}}]}}";
        private Expression<Func<IDatastore, string>> ProductExpectation = datastore => datastore.GetData("Website", It.IsNotNull<NameValueCollection>());

        [Fact]
        public void TestSingleProductName()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(ProductExpectation).Returns(JsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            ProductsResponse singleProduct = instance.GetProduct(1);
            Assert.Equal("Basic cPanel Shared Hosting", singleProduct.Products.Product.SingleOrDefault().Name);
        }

        [Fact]
        public void TestGetSingleProduct()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(ProductExpectation).Returns(JsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            ProductsResponse singleProduct = instance.GetProduct(1);
            Assert.NotNull(singleProduct);
        }

        [Fact]
        public void TestGetGroupProducts()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(ProductExpectation).Returns(JsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            ProductsResponse test = instance.GetProducts(1);
            Assert.NotNull(test);
        }

        [Fact]
        public void TestGetAllProducts()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(ProductExpectation).Returns(JsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            ProductsResponse test = instance.GetProducts();
            Assert.NotNull(test);
        }
    }
}
