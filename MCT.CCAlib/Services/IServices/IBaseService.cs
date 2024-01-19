using System.Net.Http;
using System.Threading.Tasks;

using MCT.CCAlib.Models;
using static MCT.CCAlib.StaticDetails;

namespace MCT.CCAlib.Services.IServices
{
    public interface IBaseService
    {
        APIResponse ResponseModel { get; set; }
        IHttpClientFactory HttpClient { get; set; }
        
        Task<T> SendAsyncGetSync<T>(API api, APIRequest apiRequest);
    }
}
