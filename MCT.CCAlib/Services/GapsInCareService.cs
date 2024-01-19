using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using MCT.CCAlib.Models;
using MCT.CCAlib.Services.IServices;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Services
{
    /// <summary>
    /// The GapsInCareService provides data based on queries defined in the StaticDetails.API -- comment
    /// </summary>
    public class GapsInCareService : BaseService<GapsInCareService>, IGapsInCareService
    {
        public GapsInCareService(ILogger<GapsInCareService> logger, IHttpClientFactory clientFactory, IConfiguration config) : base(logger, clientFactory, config)
        { }

        /// <summary>
        /// Get a list of CIDs for all members that have the provided list of Gaps in Care
        /// </summary>
        /// <param name="validGapsInCare">List of Valid Gaps in Care to query for</param>
        /// <returns>APIResult</returns>
        public Task<T> GetCidOfMembersWithGapsInCareSync<T>(List<string> validGapsInCare)
        {
            _logger.LogInformation("Requesting CIDs of members with Gaps in Care from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.POST,
                    Data = validGapsInCare,
                    Url = _managedCareApiUrl + $"/api/GapsInCare/{_sourceUid}/Cid/OfMembersWithGapsInCare"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetCidOfMembersWithGapsInCareSync in the GapsInCare Service");

                throw;
            }
        }

        /// <summary>
        /// Get the External Member ID of the member that has the provided list of Gaps in Care
        /// </summary>
        /// <param name="validGapsInCare">List of Valid Gaps in Care to consider</param>
        /// <returns>APIResult</returns>
        public Task<T> GetExternalMemberIdOfMembersWithGapsInCareSync<T>(List<string> validGapsInCare)
        {
            _logger.LogInformation("Requesting External Member IDs of members with Gaps in Care from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.POST,
                    Data = validGapsInCare,
                    Url = _managedCareApiUrl + $"/api/GapsInCare/{_sourceUid}/ExternalMemberId/{validGapsInCare}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetExternalMemberIdOfMembersWithGapsInCareSync in the GapsInCare Service");

                throw;
            }
        }

        /// <summary>
        /// Get the Subcriber ID of the member that has the provided list of Gaps in Care
        /// </summary>
        /// <param name="validGapsInCare">List of Valid Gaps in Care to consider</param>
        /// <returns>APIResult</returns>
        public Task<T> GetSubscriberIdOfMembersWithGapsInCareSync<T>(List<string> validGapsInCare)
        {
            _logger.LogInformation("Requesting Subscriber IDs of members with Gaps in Care from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.POST,
                    Data = validGapsInCare,
                    Url = _managedCareApiUrl + $"/api/GapsInCare/{_sourceUid}/SubscriberId/{validGapsInCare}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetSubscriberIdOfMembersWithGapsInCareSync in the GapsInCare Service");

                throw;
            }
        }

        /// <summary>
        /// Get the provided list of Gaps in Care for a specific member
        /// </summary>
        /// <param name="cid">CID of a member</param>
        /// <param name="validGapsInCare">List of Valid Gaps in Care to consider</param>
        /// <returns>APIResult</returns>
        public Task<T> GetGapsInCareByCidSync<T>(string cid, List<string> validGapsInCare)
        {
            _logger.LogInformation("Requesting all the Gaps in Care for a specific combination of CID and valid gaps in carefrom the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.POST,
                    Data = validGapsInCare,
                    Url = _managedCareApiUrl + $"/api/GapsInCare/{_sourceUid}/GapsInCareByCid/{cid}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetGapsInCareByCidSync in the GapsInCare Service");

                throw;
            }
        }
    }
}
