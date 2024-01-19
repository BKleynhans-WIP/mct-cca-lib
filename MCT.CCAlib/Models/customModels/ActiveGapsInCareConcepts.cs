using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Models.customModels
{
    public class ActiveGapsInCareConcepts : IActiveGapsInCareConcepts
    {
#nullable enable
        public int? Cid { get; set; }
        public string? SubscriberId { get; set; }
        public int? SubscriberSuffix { get; set; }
        public int? ConceptId { get; set; }
#nullable disable
    }
}
