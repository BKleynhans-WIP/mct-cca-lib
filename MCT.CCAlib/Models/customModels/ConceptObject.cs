using System;
using System.Text;

using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Models.customModels
{
    public class ConceptObject : IConceptObject
    {
#nullable enable
        public int? ConceptId { get; set; }
        public string? Value { get; set; }
        public string? UnitName { get; set; }
        public DateTime? MeasurementDate { get; set; }
#nullable disable

        public override string ToString()
        {
            StringBuilder conceptObject = new();
            conceptObject.AppendFormat($"{"Concept ID", 20}  {ConceptId, 20}\n");
            conceptObject.AppendFormat($"{"Value", 20}  {Value, 20}\n");
            conceptObject.AppendFormat($"{"Unit Name", 20}  {UnitName, 20}\n");
            conceptObject.AppendFormat($"{"MeasurementDate", 20}  {MeasurementDate, 20}\n");

            return conceptObject.ToString();
        }
    }
}
