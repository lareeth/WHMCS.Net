using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Text;
using WHMCS.Net.Interfaces;
using WHMCS.Net.Models;
using WHMCS.Net.Models.Enums;

namespace WHMCS.Net
{
    public class WhmcsApi
    {
        private readonly string _url;
        private readonly NameValueCollection _formData;
        private readonly IDatastore _datastore;

        public WhmcsApi(string username, string password, string url, IDatastore datastore)
        {
            _url = url;
            _datastore = datastore;

            _formData = new NameValueCollection()
            {
                {"username", username},
                {"password", Security.CalculateMD5Hash(password)},
                {"responsetype", "json"}
            };
        }

        public WhmcsApi(string username, string password, string url)
            : this(username, password, url, new Datastore())
        {

        }

        public WhmcsApi(string username, string password, string accessKey, string url, IDatastore datastore)
            : this(username, password, url, new Datastore())
        {
            _formData.Add("accesskey", accessKey);
        }

        public WhmcsApi(string username, string password, string accessKey, string url)
            : this(username, password, accessKey, url, new Datastore())
        {

        }

        public ProductsResponse GetProduct(int productId)
        {
            return JsonConvert.DeserializeObject<ProductsResponse>(_datastore.GetData(_url, new NameValueCollection
            {
                _formData,
                {"action", "getproducts"},
                {"pid", productId.ToString()}
            }));
        }

        public ProductsResponse GetProducts()
        {
            return JsonConvert.DeserializeObject<ProductsResponse>(_datastore.GetData(_url, new NameValueCollection
            {
                _formData,
                {"action", "getproducts"}
            }));
        }

        public ProductsResponse GetProducts(int groupId)
        {
            return JsonConvert.DeserializeObject<ProductsResponse>(_datastore.GetData(_url, new NameValueCollection 
            {
                _formData,
                {"action", "getproducts"},
                {"gid", groupId.ToString()}
            }));
        }

        public InvoiceResponse GetInvoice(int invoiceId)
        {
            return JsonConvert.DeserializeObject<InvoiceResponse>(_datastore.GetData(_url, new NameValueCollection
            {
                _formData,
                {"action", "getinvoice"},
                {"invoiceid", invoiceId.ToString()}
            }));
        }

        public OrdersResponse GetOrders(int? orderId = null, int? userId = null, OrderStatus? orderStatus = null, int? limitStart = null, int? limitNum = null)
        {
            NameValueCollection values = new NameValueCollection
            {
                _formData,
                {"action", "getorders"}
            };

            if (orderId.HasValue)
            {
                values.Add("id", orderId.ToString());
            }

            if (userId.HasValue)
            {
                values.Add("userid", userId.ToString());
            }

            if (orderStatus.HasValue)
            {
                values.Add("status", orderStatus.ToString());
            }

            if (limitStart.HasValue)
            {
                values.Add("limitstart", limitStart.ToString());
            }

            if (limitNum.HasValue)
            {
                values.Add("limitnum", limitNum.ToString());
            }

            return JsonConvert.DeserializeObject<OrdersResponse>(_datastore.GetData(_url, values));
        }

        public ClientsDetailsResponse GetClientsDetails(int clientId)
        {
            NameValueCollection values = new NameValueCollection
            {
                _formData,
                {"action", "getclientsdetails"},
                {"clientid", clientId.ToString()}
            };

            return JsonConvert.DeserializeObject<ClientsDetailsResponse>(_datastore.GetData(_url, values));
        }

        public StatsResponse GetStats()
        {
            NameValueCollection values = new NameValueCollection
            {
                _formData,
                {"action", "getstats"}
            };

            return JsonConvert.DeserializeObject<StatsResponse>(_datastore.GetData(_url, values));
        }
    }
}