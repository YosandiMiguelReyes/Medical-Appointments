

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Appointments
{
    [Table("DoctorAvailability", Schema = "appointments")]
    public sealed class DoctorAvailability
    {
        [Key]
        public int AvailabilityID { get; set; }

        [ForeignKey("DoctorID")]
        public int DoctorID { get; set; }
        [Column("AvailableDate")]
        public DateOnly AvailableDate { get; set; }
        [Column("StartTime")]
        public TimeOnly StartTime { get; set; }
        [Column("EndTime")]
        public TimeOnly EndTime { get; set; }
    }
}
