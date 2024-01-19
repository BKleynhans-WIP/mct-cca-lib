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
    /// The UMemberConceptValueService provides data from the UMemberConceptValue table
    /// </summary>
    public class UMemberConceptValueService : BaseService<UMemberConceptValueService>, IUMemberConceptValueService
    {
        public UMemberConceptValueService(ILogger<UMemberConceptValueService> logger, IHttpClientFactory clientFactory, IConfiguration config) : base(logger, clientFactory, config)
        { }

        /// <summary>
        /// Requests UMemberConceptValue information from the Managed Care API
        /// </summary>
        /// <param name="cid">CID of a member</param>
        /// <param name="conceptId">Concept ID we are requesting data for</param>
        /// <returns>APIResult</returns>
        public Task<T> GetUMemberConceptValueSync<T>(int cid, int conceptId)
        {
            _logger.LogInformation("Requesting UMemberConceptValue information from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(StaticDetails.API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.GET,
                    Url = _managedCareApiUrl + $"/api/UMemberConceptValues/{_sourceUid}/{cid}/{conceptId}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetUMemberConceptValueSync in the UMemberConceptValue Service");

                throw;
            }
        }
    }
}
