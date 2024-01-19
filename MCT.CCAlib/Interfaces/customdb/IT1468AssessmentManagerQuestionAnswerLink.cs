using System;

using MCT.CCAlib.Models.customdb;

namespace MCT.CCAlib.Interfaces.customdb
{
    public interface IT1468AssessmentManagerQuestionAnswerLink
    {
        int Id { get; set; }
        int AssessmentId { get; set; }
        int QuestionId { get; set; }
        int? AnswerId { get; set; }
        bool Active { get; set; }
        DateTime CreateDate { get; set; }
        DateTime? DisabledDate { get; set; }

        T1468AssessmentManagerAssessment T1468AssessmentManagerAssessment { get; set; }
        T1468AssessmentManagerQuestion T1468AssessmentManagerQuestion { get; set; }
    }
}