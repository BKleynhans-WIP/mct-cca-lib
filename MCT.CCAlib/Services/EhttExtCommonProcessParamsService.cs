using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

using MCT.CCAlib.Models;
using MCT.CCAlib.Services.IServices;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Services
{
    /// <summary>
    /// The EhttExtCommonProcessParamsService provides data from the EhttExtCommonProcessParams table
    /// </summary>
    public class EhttExtCommonProcessParamsService : BaseService<EhttExtCommonProcessParamsService>, IEhttExtCommonProcessParamsService
    {
        public EhttExtCommonProcessParamsService(ILogger<EhttExtCommonProcessParamsService> logger, IHttpClientFactory clientFactory, IConfiguration config) : base(logger, clientFactory, config)
        { }

        /// <summary>
        /// Requests all the EhttExtCommonProcessParams from the Managed Care API
        /// </summary>
        /// <returns>APIResult</returns>
        public Task<T> GetCommonProcessParamsSync<T>()
        {
            _logger.LogInformation("Requesting EhttExtCommonProcessParams information from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.GET,
                    Url = _managedCareApiUrl + $"/api/EhttExtCommonProcessParams/{_sourceUid}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetCommonProcessParamsSync in the EhttExtCommonProcessParams Service");

                throw;
            }
        }

        /// <summary>
        /// Requests all the EhttExtCommonProcessParams for a specific process form the Managed Care API
        /// </summary>
        /// <param name="processName">The name of the process to retrieve parameters for</param>
        /// <returns>APIResult</returns>
        public Task<T> GetCommonProcessParamsSync<T>(string processName)
        {
            _logger.LogInformation("Requesting EhttExtCommonProcessParams information from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = _managedCareApiUrl + $"/api/EhttExtCommonProcessParams/{_sourceUid}/{processName}"
            });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetCommonProcessParamsSync in the EhttExtCommonProcessParams Service");

                throw;
            }
        }
    }
}
