using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Interfaces
{
    public interface IAPIRequest
    {
        ApiType ApiType { get; set; }
        object Data { get; set; }
        string Url { get; set; }
    }
}