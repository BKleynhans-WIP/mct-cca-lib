using MCT.CCAlib.Interfaces.customModels;
using MCT.CCAlib.Models.ckoltp;

namespace MCT.CCAlib.ClientControllers.IClientControllers
{
    public interface IMemberCoverageClientController
    {
        MemberCoverage GetMemberCoverage(ISubscriberIdentifier subscriberIdentifier);
    }
}