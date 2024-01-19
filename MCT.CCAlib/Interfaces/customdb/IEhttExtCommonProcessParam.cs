using System;

namespace MCT.CCAlib.Interfaces.customdb
{
    public interface IEhttExtCommonProcessParam
    {
        int Id { get; set; }
        string ProcessName { get; set; }
        string ParameterName { get; set; }
        string ParameterValue { get; set; }        
        DateTime? CreateDate { get; set; }
        DateTime? LastUpdatedDate { get; set; }
    }
}