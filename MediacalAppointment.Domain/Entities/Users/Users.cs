using MedicalAppointment.Domain.Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Users
{
    [Table("Users", Schema = "users")]
    public sealed class Users : BaseEntity
    {
        [Column("Email")]
        public string Email { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [ForeignKey("RoleID")]
        public int? RoleID { get; set; }

    }
}
