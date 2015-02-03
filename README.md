# WHMCS.Net
A .net library allowing you to connect to a WHMCS installation and query the API.

[![Build Status](https://travis-ci.org/lareeth/WHMCS.Net.svg?branch=master)](https://travis-ci.org/lareeth/WHMCS.net)

To get started create a new instance of WhmcsApi, then pass in the login details and domain.

```
WhmcsApi(string username, string password, string url)
```

This release includes access to the following functions.

```
GetProduct(int productId)
GetProducts()
GetProducts(int groupId)
GetInvoice(int invoiceId)
```

To display the products simply loop though the returned List

```
WhmcsApi WHMCSAPI = new WhmcsApi("username", "password", "http://www.domain.com/includes/api.php");
foreach (Product Product in WHMCSAPI.getProducts().Products.Product) {
	//View logic here
    @Product.Name;
}
```

To display the invoice.

```
WhmcsApi WHMCSAPI = new WhmcsApi("username", "password", "http://www.domain.com/includes/api.php");
InvoiceResponse Invoice = WHMCSAPI.GetInvoice(218)
//View logic here
@Invoice.PaymentMethod;

```

Nuget package also available https://www.nuget.org/packages/WHMCS.Net

Please read http://wiki.whmcs.com/API to find out more about the data that is returned and what format it is in.
