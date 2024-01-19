using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AutoMapper;

using MCT.CCAlib.ClientControllers.IClientControllers;
using MCT.CCAlib.Models;
using MCT.CCAlib.Models.customdb.dto;
using MCT.CCAlib.Services.IServices;

namespace MCT.CCAlib.ClientControllers
{
    /// <summary>
    /// The EhttExtCommonProcessParamsClientController is used by clients that want to access data from the Managed Care StaticDetails.API
    /// </summary>
    public class EhttExtCommonProcessParamsClientController : ClientControllerBase<EhttExtCommonProcessParamsClientController, IEhttExtCommonProcessParamsService>, IEhttExtCommonProcessParamsClientController
    {
        public EhttExtCommonProcessParamsClientController(ILogger<EhttExtCommonProcessParamsClientController> logger, IEhttExtCommonProcessParamsService service, IMapper mapper) : base (logger, service, mapper)
        { }

        #region GetProcessParams
        // TODO: Comments
        /// <summary>
        /// 
        /// </summary>
        /// <param name="processName"></param>
        /// <returns></returns>
        public List<EhttExtCommonProcessParamDTO> GetCommonProcessParams(string processName)
        {
            List<EhttExtCommonProcessParamDTO> list = new();

            try
            {
                _logger.LogInformation("Calling GetCommonProcessParamsPrivate with process name {processName}", processName);
                var response = GetCommonProcessParamsPrivate(processName);

                if (response != null)
                {   
                    return JsonConvert.DeserializeObject<List<EhttExtCommonProcessParamDTO>>(Convert.ToString(response.Result.Result));
                }
                else
                {
                    throw new Exception("No data returned from GetCommonProcessParams in EhttExtCommonProcessParamsClientController");
                }
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
        /// <param name="processName"></param>
        /// <returns></returns>
        private Task<APIResponse> GetCommonProcessParamsPrivate(string processName)
        {
            _logger.LogInformation("Calling GetCommonProcessParamsSync in CCALib");

            try
            {
                return _service.GetCommonProcessParamsSync<APIResponse>(processName);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion GetProcessParams
    }
}
