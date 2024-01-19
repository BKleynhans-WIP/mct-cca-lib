using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.customdb;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_Questions")]
    public class T1468AssessmentManagerQuestion : T1468AssessmentManagerQuestionDTO, IT1468AssessmentManagerQuestion
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public int Id { get; set; }
        [Column("question")]
        [Required]
        [MaxLength(500)]
        new public string Question { get; set; }
        [Column("source_identifier")]
        [Required]
        [MaxLength(100)]
        new public string SourceIdentifier { get; set; }
#nullable enable
        [Column("question_extension")]
        [MaxLength(100)]
        new public string? QuestionExtension { get; set; }
#nullable disable
        [Column("alternate_question")]
        [Required]
        new public string AlternateQuestion { get; set; }
        [Column("create_date")]
        [Required]
        new public DateTime CreateDate { get; set; }
#nullable enable
        [Column("parent_identifier")]
        [MaxLength(100)]
        new public string? ParentIdentifer { get; set; }
#nullable disable

        public virtual ICollection<T1468AssessmentManagerQuestionAnswerLink> QuestionAnswerLinks { get; set; }
    }
}
