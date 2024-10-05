
using Microsoft.EntityFrameworkCore;

namespace MediacalAppointment.Persistence.Context
{
    //DbSet is in charge of mapping our entities
    //DbContext is in charge of our database connection
    public partial class MedicalAppointmentContext : DbContext
    {
        public MedicalAppointmentContext(DbContextOptions<MedicalAppointmentContext> options) : base(options)
        {

        }

    }
}
