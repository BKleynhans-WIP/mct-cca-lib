using System;

namespace MCT.CCAlib.Interfaces.ckoltp
{
    public interface IMemberCoverage
    {
        int Cid { get; set; }
        byte[] DbRowVersion { get; set; }
        DateTime EffectiveDate { get; set; }
        string GroupCk { get; set; }
        string GroupId { get; set; }
        string GroupName { get; set; }
        int Id { get; set; }
        bool IsEligible { get; set; }
        bool IsPrimary { get; set; }
        Guid? MetadataGuid { get; set; }
        DateTime? OrigEffectiveDate { get; set; }
        int? Relationship { get; set; }
        DateTime? SourceDate { get; set; }
        string SourceDetail { get; set; }
        string SourceId { get; set; }
        bool? SsisInsert { get; set; }
        bool? SsisRecalculateDates { get; set; }
        bool? SsisUpdate { get; set; }
        string SubscriberId { get; set; }
        int? SubscriberSuffix { get; set; }
        DateTime? TermDate { get; set; }
        string VF01 { get; set; }
        string VF02 { get; set; }
        string VF03 { get; set; }
        string VF04 { get; set; }
        string VF05 { get; set; }
        string VF06 { get; set; }
        string VF07 { get; set; }
        string VF08 { get; set; }
        string VF09 { get; set; }
        string VF10 { get; set; }
    }
}