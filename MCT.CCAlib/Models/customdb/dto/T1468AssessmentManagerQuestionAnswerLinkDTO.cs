using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_QuestionAnswerLink")]
    public class T1468AssessmentManagerQuestionAnswerLinkDTO
    {
        [Key, Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("assessment_id")]
        [Required]
        public int AssessmentId { get; set; }
        [Column("question_id")]
        [Required]
        public int QuestionId { get; set; }
#nullable enable
        [Column("answer_id")]
        public int? AnswerId { get; set; }
#nullable disable
        [Column("active")]
        [Required]
        public bool Active { get; set; }
        [Column("create_date")]
        [Required]
        public DateTime CreateDate { get; set; }
#nullable enable
        [Column("disabled_date")]
        public DateTime? DisabledDate { get; set; }
#nullable disable
    }
}
