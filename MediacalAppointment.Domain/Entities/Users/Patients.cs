using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Interface;
using MedicalAppointment.Domain.Core.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Users
{
    [Table("Patients", Schema = "users")]
    public sealed class Patients : BaseEntity, IUsers, IIsActive
    {
        [Column("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Column("Gender")]
        public char Gender { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("EmergencyContactName")]
        public string EmergencyContactName { get; set; }

        [Column("EmergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }

        [Column("BloodType")]
        public string BloodType { get; set; }

        [Column("Allergies")]
        public string Allergies { get; set; }

        [ForeignKey("InsuranceProviderID")]
        public int InsuranceProviderID { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
