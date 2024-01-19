using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Models.customModels
{
    public class ExternalMemberIdentifier : IExternalMemberIdentifier
    {
#nullable enable
        public string? ExternalSystemId { get; set; } = null;
        public string? ExternalMemberId { get; set; } = null;
        public string? ExternalSystemMemberId
        {
            get
            {
                if (ExternalSystemId == null || ExternalMemberId == null)
                    return null;
                else
                    return $"{ExternalSystemId}-{ExternalMemberId}";
            }
        }
#nullable disable

        public override string ToString()
        {
            return string.Format($"External System and Member ID {ExternalSystemMemberId,50}\n");
        }
    }
}
