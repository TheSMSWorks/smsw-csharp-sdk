# IO.Swagger.Api.UtilsApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetError**](UtilsApi.md#geterror) | **GET** /utils/errors/{errorcode} | 
[**Test**](UtilsApi.md#test) | **GET** /utils/test | 

<a name="geterror"></a>
# **GetError**
> ExtendedErrorModel GetError (string errorcode)



Returns a sample error object for the given error code. Useful for designing code to react to errors when they occur for real.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetErrorExample
    {
        public void main()
        {
            var apiInstance = new UtilsApi();
            var errorcode = errorcode_example;  // string | The code of the error you would like returned

            try
            {
                ExtendedErrorModel result = apiInstance.GetError(errorcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.GetError: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **errorcode** | **string**| The code of the error you would like returned | 

### Return type

[**ExtendedErrorModel**](ExtendedErrorModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="test"></a>
# **Test**
> TestResponse Test ()



Returns the customer ID to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TestExample
    {
        public void main()
        {
            var apiInstance = new UtilsApi();

            try
            {
                TestResponse result = apiInstance.Test();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.Test: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TestResponse**](TestResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
