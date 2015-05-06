using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using WHMCS.Net.Interfaces;
using WHMCS.Net.Models;

namespace WHMCS.Net
{
    public class WhmcsApi
    {
        private readonly string _url;
        private readonly NameValueCollection _formData;
        private readonly IDatastore _datastore;

        public WhmcsApi(string username, string password, string url, IDatastore datastore, string accessKey = null)
        {
            _url = url;
            _datastore = datastore;

            _formData = new NameValueCollection()
            {
                {"username", username},
                {"password", CalculateMD5Hash(password)},
                {"responsetype", "json"}
            };

            if (!string.IsNullOrEmpty(accessKey))
            {
                _formData.Add("accesskey", accessKey);
            }
        }

        public WhmcsApi(string username, string password, string url, string accessKey = null)
            : this(username, password, url, new Datastore(), accessKey)
        {

        }

        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            foreach (byte t in hash)
            {
                sb.Append(t.ToString("x2"));
            }
            return sb.ToString();
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
    }
}