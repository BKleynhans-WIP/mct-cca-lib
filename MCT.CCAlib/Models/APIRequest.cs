using MCT.CCAlib.Interfaces;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Models
{
    public class APIRequest : IAPIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
