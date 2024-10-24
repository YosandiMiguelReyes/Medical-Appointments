

using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Core.Insurance
{
    public interface IName
    {
        [Column("Name")]
       public string Name { get; set; }
    }
}
