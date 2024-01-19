using System.Collections.Generic;

using MCT.CCAlib.Models.customModels;

namespace MCT.CCAlib.ClientControllers.IClientControllers
{
    public interface IGapsInCareClientController
    {
        List<string> GetCidOfMembersWithGapsInCare(List<string> validGapsInCare);
        List<ExternalMemberIdentifier> GetExternalMemberIdOfMembersWithGapsInCare(List<string> validGapsInCare);
        List<SubscriberIdentifier> GetSubscriberIdOfMembersWithGapsInCare(List<string> validGapsInCare);
        MemberConcept GetGapsInCareByCid(string cid, List<string> validGapsInCare);
    }
}