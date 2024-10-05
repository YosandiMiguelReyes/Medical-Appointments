using MediacalAppointment.Persistence.Context;
using MedicalAppointment.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace MediacalAppointment.Persistence.Context
{
    public partial class MedicalAppointmentContext
    {
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
