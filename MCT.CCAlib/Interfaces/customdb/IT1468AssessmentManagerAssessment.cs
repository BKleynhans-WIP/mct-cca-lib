using System;
using System.Collections.Generic;

using MCT.CCAlib.Models.customdb;

namespace MCT.CCAlib.Interfaces.customdb
{
    public interface IT1468AssessmentManagerAssessment
    {
        int Id { get; set; }
        string IncomingSource { get; set; }
        string Name { get; set; }
        int? HraId { get; set; }        
        bool CreateAssessmentTask { get; set; }
        bool Active { get; set; }
        DateTime CreateDate { get; set; }
        DateTime? DisabledDate { get; set; }

        ICollection<T1468AssessmentManagerQuestionAnswerLink> QuestionAnswerLinks { get; set; }
    }
}