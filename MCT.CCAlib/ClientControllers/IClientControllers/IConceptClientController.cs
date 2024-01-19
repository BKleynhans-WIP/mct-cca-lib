using System.Threading.Tasks;

using MCT.CCAlib.Interfaces.ckoltp;
using MCT.CCAlib.Interfaces.customModels;
using MCT.CCAlib.Models;

namespace MCT.CCAlib.ClientControllers.IClientControllers
{
    public interface IConceptClientController
    {
        IConcept GetMemberConcept(IMemberConcept memberConcept);
        Task<APIResponse> SetMemberConcept(ISubscriberIdentifier memberIdentifier, IConceptObject concept);
        Task<APIResponse> ResetMemberConcept(ISubscriberIdentifier memberIdentifier, IConceptObject concept);
    }
}