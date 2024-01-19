using MCT.CCAlib.Models.ckoltp;
using System;

namespace MCT.CCAlib.Interfaces.ckoltp
{
    public interface IMember
    {
        short ActiveInd { get; set; }
        
        string Alias { get; set; }
        short AllowManaged { get; set; }
        
        string AutoFocusSetting { get; set; }
        bool CampaignExcluded { get; set; }        
        int Cid { get; set; }        
        DateTime DateOfBirth { get; set; }
        byte[] DbRowVersion { get; set; }        
        string Email { get; set; }        
        string ExternalUniqueId { get; set; }        
        string FirstName { get; set; }        
        bool HasHipaaPrivacy { get; set; }
        string HealthcareId { get; set; }
        DateTime LastAccessTime { get; set; }        
        string LastName { get; set; }        
        string MedicaidNo { get; set; }
        string MedicareNo { get; set; }
        string MemberCustomization { get; set; }
        short MemberGroupId { get; set; }        
        bool MergeStatus { get; set; }        
        string MiddleInitial { get; set; }        
        short PrivateMember { get; set; }        
        string Sms { get; set; }
        string SsisExternalId { get; set; }        
        string SubscriberId { get; set; }        
        string Title { get; set; }
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
        string WizardState { get; set; }
        string XmlFilterSort { get; set; }
#nullable enable
        DateTime? MergeDate { get; set; }
        DateTime? AlertDate { get; set; }
        bool? AllowQa { get; set; }
        DateTime? CarekeyExpirationDate { get; set; }
        bool? ChangePasswordRequired { get; set; }
        DateTime? CmIdentifiedDate { get; set; }
        short? DbVersion { get; set; }
        int? Employer { get; set; }
        short? FailedTime { get; set; }
        char? Gender { get; set; }
        DateTime? LastFailedPeriodStart { get; set; }
        DateTime? LastLoginTime { get; set; }
        int? LicenseId { get; set; }
        int? MergeUser { get; set; }
        Guid? MetadataGuid { get; set; }
        DateTime? OpenDate { get; set; }
        DateTime? OptOutTime { get; set; }
        bool? PhoneActiveInd { get; set; }
        int? RestrictionGroupId { get; set; }
        int? SsisExternalSystemId { get; set; }
        bool? SsisInsert { get; set; }
        bool? SsisUpdate { get; set; }
        string? Ssn { get; set; }
        int? TempCidLink { get; set; }
        short? TempStatus { get; set; }
#nullable disable

        MemberCoverage MemberCoverage { get; set; }
    }
}