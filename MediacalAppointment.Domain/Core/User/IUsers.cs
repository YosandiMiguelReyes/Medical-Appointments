

using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Core.User
{
    public interface IUsers
    {
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
