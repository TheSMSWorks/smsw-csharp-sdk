# IO.Swagger.Api.CreditsApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Credits**](CreditsApi.md#credits) | **GET** /credits/balance | 

<a name="credits"></a>
# **Credits**
> CreditsResponse Credits ()



Returns the number of credits currently available on the account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreditsExample
    {
        public void main()
        {
            var apiInstance = new CreditsApi();

            try
            {
                CreditsResponse result = apiInstance.Credits();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditsApi.Credits: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CreditsResponse**](CreditsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
