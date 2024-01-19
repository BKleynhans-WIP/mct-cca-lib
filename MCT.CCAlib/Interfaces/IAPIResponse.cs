using System.Collections.Generic;
using System.Net;

namespace MCT.CCAlib.Interfaces
{
    public interface IAPIResponse
    {
        List<string> ErrorMessages { get; set; }
        bool IsSuccess { get; set; }
        object Result { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }
}