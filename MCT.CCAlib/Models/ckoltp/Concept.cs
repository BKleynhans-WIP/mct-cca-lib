using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.ckoltp;

namespace MCT.CCAlib.Models.ckoltp
{
    [Table("CONCEPT")]
    public class Concept : IConcept
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
#nullable enable
        [Column("mg_id")]
        public Int16? MgId { get; set; }
#nullable disable
        [Column("concept_type_id")]
        public Int16 ConceptTypeId { get; set; }
        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; }
#nullable enable
        [Column("unit_type_id")]
        public Int16? UnitTypeId { get; set; }
#nullable disable
        [Column("disable")]
        public bool Disable { get; set; }
#nullable enable
        [Column("expire_days")]
        public Int16? ExpireDays { get; set; }
        [Column("xml_info")]
        [MaxLength(1000)]
        public string? XmlInfo { get; set; }
#nullable disable
        [Column("folder_id")]
        public int FolderId { get; set; }
        [Column("audit")]
        public int Audit { get; set; }
        [Column("protected")]
        public bool Protected { get; set; }
        [Column("permission_mask")]
        public int PermissionMask { get; set; }
#nullable enable
        [Column("concept_group_id")]
        public int? ConceptGroupId { get; set; }
        [Column("list_id")]
        public int? ListId { get; set; }
        [Column("numeric_min")]
        public double? NumericMin { get; set; }
        [Column("numeric_max")]
        public double? NumericMax { get; set; }
        [Column("number_of_field")]
        public int? NumberOfField { get; set; }
        [Column("catalog_search")]
        public bool? CatalogSearch { get; set; }
        [Column("TREND")]
        public bool? Trend { get; set; }
        [Column("propagate")]
        public Int16? Propagate { get; set; }
        [Column("options")]
        public string? Options { get; set; }
#nullable disable
        [Column("guid")]
        public Guid Guid { get; set; }
        [Column("version")]
        public Int16 Version { get; set; }
        [Column("db_rowversion")]
        public byte[] DbRowVersion { get; set; }
        [Column("show_measurement_date")]
        public bool ShowMeasurementDate { get; set; }

        public virtual ICollection<UMemberConceptValue> UMemberConceptValues { get; set; }
    }
}
