

using MedicalAppointment.Domain.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Appointments
{
    [Table("Appointments", Schema = "appointments")]
    public sealed class Appointments :BaseEntity
    {
        [ForeignKey("PatientID")]
        public int PatientID { get; set; }
        [ForeignKey("DoctorID")]
        public int DoctorID { get; set; }
        [Column("AppointmentDate")]
        public DateTime AppointmentDate { get; set; }
        [ForeignKey("StatusID")]
        public int StatusID { get; set; }
    }
}
