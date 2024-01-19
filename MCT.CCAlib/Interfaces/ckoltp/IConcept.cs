using System;
using System.Collections.Generic;

using MCT.CCAlib.Models.ckoltp;

namespace MCT.CCAlib.Interfaces.ckoltp
{
    public interface IConcept
    {
        int Audit { get; set; }
        bool? CatalogSearch { get; set; }
        int? ConceptGroupId { get; set; }
        short ConceptTypeId { get; set; }
        byte[] DbRowVersion { get; set; }
        bool Disable { get; set; }
        short? ExpireDays { get; set; }
        int FolderId { get; set; }
        Guid Guid { get; set; }
        int Id { get; set; }
        int? ListId { get; set; }
        short? MgId { get; set; }
        string Name { get; set; }
        int? NumberOfField { get; set; }
        double? NumericMax { get; set; }
        double? NumericMin { get; set; }
        string Options { get; set; }
        int PermissionMask { get; set; }
        short? Propagate { get; set; }
        bool Protected { get; set; }
        bool ShowMeasurementDate { get; set; }
        bool? Trend { get; set; }
        short? UnitTypeId { get; set; }
        short Version { get; set; }
        string XmlInfo { get; set; }

        ICollection<UMemberConceptValue> UMemberConceptValues { get; set; }
    }
}