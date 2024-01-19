using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_Answers")]
    public class T1468AssessmentManagerAnswerCreateDTO
    {
        [Key, Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int Id { get; set; }
        [Column("answer")]
        [Required]
        [MaxLength(500)]
        public string Answer { get; set; }
        [Column("source_identifier")]
        [Required]
        [MaxLength(100)]
        public string SourceIdentifier { get; set; }
        [Column("create_date")]
        [Required]
        public DateTime CreateDate { get; set; }

    }
}
