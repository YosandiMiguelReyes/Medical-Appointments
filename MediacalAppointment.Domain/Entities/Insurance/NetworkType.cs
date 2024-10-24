

using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Insurance;
using MedicalAppointment.Domain.Core.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Insurance
{
    [Table("NetworkType", Schema = "Insurance")]
    public sealed class NetworkType : BaseEntity, IIsActive, IName
    {
        [Column("Name")]
        public string Name { get; set; }
        [Column("Description")]
        public string? Description { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
