

using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.System
{
    [Table("Notifications", Schema = "system")]
    public sealed class Notifications
    {
        [Key]
        public int NotificationID { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        [Column("Message")]
        public string Message { get; set; }
        [Column("SentAt")]
        public DateAndTime? SentAt { get; set; }
    }
}
