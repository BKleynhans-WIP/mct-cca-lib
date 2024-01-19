using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AutoMapper;

using MCT.CCAlib.ClientControllers.IClientControllers;
using MCT.CCAlib.Interfaces.customModels;
using MCT.CCAlib.Models;
using MCT.CCAlib.Models.ckoltp;
using MCT.CCAlib.Services.IServices;

namespace MCT.CCAlib.ClientControllers
{
    /// <summary>
    /// The MemberCoverageClientController is used by clients that want to access data from the Managed Care StaticDetails.API
    /// </summary>
    public class MemberCoverageClientController : ClientControllerBase<MemberCoverageClientController, IMemberCoverageService>, IMemberCoverageClientController
    {
        public MemberCoverageClientController(ILogger<MemberCoverageClientController> logger, IMemberCoverageService service, IMapper mapper) : base(logger, service, mapper)
        { }

        #region GetMemberCoverage
        /// <summary>
        /// Calls the GetMemberCoveragePrivate method to get MemberCoverage information from SQL and parses the data received
        /// </summary>
        /// <param name="subscriberIdentifier">Object containing information about a subscriber</param>
        /// <returns></returns>
        public MemberCoverage GetMemberCoverage(ISubscriberIdentifier subscriberIdentifier)
        {
            _logger.LogInformation("Requesting UMemberConcept information from CKOLTP through Entity Framework");

            MemberCoverage memberCoverage = new();

            try
            {
                var response = GetMemberCoveragePrivate(subscriberIdentifier);

                if (response != null)
                {
                    memberCoverage = JsonConvert.DeserializeObject<MemberCoverage>(Convert.ToString(response.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetMemberCoverage in MemberCoverageClientController");
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while deserializing the MemberCoverage object in GetMemberCoverage in the MemberCoverageClient Controller");

                throw;
            }

            return memberCoverage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subscriberIdentifier"></param>
        /// <returns></returns>
        private APIResponse GetMemberCoveragePrivate(ISubscriberIdentifier subscriberIdentifier)
        {
            _logger.LogInformation("Calling GetCommonProcessParamsSync in CCALib");

            try
            {
                var task = Task.Run(() => _service.GetMemberCoverageSync<APIResponse>(subscriberIdentifier));
                task.Wait();

                return task.Result;
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling the MemberCoverageService in GetMemberCoveragePrivate in the MemberCoverageClient Controller");

                throw;
            }
        }
        #endregion GetMemberCoverage
    }
}
