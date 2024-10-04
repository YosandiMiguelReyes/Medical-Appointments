using MedicalAppointment.Domain.Core.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Users
{
    [Table("Doctors", Schema = "users")]
    public sealed class Doctors : BaseUser
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
        public decimal? ConsultationFee { get; set; }

        [Column("ClinicAddress")]
        public string? ClinicAddress { get; set; }

        [ForeignKey("AvailabilityModeId")]
        public int? AvailabilityModeId { get; set; }

        [Column("LicenseExpirationDate")]
        public DateOnly LicenseExpirationDate { get; set; }
    }
}
