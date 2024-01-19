using System.Collections.Generic;
using System.Threading.Tasks;

namespace MCT.CCAlib.Services.IServices
{
    public interface IGapsInCareService
    {
        Task<T> GetCidOfMembersWithGapsInCareSync<T>(List<string> validGapsInCare);
        Task<T> GetExternalMemberIdOfMembersWithGapsInCareSync<T>(List<string> validGapsInCare);
        Task<T> GetSubscriberIdOfMembersWithGapsInCareSync<T>(List<string> validGapsInCare);
        Task<T> GetGapsInCareByCidSync<T>(string cid, List<string> validGapsInCare);
    }
}