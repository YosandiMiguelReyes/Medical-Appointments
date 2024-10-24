

using MedicalAppointment.Domain.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Medical
{
    [Table("MedicalRecords", Schema = "medical")]
    public sealed class MedicalRecords : BaseEntity
    {
        [ForeignKey("PatientID")]
        public int PatientID { get; set; }
        [ForeignKey("DoctorID")]
        public int DoctorID { get; set; }
        [Column("Diagnosis")]
        public string Diagnosis { get; set; }
        [Column("Treatment")]
        public string Treatment { get; set; }
        [Column("DateOfVisit")]
        public DateTime DateOfVisit { get; set; }
    }
}
