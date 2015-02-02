using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WHMCS.net.Models;

namespace WHMCS.Net.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ProductName()
        {
            Product product = new Product()
            {
                Name = "Product Item One"
            };
            Assert.AreEqual(product.Name, "Product Item One");
        }
    }
}
