using MedicalAppointment.Domain.Core.Base;
using MedicalAppointment.Domain.Core.Interface;
using MedicalAppointment.Domain.Core.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Users
{
    [Table("Users", Schema = "users")]
    public sealed class Users : BaseEntity, IUsers, IIsActive
    {
        [Column("Email")]
        public string Email { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [ForeignKey("RoleID")]
        public int? RoleID { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("PhoneNumber")]
        public string? PhoneNumber { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
