using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCT.CCAlib.Models.customdb
{
    [Table("T_1443_TaskCreationSettings")]
    public class T1443TaskCreationSettings
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("incoming_source")]
        [StringLength(50)]
        public string IncomingSource { get; set; }
        [Column("task_type")]
        [StringLength(20)]
        public string TaskType { get; set; }
#nullable enable
        [Column("external_user_id")]
        [StringLength(50)]
        public string? ExternalUserId { get; set; }
#nullable disable
        [Column("user_system_id")]
        public int? UserSystemId { get; set; }
#nullable enable
        [Column("external_queue_id")]
        [StringLength(36)]
        public string? ExternalQueueId { get; set; }
#nullable disable
        [Column("priority")]
        [StringLength(10)]
        public string Priority { get; set; }
        [Column("days_before_due")]
#nullable enable
        public int? DaysBeforeDue { get; set; }
        [Column("subject")]
        [StringLength(100)]
        public string? Subject { get; set; }
        [Column("body")]
        public string? Body { get; set; }
#nullable disable
    }
}
