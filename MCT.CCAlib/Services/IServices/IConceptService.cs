using System.Threading.Tasks;

using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Services.IServices
{
    public interface IConceptService
    {
        Task<T> GetConceptSync<T>(IMemberConcept memberConcept);
        Task<T> SetMemberConceptAsync<T>(ISubscriberIdentifier memberIdentifier, IConceptObject concept);
        Task<T> ResetMemberConceptAsync<T>(ISubscriberIdentifier memberIdentifier, IConceptObject concept);
    }
}
