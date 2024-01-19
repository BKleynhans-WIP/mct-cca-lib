using System;

namespace MCT.CCAlib.Interfaces.customdb
{
    public interface IT1468AssessmentManagerAnswer
    {
        int Id { get; set; }
        string Answer { get; set; }
        string SourceIdentifier { get; set; }
        DateTime CreateDate { get; set; }
    }
}