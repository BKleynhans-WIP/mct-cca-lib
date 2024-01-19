using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AutoMapper;

using MCT.CCAlib.ClientControllers.IClientControllers;
using MCT.CCAlib.Models;
using MCT.CCAlib.Models.customModels;
using MCT.CCAlib.Services.IServices;

namespace MCT.CCAlib.ClientControllers
{
    /// <summary>
    /// The GapsInCareClientController is used by clients that want to access data from the Managed Care StaticDetails.API
    /// </summary>
    public class GapsInCareClientController : ClientControllerBase<GapsInCareClientController, IGapsInCareService>, IGapsInCareClientController
    {
        public GapsInCareClientController(ILogger<GapsInCareClientController> logger, IGapsInCareService service, IMapper mapper) : base(logger, service, mapper)
        { }

        #region GetCidOfMembersWithGapsInCare
        /// <summary>
        /// Calls the GetCidOfMembersWithGapsInCarePrivate method to get a 
        /// list of Members that have the provided list of Gaps in Care from SQL and parses the data received
        /// </summary>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        public List<string> GetCidOfMembersWithGapsInCare(List<string> validGapsInCare)
        {
            _logger.LogInformation("Requesting the list of membes with active Gaps in Care " +
                "from CKOLTP through Entity Framework");

            List<string> list = new();
            
            try
            {                
                var response = GetCidOfMembersWithGapsInCarePrivate(validGapsInCare);

                if (response != null && response.IsSuccess)
                {
                    list = JsonConvert.DeserializeObject<List<string>>(Convert.ToString(response.Result));
                }
                else
                {
                    throw new Exception(
                        string.Format("No data returned from GetCidOfMembersWithGapsInCare in " +
                            "GapsInCareClientController - response : {response}",
                            response.ToString()
                        )
                    );
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while deserializing the List<string> " +
                    "object in GetCidOfMembersWithGapsInCare in the GapsInCareClient Controller");

                throw;
            }

            return list;
        }

        /// <summary>
        /// Retrieves a list of CIDs for members from SQL based on the information provided
        /// </summary>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        private APIResponse GetCidOfMembersWithGapsInCarePrivate(List<string> validGapsInCare)
        {
            _logger.LogInformation("Calling GetCidOfMembersWithGapsInCareSync in CCALib");

            try
            {
                var task = Task.Run(() => _service.GetCidOfMembersWithGapsInCareSync<APIResponse>(validGapsInCare));
                task.Wait();
                
                return task.Result;
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling the GapsInCareService in " +
                    "GetCidOfMembersWithGapsInCarePrivate in the GapsInCareClient Controller");

                throw;
            }
        }
        #endregion GetCidOfMembersWithGapsInCare

        #region GetExternalMemberIdMembersWithGapsIncare
        /// <summary>
        /// Calls the GetExternalMemberIdOfMembersWithGapsInCarePrivate method to get a list of Members that have the 
        /// provided list of Gaps in Care from SQL and parses the data received
        /// </summary>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        public List<ExternalMemberIdentifier> GetExternalMemberIdOfMembersWithGapsInCare(List<string> validGapsInCare)
        {
            _logger.LogInformation("Requesting the list of External Member IDs of members " +
                "with active Gaps in Care from CKOLTP through Entity Framework");

            List<ExternalMemberIdentifier> list = new();

            try
            {                
                var response = GetExternalMemberIdOfMembersWithGapsInCarePrivate(validGapsInCare);

                if (response != null && response.IsSuccess)
                {
                    list = JsonConvert.DeserializeObject<List<ExternalMemberIdentifier>>(Convert.ToString(response.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetExternalMemberIdOfMembersWithGapsInCare " +
                        "in GapsInCareClientController");
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while deserializing the List<ExternalMemberIdentifier> object " +
                    "in GetExternalMemberIdOfMembersWithGapsInCare in the GapsInCareClient Controller");

                throw;
            }

            return list;
        }

        /// <summary>
        /// Retrieves a UMemberConceptValue from SQL based on the information provided
        /// </summary>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        private APIResponse GetExternalMemberIdOfMembersWithGapsInCarePrivate(List<string> validGapsInCare)
        {
            _logger.LogInformation("Calling GetExternalMemberIdOfMembersWithGapsInCareSync in CCALib");

            try
            {
                var task = Task.Run(() => _service.GetExternalMemberIdOfMembersWithGapsInCareSync<APIResponse>(validGapsInCare));
                task.Wait();

                return task.Result;
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling the GapsInCareService in " +
                    "GetUMemberConceptValuePrivate in the GapsInCareClient Controller");

                throw;
            }
        }
        #endregion GetExternalMemberIdMembersWithGapsIncare

        #region GetSubscriberIdOfMembersWithGapsInCare
        // TODO: Comments
        /// <summary>
        /// Calls the GetCidOfMembersWithGapsInCarePrivate method to get a list of Members 
        /// that have the provided list of Gaps in Care from SQL and parses the data received
        /// </summary>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        public List<SubscriberIdentifier> GetSubscriberIdOfMembersWithGapsInCare(List<string> validGapsInCare)
        {
            List<SubscriberIdentifier> list = new();

            try
            {                
                var response = GetSubscriberIdOfMembersWithGapsInCarePrivate(validGapsInCare);

                if (response != null && response.IsSuccess)
                {
                    list = JsonConvert.DeserializeObject<List<SubscriberIdentifier>>(Convert.ToString(response.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetSubscriberIdOfMembersWithGapsInCare " +
                        "in GapsInCareClientController");
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while deserializing the List<string> object" +
                    " in GetCidOfMembersWithGapsInCare in the GapsInCareClient Controller");

                throw;
            }            

            return list;
        }

        // TODO: Comments
        /// <summary>
        /// Retrieves a UMemberConceptValue from SQL based on the information provided
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        private APIResponse GetSubscriberIdOfMembersWithGapsInCarePrivate(List<string> validGapsInCare)
        {
            _logger.LogInformation("Calling GetSubscriberIdOfMembersWithGapsInCareSync in CCALib");

            try
            {
                var task = Task.Run(() => _service.GetSubscriberIdOfMembersWithGapsInCareSync<APIResponse>(validGapsInCare));
                task.Wait();

                return task.Result;
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling the GapsInCareService in " +
                    "GetUMemberConceptValuePrivate in the GapsInCareClient Controller");

                throw;
            }
        }
        #endregion GetSubscriberIdOfMembersWithGapsInCare

        #region GetGapsInCareByCid
        // TODO: Comments
        /// <summary>
        /// Calls the GetCidOfMembersWithGapsInCarePrivate method to get a list of Members
        /// that have the provided list of Gaps in Care from SQL and parses the data received
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        public MemberConcept GetGapsInCareByCid(string cid, List<string> validGapsInCare)
        {
            MemberConcept memberConcept = new();

            try
            {                
                var response = GetGapsInCareByCidPrivate(cid, validGapsInCare);

                if (response != null && response.IsSuccess)
                {
                    memberConcept = JsonConvert.DeserializeObject<MemberConcept>(Convert.ToString(response.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetGapsInCareByCid in GapsInCareClientController");
                }
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while deserializing the List<string> object in " +
                    "GetCidOfMembersWithGapsInCare in the GapsInCareClient Controller");

                throw;
            }

            return memberConcept;
        }

        // TODO: Comments
        /// <summary>
        /// Retrieves a UMemberConceptValue from SQL based on the information provided
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="validGapsInCare"></param>
        /// <returns></returns>
        private APIResponse GetGapsInCareByCidPrivate(string cid, List<string> validGapsInCare)
        {
            _logger.LogInformation("Calling GetGapsInCareByCidSync in CCALib");

            try
            {
                var task = Task.Run(() => _service.GetGapsInCareByCidSync<APIResponse>(cid, validGapsInCare));
                task.Wait();

                return task.Result;
            }
            catch (Exception)
            {
                _logger.LogError("An error occurred while calling the GapsInCareService in " +
                    "GetUMemberConceptValuePrivate in the GapsInCareClient Controller");

                throw;
            }
        }
        #endregion GetGapsInCareByCid
    }
}
