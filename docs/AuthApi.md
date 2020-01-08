# IO.Swagger.Api.AuthApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**KeySecret**](AuthApi.md#keysecret) | **GET** /auth/getApiKey | 
[**Login**](AuthApi.md#login) | **POST** /auth/token | 

<a name="keysecret"></a>
# **KeySecret**
> ApiKeyResponse KeySecret (string customerid)



Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class KeySecretExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var customerid = customerid_example;  // string | Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login

            try
            {
                ApiKeyResponse result = apiInstance.KeySecret(customerid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.KeySecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerid** | **string**| Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login | 

### Return type

[**ApiKeyResponse**](ApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="login"></a>
# **Login**
> TokenResponse Login (Login body)



Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key & Secret required for this call from the API Key tab your account page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var body = new Login(); // Login | API Key & Secret

            try
            {
                TokenResponse result = apiInstance.Login(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Login**](Login.md)| API Key &amp; Secret | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
