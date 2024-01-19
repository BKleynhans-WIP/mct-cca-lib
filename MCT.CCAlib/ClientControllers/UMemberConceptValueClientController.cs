using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AutoMapper;

using MCT.CCAlib.Models;
using MCT.CCAlib.Models.ckoltp;
using MCT.CCAlib.Services.IServices;
using MCT.CCAlib.ClientControllers.IClientControllers;

namespace MCT.CCAlib.ClientControllers
{
    /// <summary>
    /// The UMemberConceptValueClientController is used by clients that want to access data from the Managed Care StaticDetails.API
    /// </summary>
    public class UMemberConceptValueClientController : ClientControllerBase<UMemberConceptValueClientController, IUMemberConceptValueService>, IUMemberConceptValueClientController
    {
        public UMemberConceptValueClientController(ILogger<UMemberConceptValueClientController> logger, IUMemberConceptValueService service, IMapper mapper) : base(logger, service, mapper)
        { }

        #region GetMemberConceptValues
        /// <summary>
        /// Calls the GetUMemberConceptValuePrivate method to get UMemberConceptValue information from SQL and parses the data received
        /// </summary>
        /// <param name="cid">CID of a member</param>
        /// <param name="conceptId">Concept ID of a concept in CCA</param>
        /// <returns>UMemberConceptValue</returns>
        public UMemberConceptValue GetUMemberConceptValue(int cid, int conceptId)
        {
            _logger.LogInformation("Requesting UMemberConcept information from CKOLTP through Entity Framework");

            UMemberConceptValue uMemberConceptValue = new();

            try
            {
                var response = GetUMemberConceptValuePrivate(cid, conceptId);

                if (response != null)
                {
                    uMemberConceptValue = JsonConvert.DeserializeObject<UMemberConceptValue>(Convert.ToString(response.Result.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetUMemberConceptValueSync in UMemberConceptValueClientController");
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while deserializing the UMemberConceptValue object in GetUMemberConceptValue in the UMemberConceptValueClient Controller");

                throw;
            }

            return uMemberConceptValue;
        }

        /// <summary>
        /// Retrieves a UMemberConceptValue from SQL based on the information provided
        /// </summary>
        /// <param name="cid">CID of a member</param>
        /// <param name="conceptId">Concept ID of a concept in CCA</param>
        /// <returns></returns>
        private Task<APIResponse> GetUMemberConceptValuePrivate(int cid, int conceptId)
        {
            _logger.LogInformation("Calling GetUMemberConceptValueSync in CCALib");

            try
            {
                return _service.GetUMemberConceptValueSync<APIResponse>(cid, conceptId);
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling the UMemberConceptValueService in GetUMemberConceptValuePrivate in the UMemberConceptValueClient Controller");

                throw;
            }
        }
        #endregion GetMemberConceptValues
    }
}
