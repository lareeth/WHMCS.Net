using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;
using System.Linq;
using WHMCS.Net.Interfaces;
using WHMCS.Net.Models;

namespace WHMCS.Net.Test
{
    [TestClass]
    public class ProductTest : IDatastore
    {
        [TestMethod]
        public void TestSingleProductName()
        {
            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", this);
            ProductsResponse singleProduct = instance.GetProduct(1);
            Assert.AreEqual("Basic cPanel Shared Hosting", singleProduct.Products.Product.SingleOrDefault().Name);
        }

        [TestMethod]
        public void TestGetSingleProduct()
        {
            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", this);
            ProductsResponse singleProduct = instance.GetProduct(1);
            Assert.IsNotNull(singleProduct);
        }

        [TestMethod]
        public void TestGetGroupProducts()
        {
            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", this);
            ProductsResponse test = instance.GetProducts(1);
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void TestGetAllProducts()
        {
            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", this);
            ProductsResponse test = instance.GetProducts();
            Assert.IsNotNull(test);
        }

        public string GetData(string url, NameValueCollection values)
        {
            return "{\"result\":\"success\",\"totalresults\":1,\"products\":{\"product\":[{\"pid\":\"1\",\"gid\":\"1\",\"type\":\"hostingaccount\",\"name\":\"Basic cPanel Shared Hosting\",\"description\":\"    Perfect for those getting started online\r\n    2.5GB Storage\r\n    25GB Bandwidth\r\n    Free Domain *\r\n    2 Hosted Website\r\n    Support Online & Offline\r\n\",\"module\":\"cpanel\",\"paytype\":\"recurring\",\"pricing\":{\"GBP\":{\"prefix\":\"\u00a3\",\"suffix\":\"GBP\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"2.50\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"25.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"}},\"customfields\":{\"customfield\":[]},\"configoptions\":{\"configoption\":[]}}]}}";
        }
    }
}
