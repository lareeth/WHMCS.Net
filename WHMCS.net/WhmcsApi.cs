using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using WHMCS.net.Models;

namespace WHMCS.net
{
    public class WhmcsApi
    {

        private readonly string _username;
        private readonly string _password;
        private readonly string _url;
        private readonly NameValueCollection _formData;

        public WhmcsApi(string username, string password, string domain, bool secure)
        {
            _username = username;
            _password = CalculateMD5Hash(password);

            _formData = new NameValueCollection()
            {
                {"username", _username},
                {"password", _password},
                {"responsetype", "json"}
            };

            _url = (secure ? "https://" : "http://") + domain + "/includes/api.php";
        }

        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public ProductsResponse getProduct(int productId)
        {
            NameValueCollection requestData = new NameValueCollection
            {
                _formData,
                {"action", "getproducts"},
                {"pid", productId.ToString()}
            };
            Byte[] responseData = new WebClient().UploadValues(_url, requestData);
            return JsonConvert.DeserializeObject<ProductsResponse>(Encoding.ASCII.GetString(responseData));
        }

        public ProductsResponse getProducts()
        {
            NameValueCollection requestData = new NameValueCollection
            {
                _formData,
                {"action", "getproducts"}
            };
            Byte[] responseData = new WebClient().UploadValues(_url, requestData);
            return JsonConvert.DeserializeObject<ProductsResponse>(Encoding.ASCII.GetString(responseData));
        }

        public ProductsResponse getProducts(int groupId)
        {
            NameValueCollection requestData = new NameValueCollection
            {
                _formData,
                {"action", "getproducts"},
                {"gid", groupId.ToString()}
            };
            Byte[] responseData = new WebClient().UploadValues(_url, requestData);
            return JsonConvert.DeserializeObject<ProductsResponse>(Encoding.ASCII.GetString(responseData));
        }
    }
}