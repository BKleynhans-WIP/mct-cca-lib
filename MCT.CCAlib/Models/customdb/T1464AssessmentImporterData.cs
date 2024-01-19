using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1464_AssessmentImporter_Data")]
    public class T1464AssessmentImporterData
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("member_log_id")]
        public int MemberLogId { get; set; }
        [Column("question_id")]
        public int QuestionId { get; set; }
#nullable enable
        [Column("answer_value")]
        public string? AnswerValue { get; set; }
#nullable disable
        [Column("create_date")]
        public DateTime CreateDate { get; set; }
    }
}
