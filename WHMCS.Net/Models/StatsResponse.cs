using Newtonsoft.Json;

namespace WHMCS.Net.Models
{
    public class StatsResponse
    {
        [JsonProperty("result")]
        public string Reuslt { get; set; }

        [JsonProperty("income_today")]
        public string IncomeToday { get; set; }

        [JsonProperty("income_thismonth")]
        public string IncomeThisMonth { get; set; }

        [JsonProperty("income_thisyear")]
        public string IncomeThisYear { get; set; }

        [JsonProperty("orders_pending")]
        public string OrdersPending { get; set; }

        [JsonProperty("orders_today_cancelled")]
        public string OrdersTodayCancelled { get; set; }

        [JsonProperty("orders_today_pending")]
        public string OrdersTodayPending { get; set; }

        [JsonProperty("orders_today_fraud")]
        public string OrdersTodayFraud { get; set; }

        [JsonProperty("orders_today_active")]
        public string OrdersTodayActive { get; set; }

        [JsonProperty("orders_today_total")]
        public string OrdersTodayTotal { get; set; }

        [JsonProperty("orders_yesterday_cancelled")]
        public string OrdersYesterdayCancelled { get; set; }

        [JsonProperty("orders_yesterday_pending")]
        public string OrdersYesterdayPending { get; set; }

        [JsonProperty("orders_yesterday_fraud")]
        public string OrdersYesterdayFraud { get; set; }

        [JsonProperty("orders_yesterday_active")]
        public string OrdersYesterdayActive { get; set; }

        [JsonProperty("orders_yesterday_total")]
        public string OrdersYesterdayTotal { get; set; }

        [JsonProperty("orders_thismonth_total")]
        public string OrdersThisMonthTotal { get; set; }

        [JsonProperty("orders_thisyear_total")]
        public string OrdersThisYearTotal { get; set; }

        [JsonProperty("tickets_closed")]
        public string TicketsClosed { get; set; }

        [JsonProperty("tickets_inprogress")]
        public string TicketsInProgress { get; set; }

        [JsonProperty("tickets_onhold")]
        public string TicketsOnHold { get; set; }

        [JsonProperty("tickets_customerreply")]
        public string TicketsCustomerReply { get; set; }

        [JsonProperty("tickets_answered")]
        public string TicketsAnswered { get; set; }

        [JsonProperty("tickets_open")]
        public string TicketsOpen { get; set; }

        [JsonProperty("cancellations_pending")]
        public string CancellationsPending { get; set; }

        [JsonProperty("todoitems_due")]
        public string TodoItemsDue { get; set; }

        [JsonProperty("networkissues_open")]
        public string NetworkIssuesOpen { get; set; }

        [JsonProperty("billableitems_uninvoiced")]
        public string BillableItemsUninvoiced { get; set; }

        [JsonProperty("quotes_valid")]
        public string QuotesValid { get; set; }

        [JsonProperty("staff_online")]
        public string StaffOnline { get; set; }
    }
}
