using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AutoMapper;

using MCT.CCAlib.ClientControllers.IClientControllers;
using MCT.CCAlib.Models;
using MCT.CCAlib.Models.ckoltp;
using MCT.CCAlib.Models.customModels;
using MCT.CCAlib.Services.IServices;

namespace MCT.CCAlib.ClientControllers
{
    /// <summary>
    /// The MemberClientController is used by clients that want to access data from the Managed Care StaticDetails.API
    /// </summary>
    public class MemberClientController : ClientControllerBase<MemberClientController, IMemberService>, IMemberClientController
    {
        public MemberClientController(ILogger<MemberClientController> logger, IMemberService service, IMapper mapper) : base(logger, service, mapper)
        { }

        #region GetMember
        /// <summary>
        /// Calls the GetMemberPrivate method to get Member information from SQL and parses the data received
        /// </summary>
        /// <param name="externalMemberIdentifier"></param>
        /// <returns>Member</returns>
        public Member GetMember(ExternalMemberIdentifier externalMemberIdentifier)
        {
            _logger.LogInformation("Requesting Member information from CKOLTP through Entity Framework");

            Member member = new();

            try
            {
                var response = GetMemberPrivate(externalMemberIdentifier);

                if (response != null)
                {
                    member = JsonConvert.DeserializeObject<Member>(Convert.ToString(response.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetMember in MemberClientController");
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while deserializing the Member object in GetMember in the MemberClient Controller");

                throw;
            }

            return member;
        }

        /// <summary>
        /// Retrieves a Member from SQL based on the information provided
        /// </summary>
        /// <param name="externalMemberIdentifier"></param>
        /// <returns></returns>
        private APIResponse GetMemberPrivate(ExternalMemberIdentifier externalMemberIdentifier)
        {
            _logger.LogInformation("Calling GetMemberExternalSync in CCALib");

            try
            {
                var task = Task.Run(() => _service.GetMemberExternalSync<APIResponse>(externalMemberIdentifier));
                task.Wait();

                return task.Result;
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling the MemberService in GetMemberPrivate in the MemberClient Controller");

                throw;
            }
        }
        #endregion GetMember
    }
}
