using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.ckoltp;

namespace MCT.CCAlib.Models.ckoltp
{
    [Table("MEMBER")]
    public class Member : IMember
    {
        [Column("CID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cid { get; set; }
        [Column("MEMBER_GROUP_ID")]
        public short MemberGroupId { get; set; }
        [Column("ACTIVE_IND")]
        public short ActiveInd { get; set; }
        [Column("FIRST_NAME")]
        [MaxLength(50)]
        public string FirstName { get; set; }
#nullable enable
        [Column("LAST_NAME")]
        [MaxLength(60)]
        public string? LastName { get; set; }
        [Column("GENDER")]
        public char? Gender { get; set; }
#nullable disable
        [Column("DATE_OF_BIRTH")]
        public DateTime DateOfBirth { get; set; }
#nullable enable
        [Column("OPEN_DATE")]
        public DateTime? OpenDate { get; set; }
        [Column("CAREKEY_EXPIRATION_DATE")]
        public DateTime? CarekeyExpirationDate { get; set; }
        [Column("LAST_LOGIN_TIME")]
        public DateTime? LastLoginTime { get; set; }
        [Column("WIZARD_STATE")]
        public string? WizardState { get; set; }
        [Column("MEMBER_CUSTOMIZATION")]
        public string? MemberCustomization { get; set; }
        [Column("XML_FILTER_SORT")]
        [MaxLength(250)]
        public string? XmlFilterSort { get; set; }
        [Column("PHONE_ACTIVE_IND")]
        public bool? PhoneActiveInd { get; set; }
#nullable disable
        [Column("PRIVATE_MEMBER")]
        public short PrivateMember { get; set; }
#nullable enable
        [Column("LICENSE_ID")]
        public int? LicenseId { get; set; }
        [Column("DB_VERSION")]
        public short? DbVersion { get; set; }
        [Column("AUTO_FOCUS_SETTING")]
        [MaxLength(500)]
        public string? AutoFocusSetting { get; set; }
#nullable disable
        [Column("last_access_time")]
        public DateTime LastAccessTime { get; set; }
#nullable enable
        [Column("EMAIL")]
        [MaxLength(256)]
        public string? Email { get; set; }
        [Column("SMS")]
        [MaxLength(100)]
        public string? Sms { get; set; }
        [Column("ALIAS")]
        [MaxLength(100)]
        public string? Alias { get; set; }
        [Column("allow_qa")]
        public bool? AllowQa { get; set; }
        [Column("failed_time")]
        public short? FailedTime { get; set; }
        [Column("employer")]
        public int? Employer { get; set; }
        [Column("TITLE")]
        [MaxLength(30)]
        public string? Title { get; set; }
        [Column("MIDDLE_INITIAL")]
        [MaxLength(50)]
        public string? MiddleInitial { get; set; }
        [Column("ALERT_DATE")]
        public DateTime? AlertDate { get; set; }
#nullable disable
        [Column("allow_managed")]
        public short AllowManaged { get; set; }
#nullable enable
        [Column("external_unique_id")]
        [MaxLength(50)]
        public string? ExternalUniqueId { get; set; }
        [Column("last_failed_period_start")]
        public DateTime? LastFailedPeriodStart { get; set; }
        [Column("subscriber_id")]
        [MaxLength(50)]
        public string? SubscriberId { get; set; }
#nullable disable
        [Column("db_rowversion")]
        public byte[] DbRowVersion { get; set; }
#nullable enable
        [Column("temp_cid_link")]
        public int? TempCidLink { get; set; }
        [Column("temp_status")]
        public short? TempStatus { get; set; }
        [Column("merge_user")]
        public int? MergeUser { get; set; }
        [Column("merge_date")]
        public DateTime? MergeDate { get; set; }
        [Column("opt_out_time")]
        public DateTime? OptOutTime { get; set; }
        [Column("metadata_guid")]
        public Guid? MetadataGuid { get; set; }
        [Column("VF_01")]
        [MaxLength(100)]
        public string? VF01 { get; set; }
        [Column("VF_02")]
        [MaxLength(100)]
        public string? VF02 { get; set; }
        [Column("VF_03")]
        [MaxLength(100)]
        public string? VF03 { get; set; }
        [Column("VF_04")]
        [MaxLength(100)]
        public string? VF04 { get; set; }
        [Column("VF_05")]
        [MaxLength(100)]
        public string? VF05 { get; set; }
        [Column("VF_06")]
        [MaxLength(100)]
        public string? VF06 { get; set; }
        [Column("VF_07")]
        [MaxLength(100)]
        public string? VF07 { get; set; }
        [Column("VF_08")]
        [MaxLength(100)]
        public string? VF08 { get; set; }
        [Column("VF_09")]
        [MaxLength(100)]
        public string? VF09 { get; set; }
        [Column("VF_10")]
        [MaxLength(100)]
        public string? VF10 { get; set; }
        [Column("change_password_required")]
        public bool? ChangePasswordRequired { get; set; }
        [Column("RESTRICTION_GROUP_ID")]
        public int? RestrictionGroupId { get; set; }
        [Column("SSN")]
        [MaxLength(11)]
        public string? Ssn { get; set; }
        [Column("MEDICARE_NO")]
        [MaxLength(50)]
        public string? MedicareNo { get; set; }
        [Column("MEDICAID_NO")]
        [MaxLength(50)]
        public string? MedicaidNo { get; set; }
        [Column("CM_IDENTIFIED_DATE")]
        public DateTime? CmIdentifiedDate { get; set; }
        [Column("ssis_insert")]
        public bool? SsisInsert { get; set; }
        [Column("ssis_update")]
        public bool? SsisUpdate { get; set; }
        [Column("ssis_external_system_id")]
        public int? SsisExternalSystemId { get; set; }
        [Column("ssis_external_id")]
        [MaxLength(50)]
        public string? SsisExternalId { get; set; }
        [Column("healthcare_id")]
        [MaxLength(50)]
        public string? HealthcareId { get; set; }
#nullable disable
        [Column("HAS_HIPAA_PRIVACY")]
        public bool HasHipaaPrivacy { get; set; }
        [Column("merge_status")]
        public bool MergeStatus { get; set; }
        [Column("campaign_excluded")]
        public bool CampaignExcluded { get; set; }

        public virtual MemberCoverage MemberCoverage { get; set; }
    }
}
