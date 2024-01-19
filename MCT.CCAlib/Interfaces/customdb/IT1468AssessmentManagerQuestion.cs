using System;
using System.Collections.Generic;

using MCT.CCAlib.Models.customdb;

namespace MCT.CCAlib.Interfaces.customdb
{
    public interface IT1468AssessmentManagerQuestion
    {
        int Id { get; set; }
        string Question { get; set; }
        string SourceIdentifier { get; set; }
        string QuestionExtension { get; set; }
        string AlternateQuestion { get; set; }
        DateTime CreateDate { get; set; }
        string ParentIdentifer { get; set; }

        ICollection<T1468AssessmentManagerQuestionAnswerLink> QuestionAnswerLinks { get; set; }
    }
}