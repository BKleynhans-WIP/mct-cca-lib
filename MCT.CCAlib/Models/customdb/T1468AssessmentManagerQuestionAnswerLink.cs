using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.customdb;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_QuestionAnswerLink")]
    public class T1468AssessmentManagerQuestionAnswerLink : T1468AssessmentManagerQuestionAnswerLinkDTO, IT1468AssessmentManagerQuestionAnswerLink
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public int Id { get; set; }
        [Column("assessment_id")]
        [Required]
        new public int AssessmentId { get; set; }
        [Column("question_id")]
        [Required]
        new public int QuestionId { get; set; }
#nullable enable
        [Column("answer_id")]
        new public int? AnswerId { get; set; }
#nullable disable
        [Column("active")]
        [Required]
        new public bool Active { get; set; }
        [Column("create_date")]
        [Required]
        new public DateTime CreateDate { get; set; }
#nullable enable
        [Column("disabled_date")]
        new public DateTime? DisabledDate { get; set; }
#nullable disable

        public virtual T1468AssessmentManagerAssessment T1468AssessmentManagerAssessment { get; set; }
        public virtual T1468AssessmentManagerQuestion T1468AssessmentManagerQuestion { get; set; }
    }
}
