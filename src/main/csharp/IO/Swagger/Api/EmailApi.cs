using System;
using System.IO;
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
    public interface IEmailApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param>
        /// <returns>Object</returns>
        Object CreateApiWebSendJson (Emailv1 data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> CreateApiWebSendJsonWithHttpInfo (Emailv1 data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param>
        /// <param name="from">From email address</param>
        /// <param name="subject">Subject of the Email</param>
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param>
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param>
        /// <param name="fromname">Email Sender name (optional)</param>
        /// <param name="replytoid">Reply to email address (optional)</param>
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param>
        /// <param name="template">Email template ID (optional)</param>
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param>
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param>
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param>
        /// <param name="bcc">Email address for bcc (optional)</param>
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param>
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param>
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param>
        /// <returns>Object</returns>
        Object GetApiWebSendRest (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param>
        /// <param name="from">From email address</param>
        /// <param name="subject">Subject of the Email</param>
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param>
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param>
        /// <param name="fromname">Email Sender name (optional)</param>
        /// <param name="replytoid">Reply to email address (optional)</param>
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param>
        /// <param name="template">Email template ID (optional)</param>
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param>
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param>
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param>
        /// <param name="bcc">Email address for bcc (optional)</param>
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param>
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param>
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetApiWebSendRestWithHttpInfo (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> CreateApiWebSendJsonAsync (Emailv1 data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateApiWebSendJsonAsyncWithHttpInfo (Emailv1 data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param>
        /// <param name="from">From email address</param>
        /// <param name="subject">Subject of the Email</param>
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param>
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param>
        /// <param name="fromname">Email Sender name (optional)</param>
        /// <param name="replytoid">Reply to email address (optional)</param>
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param>
        /// <param name="template">Email template ID (optional)</param>
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param>
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param>
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param>
        /// <param name="bcc">Email address for bcc (optional)</param>
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param>
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param>
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetApiWebSendRestAsync (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param>
        /// <param name="from">From email address</param>
        /// <param name="subject">Subject of the Email</param>
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param>
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param>
        /// <param name="fromname">Email Sender name (optional)</param>
        /// <param name="replytoid">Reply to email address (optional)</param>
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param>
        /// <param name="template">Email template ID (optional)</param>
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param>
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param>
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param>
        /// <param name="bcc">Email address for bcc (optional)</param>
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param>
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param>
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetApiWebSendRestAsyncWithHttpInfo (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmailApi : IEmailApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param> 
        /// <returns>Object</returns>
        public Object CreateApiWebSendJson (Emailv1 data)
        {
             ApiResponse<Object> localVarResponse = CreateApiWebSendJsonWithHttpInfo(data);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > CreateApiWebSendJsonWithHttpInfo (Emailv1 data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling EmailApi->CreateApiWebSendJson");
            
    
            var localVarPath = "/api/web.send.json";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiWebSendJson: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiWebSendJson: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> CreateApiWebSendJsonAsync (Emailv1 data)
        {
             ApiResponse<Object> localVarResponse = await CreateApiWebSendJsonAsyncWithHttpInfo(data);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input. This is JSON API.\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data in JSON format</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateApiWebSendJsonAsyncWithHttpInfo (Emailv1 data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling CreateApiWebSendJson");
            
    
            var localVarPath = "/api/web.send.json";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiWebSendJson: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiWebSendJson: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param> 
        /// <param name="from">From email address</param> 
        /// <param name="subject">Subject of the Email</param> 
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param> 
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param> 
        /// <param name="fromname">Email Sender name (optional)</param> 
        /// <param name="replytoid">Reply to email address (optional)</param> 
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param> 
        /// <param name="template">Email template ID (optional)</param> 
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param> 
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param> 
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param> 
        /// <param name="bcc">Email address for bcc (optional)</param> 
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param> 
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param> 
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param> 
        /// <returns>Object</returns>
        public Object GetApiWebSendRest (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null)
        {
             ApiResponse<Object> localVarResponse = GetApiWebSendRestWithHttpInfo(apiKey, from, subject, content, recipients, fromname, replytoid, footer, template, attachmentid, clicktrack, opentrack, bcc, ATT_NAME, X_APIHEADER, tags);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param> 
        /// <param name="from">From email address</param> 
        /// <param name="subject">Subject of the Email</param> 
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param> 
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param> 
        /// <param name="fromname">Email Sender name (optional)</param> 
        /// <param name="replytoid">Reply to email address (optional)</param> 
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param> 
        /// <param name="template">Email template ID (optional)</param> 
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param> 
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param> 
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param> 
        /// <param name="bcc">Email address for bcc (optional)</param> 
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param> 
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param> 
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetApiWebSendRestWithHttpInfo (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null)
        {
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling EmailApi->GetApiWebSendRest");
            
            // verify the required parameter 'from' is set
            if (from == null)
                throw new ApiException(400, "Missing required parameter 'from' when calling EmailApi->GetApiWebSendRest");
            
            // verify the required parameter 'subject' is set
            if (subject == null)
                throw new ApiException(400, "Missing required parameter 'subject' when calling EmailApi->GetApiWebSendRest");
            
            // verify the required parameter 'content' is set
            if (content == null)
                throw new ApiException(400, "Missing required parameter 'content' when calling EmailApi->GetApiWebSendRest");
            
            // verify the required parameter 'recipients' is set
            if (recipients == null)
                throw new ApiException(400, "Missing required parameter 'recipients' when calling EmailApi->GetApiWebSendRest");
            
    
            var localVarPath = "/api/web.send.rest";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (apiKey != null) localVarQueryParams.Add("api_key", Configuration.ApiClient.ParameterToString(apiKey)); // query parameter
            if (fromname != null) localVarQueryParams.Add("fromname", Configuration.ApiClient.ParameterToString(fromname)); // query parameter
            if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (replytoid != null) localVarQueryParams.Add("replytoid", Configuration.ApiClient.ParameterToString(replytoid)); // query parameter
            if (subject != null) localVarQueryParams.Add("subject", Configuration.ApiClient.ParameterToString(subject)); // query parameter
            if (content != null) localVarQueryParams.Add("content", Configuration.ApiClient.ParameterToString(content)); // query parameter
            if (footer != null) localVarQueryParams.Add("footer", Configuration.ApiClient.ParameterToString(footer)); // query parameter
            if (template != null) localVarQueryParams.Add("template", Configuration.ApiClient.ParameterToString(template)); // query parameter
            if (attachmentid != null) localVarQueryParams.Add("attachmentid", Configuration.ApiClient.ParameterToString(attachmentid)); // query parameter
            if (clicktrack != null) localVarQueryParams.Add("clicktrack", Configuration.ApiClient.ParameterToString(clicktrack)); // query parameter
            if (opentrack != null) localVarQueryParams.Add("opentrack", Configuration.ApiClient.ParameterToString(opentrack)); // query parameter
            if (bcc != null) localVarQueryParams.Add("bcc", Configuration.ApiClient.ParameterToString(bcc)); // query parameter
            if (recipients != null) localVarQueryParams.Add("recipients", Configuration.ApiClient.ParameterToString(recipients)); // query parameter
            if (ATT_NAME != null) localVarQueryParams.Add("ATT_NAME", Configuration.ApiClient.ParameterToString(ATT_NAME)); // query parameter
            if (X_APIHEADER != null) localVarQueryParams.Add("X-APIHEADER", Configuration.ApiClient.ParameterToString(X_APIHEADER)); // query parameter
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetApiWebSendRest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetApiWebSendRest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param>
        /// <param name="from">From email address</param>
        /// <param name="subject">Subject of the Email</param>
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param>
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param>
        /// <param name="fromname">Email Sender name (optional)</param>
        /// <param name="replytoid">Reply to email address (optional)</param>
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param>
        /// <param name="template">Email template ID (optional)</param>
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param>
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param>
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param>
        /// <param name="bcc">Email address for bcc (optional)</param>
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param>
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param>
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetApiWebSendRestAsync (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null)
        {
             ApiResponse<Object> localVarResponse = await GetApiWebSendRestAsyncWithHttpInfo(apiKey, from, subject, content, recipients, fromname, replytoid, footer, template, attachmentid, clicktrack, opentrack, bcc, ATT_NAME, X_APIHEADER, tags);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  `Sending Mails` \u2013 This API is used for sending emails. Pepipost supports REST as well JSON formats for the input\n
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">Your API Key</param>
        /// <param name="from">From email address</param>
        /// <param name="subject">Subject of the Email</param>
        /// <param name="content">Email body in html (to use attributes to display dynamic values such as name, account number, etc. for ex. [% NAME %] for ATT_NAME , [% AGE %] for ATT_AGE etc.)</param>
        /// <param name="recipients">Email addresses for recipients (multiple values allowed)</param>
        /// <param name="fromname">Email Sender name (optional)</param>
        /// <param name="replytoid">Reply to email address (optional)</param>
        /// <param name="footer">Set &#39;0&#39; or &#39;1&#39; in order to include footer or not (optional, default to true)</param>
        /// <param name="template">Email template ID (optional)</param>
        /// <param name="attachmentid">specify uploaded attachments id (Multiple attachments are allowed) (optional)</param>
        /// <param name="clicktrack">set \u20180\u2019 or \u20181\u2019 in-order to disable or enable the click-track (optional, default to true)</param>
        /// <param name="opentrack">set open-track value to \u20180\u2019 or \u20181\u2019 in-order to disable or enable (optional, default to true)</param>
        /// <param name="bcc">Email address for bcc (optional)</param>
        /// <param name="ATT_NAME">Specify attributes followed by ATT_ for recipient to personalized email for ex. ATT_NAME for name, ATT_AGE for age etc. (Multiple attributes are allowed) (optional)</param>
        /// <param name="X_APIHEADER">Your defined unique identifier (optional)</param>
        /// <param name="tags">To relate each message. Useful for reports. (optional, default to )</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetApiWebSendRestAsyncWithHttpInfo (string apiKey, string from, string subject, string content, string recipients, string fromname = null, string replytoid = null, bool? footer = null, long? template = null, string attachmentid = null, bool? clicktrack = null, bool? opentrack = null, string bcc = null, string ATT_NAME = null, string X_APIHEADER = null, string tags = null)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling GetApiWebSendRest");
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling GetApiWebSendRest");
            // verify the required parameter 'subject' is set
            if (subject == null) throw new ApiException(400, "Missing required parameter 'subject' when calling GetApiWebSendRest");
            // verify the required parameter 'content' is set
            if (content == null) throw new ApiException(400, "Missing required parameter 'content' when calling GetApiWebSendRest");
            // verify the required parameter 'recipients' is set
            if (recipients == null) throw new ApiException(400, "Missing required parameter 'recipients' when calling GetApiWebSendRest");
            
    
            var localVarPath = "/api/web.send.rest";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (apiKey != null) localVarQueryParams.Add("api_key", Configuration.ApiClient.ParameterToString(apiKey)); // query parameter
            if (fromname != null) localVarQueryParams.Add("fromname", Configuration.ApiClient.ParameterToString(fromname)); // query parameter
            if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (replytoid != null) localVarQueryParams.Add("replytoid", Configuration.ApiClient.ParameterToString(replytoid)); // query parameter
            if (subject != null) localVarQueryParams.Add("subject", Configuration.ApiClient.ParameterToString(subject)); // query parameter
            if (content != null) localVarQueryParams.Add("content", Configuration.ApiClient.ParameterToString(content)); // query parameter
            if (footer != null) localVarQueryParams.Add("footer", Configuration.ApiClient.ParameterToString(footer)); // query parameter
            if (template != null) localVarQueryParams.Add("template", Configuration.ApiClient.ParameterToString(template)); // query parameter
            if (attachmentid != null) localVarQueryParams.Add("attachmentid", Configuration.ApiClient.ParameterToString(attachmentid)); // query parameter
            if (clicktrack != null) localVarQueryParams.Add("clicktrack", Configuration.ApiClient.ParameterToString(clicktrack)); // query parameter
            if (opentrack != null) localVarQueryParams.Add("opentrack", Configuration.ApiClient.ParameterToString(opentrack)); // query parameter
            if (bcc != null) localVarQueryParams.Add("bcc", Configuration.ApiClient.ParameterToString(bcc)); // query parameter
            if (recipients != null) localVarQueryParams.Add("recipients", Configuration.ApiClient.ParameterToString(recipients)); // query parameter
            if (ATT_NAME != null) localVarQueryParams.Add("ATT_NAME", Configuration.ApiClient.ParameterToString(ATT_NAME)); // query parameter
            if (X_APIHEADER != null) localVarQueryParams.Add("X-APIHEADER", Configuration.ApiClient.ParameterToString(X_APIHEADER)); // query parameter
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetApiWebSendRest: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetApiWebSendRest: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
