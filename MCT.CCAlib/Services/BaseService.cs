using System;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using MCT.CCAlib.Services.IServices;
using MCT.CCAlib.Models;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Services
{
    /// <summary>
    /// This is the base service used by all services for sending data to and receiving data
    /// from any API used by the various systems.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseService<T> : IBaseService where T : class
    {
        private readonly int _httpClientTimeout;
        private readonly int _apiThreadCount;
        private static SemaphoreSlim _semaphoreSlim;

        private readonly IConfiguration _config;        

        protected readonly ILogger<T> _logger;

        protected string _managedCareApiUrl;
        protected string _managedCareAcceptHeader;

        protected string _ampiApiUrl;
        protected string _ampiAcceptHeader;
        protected string _ampiClientId;
        protected string _ampiClientSecret;

        protected string _sourceUid;

        public APIResponse ResponseModel { get; set; }
        public IHttpClientFactory HttpClient { get; set; }

        public BaseService(ILogger<T> logger, IHttpClientFactory httpClient, IConfiguration config)
        {
            this.ResponseModel = new();
            this.HttpClient = httpClient;

            _config = config;
            _logger = logger;

            _httpClientTimeout = int.Parse(config.GetValue<string>("HttpClientTimeoutInSeconds"));
            _apiThreadCount = int.Parse(config.GetValue<string>("ApiThreadCount"));

            _managedCareApiUrl = config.GetValue<string>("ServicesURLs:ManagedCareAPI:Path");
            _managedCareAcceptHeader = config.GetValue<string>("ServicesURLs:ManagedCareAPI:Headers:Accept");

            _ampiApiUrl = _config.GetValue<string>("ServicesURLs:AmpiAPI:Path");
            _ampiAcceptHeader = _config.GetValue<string>("ServicesURLs:AmpiAPI:Headers:Accept");
            _ampiClientId = _config.GetValue<string>("ServicesURLs:AmpiAPI:Headers:x-ibm-client-id");
            _ampiClientSecret = _config.GetValue<string>("ServicesURLs:AmpiAPI:Headers:x-ibm-client-secret");

            _sourceUid = config.GetValue<string>("SourceUid");

            Initialize();
        }

        private void Initialize()
        {
            _semaphoreSlim = new SemaphoreSlim(_apiThreadCount);
        }

        /// <summary>
        /// Send request Async and then wait Sync for the result before continuing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="api"></param>
        /// <param name="apiRequest"></param>
        /// <returns></returns>
        public async Task<T> SendAsyncGetSync<T>(StaticDetails.API api, APIRequest apiRequest)
        {
            _logger.LogInformation("Attempting to Send Data Synchronously and retrieve the response Asynchronously in SendAsyngGetSync in the Base Service");

            try
            {
                SetJsonConvertDefaultSettings();

                var client = HttpClient.CreateClient("ManagedCareAPI");
                client.Timeout = TimeSpan.FromSeconds(_httpClientTimeout);
                HttpRequestMessage message = new();

                // We require different headers for the different StaticDetails.API services
                message = SetMessageHeaders(message, api);

                message.RequestUri = new Uri(apiRequest.Url);
                message.Content = GetMessageContent(apiRequest);
                message.Method = GetHttpMethod(apiRequest);

                HttpResponseMessage apiResponse = null;

                apiResponse = await client.SendAsync(message);

                var task = Task.Run(() => apiResponse.Content.ReadAsStringAsync());
                task.Wait();

                if (IsTimeout(apiResponse.StatusCode))
                    throw new TimeoutException();                

                var APIResponse = JsonConvert.DeserializeObject<T>(task.Result);

                _logger.LogInformation("Response received for request {req}, returning to calling solution", apiRequest?.ToString());

                return APIResponse;
            }
            catch (Exception e)
            {
                var dto = new APIResponse
                {
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };

                var res = JsonConvert.SerializeObject(dto);
                var APIResponse = JsonConvert.DeserializeObject<T>(res);

                _logger.LogError("An error occured while trying to get a response for message {request}", apiRequest?.ToString());

                return APIResponse;
            }
        }

        /// <summary>
        /// Send a request Async and receive response Async.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="api"></param>
        /// <param name="apiRequest"></param>
        /// <returns></returns>
        public async Task<T> SendAsyncGetAsync<T>(StaticDetails.API api, APIRequest apiRequest)
        {
            _logger.LogInformation("Attempting to Send Data Aynchronously and retrieve the response Asynchronously in SendAsyncGetAsync in the Base Service");

            try
            {
                SetJsonConvertDefaultSettings();

                var client = HttpClient.CreateClient("ManagedCareAPI");
                client.Timeout = TimeSpan.FromSeconds(_httpClientTimeout);
                HttpRequestMessage message = new();

                // We require different headers for the different StaticDetails.API services
                message = SetMessageHeaders(message, api);

                message.RequestUri = new Uri(apiRequest.Url);
                message.Content = GetMessageContent(apiRequest);
                message.Method = GetHttpMethod(apiRequest);

                HttpResponseMessage apiResponse = null;

                var result = await Task.Run(async () =>
                {
                    await _semaphoreSlim.WaitAsync();

                    try
                    {
                        _logger.LogInformation("SendAsyncGetAsync request {req}", apiRequest?.ToString());

                        apiResponse = await client.SendAsync(message);
                        return apiResponse.Content.ReadAsStringAsync().Result;
                    }
                    finally
                    {
                        _semaphoreSlim.Release();
                    }
                });

                if (IsTimeout(apiResponse.StatusCode))
                    throw new TimeoutException();

                var APIResponse = JsonConvert.DeserializeObject<T>(result);

                _logger.LogInformation("Response received for request {req}, returning to calling solution", apiRequest?.ToString());

                return APIResponse;
            }
            catch (Exception e)
            {
                var dto = new APIResponse
                {
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };

                var res = JsonConvert.SerializeObject(dto);
                var APIResponse = JsonConvert.DeserializeObject<T>(res);

                _logger.LogError("An error occured while trying to get a response for request {content}", apiRequest?.ToString());

                return APIResponse;
            }
        }

        /// <summary>
        /// Set the headers to be used for the different APIs we utilize
        /// </summary>
        /// <param name="message"></param>
        /// <param name="api"></param>
        /// <returns></returns>
        private HttpRequestMessage SetMessageHeaders(HttpRequestMessage message, StaticDetails.API api)
        {
            _logger.LogInformation("Attempting to set the message headers in SetMessageHeaders in the Base Service");

            try
            {
                if (api == StaticDetails.API.AmpiAPI)
                {
                    message.Headers.Add("Accept", _ampiAcceptHeader);
                    message.Headers.Add("x-ibm-client-id", _ampiClientId);
                    message.Headers.Add("x-ibm-client-secret", _ampiClientSecret);
                }
                else if (api == StaticDetails.API.ManagedCareAPI)
                {
                    message.Headers.Add("Accept", _managedCareAcceptHeader);
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while setting the headers in GetMessageHeaders in the Base Service");

                throw;
            }

            return message;
        }

        /// <summary>
        /// Update the default settings of Newtonsoft.Json to use camel case when doing JSON serialization/deserialization
        /// </summary>
        private void SetJsonConvertDefaultSettings()
        {
            _logger.LogInformation("Attempting to set json convert default settings in SetJsonConvertDefaultSettings in the Base Service");

            try
            {
                // settings will automatically be used by JsonConvert.SerializeObject/DeserializeObject
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while setting the DefaultSettings for JsonConvert in SetJsonConvertDefaultSettings in the Base Service");

                throw;
            }
        }

#nullable enable
        /// <summary>
        /// Evaluates the APIRequest and extracts the message content
        /// </summary>
        /// <param name="apiRequest"></param>
        /// <returns></returns>
        private HttpContent? GetMessageContent(APIRequest apiRequest)
        {
            _logger.LogInformation("Attempting to retrieve the message content in GetMessageContent in the Base Service");

            try
            {
                if (apiRequest.Data != null)
                {
                    return new StringContent(
                        JsonConvert.SerializeObject(
                            apiRequest.Data,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            }
                        ),
                        Encoding.UTF8,
                        "application/json"
                    );
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while serializing the object in GetMessageContent in the Base Service");

                throw;
            }

            return null;
        }
#nullable disable

        /// <summary>
        /// Evaluates the APIRequest and determines what type of StaticDetails.API call to use
        /// </summary>
        /// <param name="apiRequest"></param>
        /// <returns></returns>
        private HttpMethod GetHttpMethod(APIRequest apiRequest)
        {
            _logger.LogInformation("Attempting to retrieve the HTTP Type (GET/PUT/POST) in GetHttpMethod in the Base Service");

            try
            {
                switch (apiRequest.ApiType)
                {
                    case ApiType.POST:
                        return HttpMethod.Post;
                    case ApiType.PUT:
                        return HttpMethod.Put;
                    case ApiType.DELETE:
                        return HttpMethod.Delete;
                    default:
                        return HttpMethod.Get;
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while determining the HTTP Method in GetHttpMethod in the Base Service");

                throw;
            }
        }

        /// <summary>
        /// Evaluates the HttpStatusCode and returns true or false on whether the code is for a timeout
        /// </summary>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        private bool IsTimeout(HttpStatusCode statusCode)
        {
            switch (statusCode)
            {
                case HttpStatusCode.RequestTimeout: // 408
                case HttpStatusCode.GatewayTimeout: // 504
                    return true;
                default:
                    return false;
            }
        }
    }
}
