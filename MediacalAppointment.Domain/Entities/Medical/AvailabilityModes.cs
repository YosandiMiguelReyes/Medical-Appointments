
using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Medical
{
    [Table("AvailabilityModes", Schema = "medical")]
    public sealed class AvailabilityModes : BaseEntity, IIsActive
    {
        [Column("AvailabilityMode")]
        public string AvailabilityMode { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }

    }
}
