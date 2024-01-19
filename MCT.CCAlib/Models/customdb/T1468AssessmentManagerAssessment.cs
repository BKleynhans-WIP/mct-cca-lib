using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.customdb;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_Assessments")]
    public class T1468AssessmentManagerAssessment : T1468AssessmentManagerAssessmentDTO, IT1468AssessmentManagerAssessment
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public int Id { get; set; }
        [Column("incoming_source")]
        [Required]
        [MaxLength(50)]
        new public string IncomingSource { get; set; }
        [Column("name")]
        [Required]
        [MaxLength(50)]
        new public string Name { get; set; }
#nullable enable
        [Column("hra_id")]
        new public int? HraId { get; set; }
#nullable disable
        [Column("create_assessment_task")]
        [Required]
        new public bool CreateAssessmentTask { get; set; }
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

        public virtual ICollection<T1468AssessmentManagerQuestionAnswerLink> QuestionAnswerLinks { get; set; }
    }
}
