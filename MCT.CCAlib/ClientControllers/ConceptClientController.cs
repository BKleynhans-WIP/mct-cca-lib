using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Newtonsoft.Json;

using MCT.CCAlib.ClientControllers.IClientControllers;
using MCT.CCAlib.Interfaces.ckoltp;
using MCT.CCAlib.Interfaces.customModels;
using MCT.CCAlib.Models;
using MCT.CCAlib.Models.ckoltp;
using MCT.CCAlib.Services.IServices;

namespace MCT.CCAlib.ClientControllers
{
    /// <summary>
    /// The ConceptClientController is used by clients that want to access data from the Managed Care StaticDetails.API
    /// </summary>
    public class ConceptClientController : ClientControllerBase<ConceptClientController, IConceptService>, IConceptClientController
    {
        public ConceptClientController(ILogger<ConceptClientController> logger, IConceptService service, IMapper mapper) : base(logger, service, mapper)
        { }

        // TODO: Comments
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberConcept"></param>
        /// <returns></returns>
        #region GetMemberConcept
        public IConcept GetMemberConcept(IMemberConcept memberConcept)
        {
            Concept concept = new();

            try
            {
                var response = GetMemberConceptPrivate(memberConcept);

                if (response != null)
                {
                    concept = JsonConvert.DeserializeObject<Concept>(Convert.ToString(response.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetMemberConcept in ConceptClientController");
                }
            }
            catch (Exception)
            {
                throw;
            }

            return concept;
        }

        // TODO: Comments
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberConcept"></param>
        /// <returns></returns>
        private APIResponse GetMemberConceptPrivate(IMemberConcept memberConcept)
        {
            _logger.LogInformation("Calling GetCommonProcessParamsSync in CCALib");

            try
            {
                var task = Task.Run(() => _service.GetConceptSync<APIResponse>(memberConcept));
                task.Wait();

                return task.Result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion GetMemberConcept

        // TODO: Comments
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberIdentifier"></param>
        /// <param name="concept"></param>
        /// <returns></returns>
        public Task<APIResponse> SetMemberConcept(ISubscriberIdentifier memberIdentifier, IConceptObject concept)
        {
            _logger.LogInformation("Calling SetMemberConceptAsync in CCALib");

            try
            {
                return _service.SetMemberConceptAsync<APIResponse>(memberIdentifier, concept);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // TODO: Comments
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberIdentifier"></param>
        /// <param name="concept"></param>
        /// <returns></returns>
        public Task<APIResponse> ResetMemberConcept(ISubscriberIdentifier memberIdentifier, IConceptObject concept)
        {
            _logger.LogInformation("Calling ResetMemberConceptAsync in CCALib");

            try
            {
                return _service.ResetMemberConceptAsync<APIResponse>(memberIdentifier, concept);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
