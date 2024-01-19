using System.Collections.Generic;

using MCT.CCAlib.Models.customdb.dto;

namespace MCT.CCAlib.ClientControllers.IClientControllers
{
    public interface IEhttExtCommonProcessParamsClientController
    {
        List<EhttExtCommonProcessParamDTO> GetCommonProcessParams(string processName);
    }
}