

using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.System
{
    [Table("Role", Schema = "system")]
    public sealed class Role : BaseEntity, IIsActive
    {
        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Column("RoleName")]
        public string RoleName { get; set; }
    }
}
