namespace MCT.CCAlib.Interfaces.customModels
{
    public interface ISubscriberIdentifier
    {
#nullable enable
        string? SubscriberId { get; set; }
        string? DependentNumber { get; set; }
        string? SubscriberDependentId { get; }        
#nullable disable
        string ToString();
    }
}