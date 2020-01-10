# WHMCS.Net
A .net library allowing you to connect to a WHMCS installation and query the API.

| Environment | Status |
| ------------- |:-------------:|
| Master        | [![Build Status](https://travis-ci.com/lareeth/WHMCS.Net.svg?branch=master)](https://travis-ci.com/lareeth/WHMCS.Net) |
| Dev           | [![Build Status](https://travis-ci.com/lareeth/WHMCS.Net.svg?branch=dev)](https://travis-ci.com/lareeth/WHMCS.Net) |

To get started create a new instance of WhmcsApi, then pass in the login details and domain. You can additionally pass in an access key if you have it set up

```csharp
WhmcsApi(string username, string password, string url)
```

```csharp
WhmcsApi(string username, string password, string accessKey, string url)
```

This release includes access to the following functions.

```csharp
GetProduct(int productId)
GetProducts()
GetProducts(int groupId)
GetInvoice(int invoiceId)
GetOrders(int? orderId, int? userId, OrderStatus? orderStatus, int? limitStart, int? limitNum)
GetClientsDetails(int clientId)
GetStats()
```

To display the products simply loop though the returned List

```csharp
WhmcsApi WHMCSAPI = new WhmcsApi("username", "password", "http://www.domain.com/includes/api.php");
foreach (Product Product in WHMCSAPI.getProducts().Products.Product) {
	//View logic here
    @Product.Name;
}
```

To display the invoice.

```csharp
WhmcsApi WHMCSAPI = new WhmcsApi("username", "password", "http://www.domain.com/includes/api.php");
InvoiceResponse Invoice = WHMCSAPI.GetInvoice(218)
//View logic here
@Invoice.PaymentMethod;

```

Nuget package also available https://www.nuget.org/packages/WHMCS.Net

Please read http://wiki.whmcs.com/API to find out more about the data that is returned and what format it is in.
