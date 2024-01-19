using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

using MCT.CCAlib.Interfaces.customModels;
using MCT.CCAlib.Services.IServices;
using MCT.CCAlib.Models;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Services
{
    /// <summary>
    /// The Concept Service is the primary service used to access the Managed Care StaticDetails.API to get concept information
    /// </summary>
    public class ConceptService : BaseService<ConceptService>, IConceptService
    {
        public ConceptService(ILogger<ConceptService> logger, IHttpClientFactory clientFactory, IConfiguration config) : base(logger, clientFactory, config)
        {
        }

        /// <summary>
        /// Connects to the Managed Care API and gets a list of concepts for the supplied member
        /// </summary>
        /// <typeparam name="T">The type of object we expect to get back from the call.</typeparam>
        /// <param name="memberConcept">Variable that contains informatiopn about the member and their concept values</param>
        /// <returns>APIResult</returns>
        public Task<T> GetConceptSync<T>(IMemberConcept memberConcept)
        {
            _logger.LogInformation("Requesting Concept information from the Managed Care API");

            try
            {
                return SendAsyncGetSync<T>(API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.GET,
                    Url = _managedCareApiUrl + $"/api/member/{_sourceUid}" // to be updated
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in GetConceptSync in the Concept Service");

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="memberIdentifier"></param>
        /// <param name="concept"></param>
        /// <returns>APIResult</returns>
        public async Task<T> SetMemberConceptAsync<T>(ISubscriberIdentifier memberIdentifier, IConceptObject concept)
        {
            _logger.LogInformation("Send an UPDATE/SET member concept object to the Managed Care API");

            try
            {
                return await SendAsyncGetAsync<T>(API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.PUT,
                    Data = concept,
                    Url = _managedCareApiUrl + $"/api/Concept/{_sourceUid}/SetMemberConcept/{memberIdentifier.SubscriberId}/{memberIdentifier.DependentNumber}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in SetMemberConceptAsync in the Concept Service");

                throw;
            }
        }

        // TODO: Comments
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="memberIdentifier"></param>
        /// <param name="concept"></param>
        /// <returns>APIResult</returns>
        public Task<T> ResetMemberConceptAsync<T>(ISubscriberIdentifier memberIdentifier, IConceptObject concept)
        {
            _logger.LogInformation("Send a RESET member concept object to the Managed Care API");

            try
            {
                return SendAsyncGetAsync<T>(API.ManagedCareAPI, new APIRequest()
                {
                    ApiType = ApiType.PUT,
                    Data = new ResetConcept(),
                    Url = _managedCareApiUrl + $"/api/Concept/{_sourceUid}/SetMemberConcept/{memberIdentifier.SubscriberId}/{memberIdentifier.DependentNumber}"
                });
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling SendAsyncGetSync in ResetMemberConceptAsync in the Concept Service");

                throw;
            }
        }
    }

    // TODO: Comments
    /// <summary>
    /// 
    /// </summary>
    class ResetConcept
    {
        bool Reset { get; set; } = true;
    }
}
