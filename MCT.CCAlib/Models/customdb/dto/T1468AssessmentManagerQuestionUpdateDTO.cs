using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_Questions")]
    public class T1468AssessmentManagerQuestionUpdateDTO
    {
        [Key, Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("question")]
        [Required]
        [MaxLength(500)]
        public string Question { get; set; }
        [Column("source_identifier")]
        [Required]
        [MaxLength(100)]
        public string SourceIdentifier { get; set; }
#nullable enable
        [Column("question_extension")]
        [MaxLength(100)]
        public string? QuestionExtension { get; set; }
#nullable disable
        [Column("alternate_question")]
        [Required]
        public string AlternateQuestion { get; set; }
        [Column("create_date")]
        [Required]
        [IgnoreDataMember]
        public DateTime CreateDate { get; set; }
#nullable enable
        [Column("parent_identifier")]
        [MaxLength(100)]
        public string? ParentIdentifer { get; set; }
#nullable disable

    }
}
