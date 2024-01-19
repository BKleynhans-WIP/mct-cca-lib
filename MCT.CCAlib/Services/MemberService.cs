using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

using MCT.CCAlib.Models;
using MCT.CCAlib.Models.customModels;
using MCT.CCAlib.Services.IServices;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Services
{
    /// <summary>
    /// The UMemberConceptValueService provides data from the Member table
    /// </summary>
    public class MemberService : BaseService<MemberService>, IMemberService
    {
        public MemberService(ILogger<MemberService> logger, IHttpClientFactory clientFactory, IConfiguration config) : base(logger, clientFactory, config)
        { }

        /// <summary>
        /// Gets a member object based on the provided External Member ID and External System ID
        /// </summary>
        /// <param name="externalMemberIdentifier"></param>
        /// <returns>APIResult</returns>
        public Task<T> GetMemberExternalSync<T>(ExternalMemberIdentifier externalMemberIdentifier)
        {
            _logger.LogInformation("Requesting Member information from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.GET,
                    Url = _managedCareApiUrl + $"/api/Member/{_sourceUid}/external/{externalMemberIdentifier.ExternalMemberId}/{externalMemberIdentifier.ExternalSystemId}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetMemberExternalSync in the Member Service");

                throw;
            }
        }

        /// <summary>
        /// Gets a member object based on the provided Subscriber ID and Dependent Number
        /// </summary>
        /// <param name="subscriber"></param>
        /// <returns>APIResult</returns>
        public Task<T> GetMemberInternalSync<T>(SubscriberIdentifier subscriber)
        {
            _logger.LogInformation("Requesting Member information from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.GET,
                    Url = _managedCareApiUrl + $"/api/Member/{_sourceUid}/internal/{subscriber.SubscriberId}/{subscriber.DependentNumber}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetMemberInternalSync in the Member Service");

                throw;
            }
        }
    }
}
