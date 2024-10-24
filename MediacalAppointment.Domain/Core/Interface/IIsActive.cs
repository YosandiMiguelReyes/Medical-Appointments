using System.ComponentModel.DataAnnotations.Schema;


namespace MedicalAppointment.Domain.Core.Interface
{
    public interface IIsActive
    {
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
