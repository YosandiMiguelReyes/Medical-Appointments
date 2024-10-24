using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Medical
{
    [Table("Specialties", Schema = "medical")]
    public sealed class Specialties : BaseEntity, IIsActive
    {
        [Column("IsActive")]
        public bool IsActive { get; set; }
        [Column("SpecialtyName")]
        public string SpecialtyName { get; set; }
    }
}
