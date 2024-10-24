

using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.System
{
    [Table ("Status", Schema = "system")]
    public sealed class Status
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
