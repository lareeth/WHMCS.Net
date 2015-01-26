# WHMCS.net
A .net library allowing you to connect to a WHMCS installation and query the API.

[![Build Status](https://travis-ci.org/lareeth/WHMCS.net.svg?branch=master)](https://travis-ci.org/lareeth/WHMCS.net)

To get started create a new instance of WhmcsApi, then pass in the login details and domain.

```
WhmcsApi(string username, string password, string domain, bool secure)
```

This release includes access to the following functions.

```
getProduct(int productId)
getProducts()
getProducts(int groupId)
```

Nuget package also avilable https://www.nuget.org/packages/WHMCS.net

Please read http://wiki.whmcs.com/API to find out more about the data that is returned and what format it is in.
