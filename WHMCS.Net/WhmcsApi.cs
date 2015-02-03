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

        public WhmcsApi(string username, string password, string url, IDatastore datastore)
        {
            _url = url;

            _formData = new NameValueCollection()
            {
                {"username", username},
                {"password", CalculateMD5Hash(password)},
                {"responsetype", "json"}
            };

            _datastore = datastore;
        }

        public WhmcsApi(string username, string password, string url)
            : this(username, password, url, new Datastore())
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
            NameValueCollection requestData = new NameValueCollection
            {
                _formData,
                {"action", "getproducts"},
                {"pid", productId.ToString()}
            };
            return JsonConvert.DeserializeObject<ProductsResponse>(_datastore.GetData(_url, requestData));
        }

        public ProductsResponse GetProducts()
        {
            NameValueCollection requestData = new NameValueCollection
            {
                _formData,
                {"action", "getproducts"}
            };
            return JsonConvert.DeserializeObject<ProductsResponse>(_datastore.GetData(_url, requestData));
        }

        public ProductsResponse GetProducts(int groupId)
        {
            NameValueCollection requestData = new NameValueCollection
            {
                _formData,
                {"action", "getproducts"},
                {"gid", groupId.ToString()}
            };
            return JsonConvert.DeserializeObject<ProductsResponse>(_datastore.GetData(_url, requestData));
        }

        public InvoiceResponse GetInvoice(int invoiceId)
        {
            NameValueCollection requestData = new NameValueCollection
            {
                _formData,
                {"action", "getinvoice"},
                {"invoiceid", invoiceId.ToString()}
            };
            return JsonConvert.DeserializeObject<InvoiceResponse>(_datastore.GetData(_url, requestData));
        }
    }
}