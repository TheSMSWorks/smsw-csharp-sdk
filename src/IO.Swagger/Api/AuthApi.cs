/* 
 * The SMS Works API
 *
 * The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed messages are refunded.
 *
 * OpenAPI spec version: 1.6.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IAuthApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>ApiKeyResponse</returns>
        ApiKeyResponse KeySecret (string customerid);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>ApiResponse of ApiKeyResponse</returns>
        ApiResponse<ApiKeyResponse> KeySecretWithHttpInfo (string customerid);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>TokenResponse</returns>
        TokenResponse Login (Login body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>ApiResponse of TokenResponse</returns>
        ApiResponse<TokenResponse> LoginWithHttpInfo (Login body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>Task of ApiKeyResponse</returns>
        System.Threading.Tasks.Task<ApiKeyResponse> KeySecretAsync (string customerid);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>Task of ApiResponse (ApiKeyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiKeyResponse>> KeySecretAsyncWithHttpInfo (string customerid);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>Task of TokenResponse</returns>
        System.Threading.Tasks.Task<TokenResponse> LoginAsync (Login body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>Task of ApiResponse (TokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenResponse>> LoginAsyncWithHttpInfo (Login body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class AuthApi : IAuthApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// </summary>
        /// <returns></returns>
        public AuthApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>ApiKeyResponse</returns>
        public ApiKeyResponse KeySecret (string customerid)
        {
             ApiResponse<ApiKeyResponse> localVarResponse = KeySecretWithHttpInfo(customerid);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>ApiResponse of ApiKeyResponse</returns>
        public ApiResponse< ApiKeyResponse > KeySecretWithHttpInfo (string customerid)
        {
            // verify the required parameter 'customerid' is set
            if (customerid == null)
                throw new ApiException(400, "Missing required parameter 'customerid' when calling AuthApi->KeySecret");

            var localVarPath = "/auth/getApiKey";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (customerid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "customerid", customerid)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("KeySecret", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiKeyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyResponse)));
        }

        /// <summary>
        ///  Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>Task of ApiKeyResponse</returns>
        public async System.Threading.Tasks.Task<ApiKeyResponse> KeySecretAsync (string customerid)
        {
             ApiResponse<ApiKeyResponse> localVarResponse = await KeySecretAsyncWithHttpInfo(customerid);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerid">Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login</param>
        /// <returns>Task of ApiResponse (ApiKeyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiKeyResponse>> KeySecretAsyncWithHttpInfo (string customerid)
        {
            // verify the required parameter 'customerid' is set
            if (customerid == null)
                throw new ApiException(400, "Missing required parameter 'customerid' when calling AuthApi->KeySecret");

            var localVarPath = "/auth/getApiKey";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (customerid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "customerid", customerid)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("KeySecret", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiKeyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyResponse)));
        }

        /// <summary>
        ///  Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>TokenResponse</returns>
        public TokenResponse Login (Login body)
        {
             ApiResponse<TokenResponse> localVarResponse = LoginWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>ApiResponse of TokenResponse</returns>
        public ApiResponse< TokenResponse > LoginWithHttpInfo (Login body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthApi->Login");

            var localVarPath = "/auth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Login", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TokenResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenResponse)));
        }

        /// <summary>
        ///  Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>Task of TokenResponse</returns>
        public async System.Threading.Tasks.Task<TokenResponse> LoginAsync (Login body)
        {
             ApiResponse<TokenResponse> localVarResponse = await LoginAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key &amp; Secret required for this call from the API Key tab your account page.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">API Key &amp; Secret</param>
        /// <returns>Task of ApiResponse (TokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TokenResponse>> LoginAsyncWithHttpInfo (Login body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthApi->Login");

            var localVarPath = "/auth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Login", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TokenResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenResponse)));
        }

    }
}
