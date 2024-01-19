using System.Collections.Generic;

using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Models.customModels
{
    public class MemberConcept : IMemberConcept
    {
        public int Cid { get; set; }
        public ExternalMemberIdentifier ExternalMemberIdentifier { get; set; }
        public SubscriberIdentifier SubscriberIdentifier { get; set; }
        public List<ConceptObject> Concepts { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
