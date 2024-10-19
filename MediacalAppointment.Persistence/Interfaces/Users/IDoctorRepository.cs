
using MediacalAppointment.Domain.Repositories;
using MedicalAppointment.Domain.Entities.Users;

namespace MediacalAppointment.Persistence.Interfaces.Users
{
    public interface IDoctorRepository : IBaseRepository<Doctors,int>
    {
    }
}
