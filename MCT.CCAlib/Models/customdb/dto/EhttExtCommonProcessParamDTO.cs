using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCT.CCAlib.Models.customdb.dto
{
    [Table("ehtt_ext_common_process_params")]
    public class EhttExtCommonProcessParamDTO
    {
        [Key, Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ProcessName"), MaxLength(255)]
        [Required]
        public string ProcessName { get; set; }
        [Column("ParameterName"), MaxLength(255)]
        [Required]
        public string ParameterName { get; set; }
        [Column("ParameterValue"), MaxLength(255)]
        [Required]
        public string ParameterValue { get; set; }
        [Column("CreateDate")]
        [Required]
        public DateTime? CreateDate { get; set; }
#nullable enable
        [Column("LastUpadatedDate")]
        public DateTime? LastUpdatedDate { get; set; }
#nullable disable
    }
}
