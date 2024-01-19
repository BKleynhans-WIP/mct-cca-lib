using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.customdb;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_Answers")]
    public class T1468AssessmentManagerAnswer : T1468AssessmentManagerAnswerDTO, IT1468AssessmentManagerAnswer
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public int Id { get; set; }
        [Column("answer")]
        [Required]
        [MaxLength(500)]
        new public string Answer { get; set; }
        [Column("source_identifier")]
        [Required]
        [MaxLength(100)]
        new public string SourceIdentifier { get; set; }
        [Column("create_date")]
        [Required]
        new public DateTime CreateDate { get; set; }
    }
}
