using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MCT.CCAlib.Interfaces.customdb;
using MCT.CCAlib.Models.customdb.dto;

namespace MCT.CCAlib.Models.customdb
{
    public class EhttExtCommonProcessParam : EhttExtCommonProcessParamDTO, IEhttExtCommonProcessParam
    {
        [Key, Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public int Id { get; set; }
        [Required]
        [Column("ProcessName"), MaxLength(255)]
        new public string ProcessName { get; set; }
        [Required]
        [Column("ParameterName"), MaxLength(255)]
        new public string ParameterName { get; set; }
        [Required]
        [Column("ParameterValue"), MaxLength(255)]
        new public string ParameterValue { get; set; }
        [Required]
        [Column("CreateDate")]
        new public DateTime? CreateDate { get; set; }
#nullable enable
        [Column("LastUpadatedDate")]
        new public DateTime? LastUpdatedDate { get; set; }
#nullable disable
    }
}
