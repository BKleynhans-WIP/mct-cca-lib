using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.ckoltp;

namespace MCT.CCAlib.Models.ckoltp
{
    [Table("U_MEMBER_CONCEPT_VALUE")]
    public class UMemberConceptValue : IUMemberConceptValue
    {
        [Column("CID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cid { get; set; }
        [Column("concept_id")]
        public int ConceptId { get; set; }
        [Column("STR_VALUE")]
        [MaxLength(3000)]
        public string StringValue { get; set; }
#nullable enable
        [Column("unit_id")]
        public int? UnitId { get; set; }
#nullable disable
        [Column("update_time")]
        public DateTime UpdateTime { get; set; }
#nullable enable
        [Column("obx_id")]
        public int? ObxId { get; set; }
        [Column("NUM_VALUE")]
        public double? NumValue { get; set; }
        [Column("date_value")]
        public DateTime? DateValue { get; set; }
        [Column("concept_type_id")]
        public int? ConceptTypeId { get; set; }
        [Column("TREND")]
        public double? Trend { get; set; }
        [Column("SYS_DATE")]
        public DateTime? SysDate { get; set; }
        [Column("user_name")]
        [MaxLength(200)]
        public string? Username { get; set; }
        [Column("source_guid")]
        public Guid? SourceGuid { get; set; }
#nullable disable
        [Column("db_rowversion")]
        public byte[] DbRowVersion { get; set; }

        public virtual Concept Concept { get; set; }
    }
}
