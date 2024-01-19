using System.Collections.Generic;

using MCT.CCAlib.Models.customModels;

namespace MCT.CCAlib.Interfaces.customModels
{
    public interface IMemberConcept
    {
        public int Cid { get; set; }
        ExternalMemberIdentifier ExternalMemberIdentifier { get; set; }
        SubscriberIdentifier SubscriberIdentifier { get; set; }
        List<ConceptObject> Concepts { get; set; }

        string ToString();
    }
}