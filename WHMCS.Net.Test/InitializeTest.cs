using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHMCS.Net.Interfaces;
using Xunit;

namespace WHMCS.Net.Test
{
    public class InitializeTest
    {

        [Fact]
        public void TestInstanceWithUsernamePassword()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            Assert.NotNull(instance);
        }

        [Fact]
        public void TestInstanceWithUsernamePasswordAccesskey()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();

            WhmcsApi instance = new WhmcsApi("User", "Pass", "ABC123", "Website", mockDatastore.Object);
            Assert.NotNull(instance);
        }
    }
}
