# IO.Swagger.Api.BatchMessagesApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelScheduledBatchJob**](BatchMessagesApi.md#cancelscheduledbatchjob) | **DELETE** /batches/schedule/{batchid} | 
[**GetBatchById**](BatchMessagesApi.md#getbatchbyid) | **GET** /batch/{batchid} | 
[**ScheduleBatch**](BatchMessagesApi.md#schedulebatch) | **POST** /batch/schedule | 
[**SendBatch**](BatchMessagesApi.md#sendbatch) | **POST** /batch/send | 

<a name="cancelscheduledbatchjob"></a>
# **CancelScheduledBatchJob**
> CancelledMessageResponse CancelScheduledBatchJob (string batchid)



Cancels a scheduled SMS message

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelScheduledBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi();
            var batchid = batchid_example;  // string | The ID of the batch you would like returned

            try
            {
                CancelledMessageResponse result = apiInstance.CancelScheduledBatchJob(batchid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.CancelScheduledBatchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchid** | **string**| The ID of the batch you would like returned | 

### Return type

[**CancelledMessageResponse**](CancelledMessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbatchbyid"></a>
# **GetBatchById**
> MessagesResponse GetBatchById (string batchid)



Retrieve all messages in a batch with the given batch ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBatchByIdExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi();
            var batchid = batchid_example;  // string | The ID of the batch you would like returned

            try
            {
                MessagesResponse result = apiInstance.GetBatchById(batchid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.GetBatchById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchid** | **string**| The ID of the batch you would like returned | 

### Return type

[**MessagesResponse**](MessagesResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="schedulebatch"></a>
# **ScheduleBatch**
> ScheduledBatchResponse ScheduleBatch (BatchMessage body)



Schedules a batch of SMS messages to be sent at the date time you specify

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ScheduleBatchExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi();
            var body = new BatchMessage(); // BatchMessage | Message properties

            try
            {
                ScheduledBatchResponse result = apiInstance.ScheduleBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.ScheduleBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BatchMessage**](BatchMessage.md)| Message properties | 

### Return type

[**ScheduledBatchResponse**](ScheduledBatchResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendbatch"></a>
# **SendBatch**
> BatchMessageResponse SendBatch (BatchMessage body)



Send a single SMS message to multiple recipients

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendBatchExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi();
            var body = new BatchMessage(); // BatchMessage | Message properties

            try
            {
                BatchMessageResponse result = apiInstance.SendBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.SendBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BatchMessage**](BatchMessage.md)| Message properties | 

### Return type

[**BatchMessageResponse**](BatchMessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
