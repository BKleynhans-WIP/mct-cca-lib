using System.Threading.Tasks;

using MCT.CCAlib.Models.customModels;

namespace MCT.CCAlib.Services.IServices
{
    public interface IMemberService
    {
        Task<T> GetMemberExternalSync<T>(ExternalMemberIdentifier externalMemberIdentifier);
        Task<T> GetMemberInternalSync<T>(SubscriberIdentifier subscriber);
    }
}