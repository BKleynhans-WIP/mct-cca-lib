using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1468_AssessmentManager_Assessments")]
    public class T1468AssessmentManagerAssessmentCreateDTO
    {
        [Key, Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("incoming_source")]
        [Required]
        [MaxLength(50)]
        public string IncomingSource { get; set; }
        [Column("name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
#nullable enable
        [Column("hra_id")]
        public int? HraId { get; set; }
#nullable disable
        [Column("create_assessment_task")]
        [Required]
        public bool CreateAssessmentTask { get; set; }
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
