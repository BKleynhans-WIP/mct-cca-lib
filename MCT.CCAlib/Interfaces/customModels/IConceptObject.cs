using System;

namespace MCT.CCAlib.Interfaces.customModels
{
    public interface IConceptObject
    {
#nullable enable
        int? ConceptId { get; set; }
        string? Value { get; set; }        
        string? UnitName { get; set; }
        DateTime? MeasurementDate { get; set; }
#nullable disable
        string ToString();
    }
}