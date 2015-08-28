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
    public class StatsTest
    {
        private readonly string _jsonData = "{\"result\":\"success\",\"income_today\":\"1.00\",\"income_thismonth\":\"1.00\",\"income_thisyear\":\"1.00\",\"orders_pending\":\"1\",\"orders_today_cancelled\":\"1\",\"orders_today_pending\":\"1\",\"orders_today_fraud\":\"1\",\"orders_today_active\":\"1\",\"orders_today_total\":\"1\",\"orders_yesterday_cancelled\":\"1\",\"orders_yesterday_pending\":\"123\",\"orders_yesterday_fraud\":\"1\",\"orders_yesterday_active\":\"1\",\"orders_yesterday_total\":\"1\",\"orders_thismonth_total\":\"1\",\"orders_thisyear_total\":\"1\",\"tickets_closed\":\"1\",\"tickets_inprogress\":\"1\",\"tickets_onhold\":\"1\",\"tickets_customerreply\":\"1\",\"tickets_answered\":\"1\",\"tickets_open\":\"1\",\"cancellations_pending\":\"1\",\"todoitems_due\":\"1\",\"networkissues_open\":\"1\",\"billableitems_uninvoiced\":\"1\",\"quotes_valid\":\"1\",\"staff_online\":\"1\"}";
        private readonly Expression<Func<IDatastore, string>> _invoiceExpectation = datastore => datastore.GetData("Website", It.IsNotNull<NameValueCollection>());

        [Fact]
        public void TestGetStats()
        {
            Mock<IDatastore> mockDatastore = new Mock<IDatastore>();
            mockDatastore.Setup(_invoiceExpectation).Returns(_jsonData);

            WhmcsApi instance = new WhmcsApi("User", "Pass", "Website", mockDatastore.Object);
            StatsResponse stats = instance.GetStats();
            Assert.Equal("123", stats.OrdersYesterdayPending);
        }
    }
}
