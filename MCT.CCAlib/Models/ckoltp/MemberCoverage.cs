using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.ckoltp;

namespace MCT.CCAlib.Models.ckoltp
{
    [Table("MEMBER_COVERAGE")]
    public class MemberCoverage : IMemberCoverage
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("cid")]
        public int Cid { get; set; }
#nullable enable
        [Column("subscriber_id")]
        [MaxLength(50)]
        public string? SubscriberId { get; set; }
        [Column("subscriber_suffix")]
        public int? SubscriberSuffix { get; set; }
        [Column("relationship")]
        public int? Relationship { get; set; }
        [Column("group_ck")]
        [MaxLength(50)]
        public string? GroupCk { get; set; }
        [Column("group_id")]
        [MaxLength(100)]
        public string? GroupId { get; set; }
        [Column("group_name")]
        [MaxLength(100)]
        public string? GroupName { get; set; }
        [Column("orig_effective_date")]
        public DateTime? OrigEffectiveDate { get; set; }
#nullable disable
        [Column("effective_date")]
        public DateTime EffectiveDate { get; set; }
#nullable enable
        [Column("term_date")]
        public DateTime? TermDate { get; set; }
#nullable disable
        [Column("is_primary")]
        public bool IsPrimary { get; set; }
        [Column("is_eligible")]
        public bool IsEligible { get; set; }
#nullable enable
        [Column("source_id")]
        [MaxLength(50)]
        public string? SourceId { get; set; }
        [Column("source_detail")]
        [MaxLength(50)]
        public string? SourceDetail { get; set; }
        [Column("source_date")]
        public DateTime? SourceDate { get; set; }
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
#nullable disable
        [Column("db_rowversion")]
        public byte[] DbRowVersion { get; set; }
#nullable enable
        [Column("ssis_recalculate_dates")]
        public bool? SsisRecalculateDates { get; set; }
        [Column("ssis_insert")]
        public bool? SsisInsert { get; set; }
        [Column("ssis_update")]
        public bool? SsisUpdate { get; set; }
#nullable disable

        public virtual Member Member { get; set; }
    }
}
