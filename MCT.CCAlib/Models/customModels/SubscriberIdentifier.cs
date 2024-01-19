using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Models.customModels
{
    public class SubscriberIdentifier : ISubscriberIdentifier
    {
#nullable enable
        public string? SubscriberId { get; set; } = null;
        public string? DependentNumber { get; set; } = null;
        public string? SubscriberDependentId
        {
            get
            {
                if (SubscriberId == null || DependentNumber == null)
                    return null;
                else
                    return $"{SubscriberId}-{DependentNumber}";
            }
        }
#nullable disable

        public override string ToString()
        {
            return string.Format($"Subscriber and Dependent Number {SubscriberDependentId,50}\n");
        }
    }
}
