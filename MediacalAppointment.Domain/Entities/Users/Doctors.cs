using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Interface;
using MedicalAppointment.Domain.Core.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Users
{
    [Table("Doctors", Schema = "users")]
    public sealed class Doctors : BaseEntity, IUsers, IIsActive
    {
        [ForeignKey("SpecialtyID")]
        public int SpecialtyID { get; set; }

        [Column("LicenseNumber")]
        public string LicenseNumber { get; set; }

        [Column("YearsOfExperience")]
        public int YearsOfExperience { get; set; }

        [Column("Education")]
        public string Education { get; set; }

        [Column("Bio")]
        public string? Bio { get; set; }

        [Column("ConsultationFee")]
        public double? ConsultationFee { get; set; }

        [Column("ClinicAddress")]
        public string? ClinicAddress { get; set; }

        [ForeignKey("AvailabilityModeId")]
        public int? AvailabilityModeId { get; set; }

        [Column("LicenseExpirationDate")]
        public DateOnly LicenseExpirationDate { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }
        [Column("Email")]
        public string Email {  get; set; }
    }
}
