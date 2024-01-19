using System.Collections.Generic;
using System.Net;

using MCT.CCAlib.Interfaces;

namespace MCT.CCAlib.Models
{
    public class APIResponse : IAPIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
