# IO.Swagger.Model.BatchMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#x27;s. No spaces or special characters. | 
**Destinations** | **List&lt;string&gt;** | Telephone numbers of each of the recipients | 
**Content** | **string** | Message to send to the recipient | 
**Schedule** | **string** | Date-time at which to send the batch. This is only used by the batch/schedule service. | 
**Tag** | **string** | An identifying label for the message, which you can use to filter and report on messages you&#x27;ve sent later. Ideal for campaigns. A maximum of 280 characters. | [optional] 
**Ttl** | [**decimal?**](BigDecimal.md) | The number of minutes before the message is deleted. Optional. Omit to prevent delivery report deletion. Integer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

