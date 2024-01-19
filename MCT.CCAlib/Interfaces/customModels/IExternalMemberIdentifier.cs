namespace MCT.CCAlib.Interfaces.customModels
{
    public interface IExternalMemberIdentifier
    {
#nullable enable
        string? ExternalSystemId { get; set; }
        string? ExternalMemberId { get; set; }        
        string? ExternalSystemMemberId { get; }
#nullable disable
        string ToString();
    }
}