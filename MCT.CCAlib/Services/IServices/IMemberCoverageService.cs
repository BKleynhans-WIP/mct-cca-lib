using System.Threading.Tasks;

using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Services.IServices
{
    public interface IMemberCoverageService
    {
        Task<T> GetMemberCoverageSync<T>(ISubscriberIdentifier subscriberIdentifier);
    }
}