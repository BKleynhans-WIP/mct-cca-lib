using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

using MCT.CCAlib.Interfaces.customModels;
using MCT.CCAlib.Models;
using MCT.CCAlib.Services.IServices;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Services
{
    /// <summary>
    /// The MemberCoverageService provides data from the MemberCoverage table
    /// </summary>
    public class MemberCoverageService : BaseService<MemberCoverageService>, IMemberCoverageService
    {
        public MemberCoverageService(ILogger<MemberCoverageService> logger, IHttpClientFactory clientFactory, IConfiguration config) : base(logger, clientFactory, config)
        { }

        /// <summary>
        /// Get the member coverage for the supplied subscriber
        /// </summary>
        /// <param name="subscriberIdentifier">Subscriber ID and Dependent Number of a member to query</param>
        /// <returns>APIResult</returns>
        public Task<T> GetMemberCoverageSync<T>(ISubscriberIdentifier subscriberIdentifier)
        {
            _logger.LogInformation("Requesting Member Coverage information from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.PUT,
                    Data = subscriberIdentifier,
                    Url = _managedCareApiUrl + $"api/MemberCoverage/{_sourceUid}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetMemberCoverageSync in the MemberCoverage Service");

                throw;
            }
        }
    }
}
