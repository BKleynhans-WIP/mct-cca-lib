using System;

using MCT.CCAlib.Models.ckoltp;

namespace MCT.CCAlib.Interfaces.ckoltp
{
    public interface IUMemberConceptValue
    {
        int Cid { get; set; }
        int ConceptId { get; set; }
        string StringValue { get; set; }        
        DateTime UpdateTime { get; set; }        
        byte[] DbRowVersion { get; set; }

#nullable enable
        int? UnitId { get; set; }
        int? ObxId { get; set; }
        double? NumValue { get; set; }
        DateTime? DateValue { get; set; }
        int? ConceptTypeId { get; set; }
        double? Trend { get; set; }
        DateTime? SysDate { get; set; }
        string? Username { get; set; }
        Guid? SourceGuid { get; set; }
#nullable disable

        Concept Concept { get; set; }
    }
}