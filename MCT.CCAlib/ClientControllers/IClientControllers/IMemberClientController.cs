using MCT.CCAlib.Models.ckoltp;
using MCT.CCAlib.Models.customModels;

namespace MCT.CCAlib.ClientControllers.IClientControllers
{
    public interface IMemberClientController
    {
        Member GetMember(ExternalMemberIdentifier externalMemberIdentifier);
    }
}