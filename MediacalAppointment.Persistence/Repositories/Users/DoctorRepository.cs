
using MediacalAppointment.Domain.Results;
using MediacalAppointment.Persistence.Base;
using MediacalAppointment.Persistence.Context;
using MediacalAppointment.Persistence.Interfaces.Users;
using MediacalAppointment.Persistence.Model.Users;
using MedicalAppointment.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace MediacalAppointment.Persistence.Repositories.Users
{
    public class DoctorRepository(MedicalAppointmentContext medicalAppointmentContext, ILogger<DoctorRepository> logger) : BaseRepository<Doctors, int>(medicalAppointmentContext), IDoctorRepository
    {
        private readonly MedicalAppointmentContext _medicalappointmentContext = medicalAppointmentContext;
        private readonly ILogger<DoctorRepository> _logger = logger;

        public async override Task<OperationResult<bool>> Add(Doctors entity)
        {
            OperationResult<bool> result = new OperationResult<bool>();
            //Correo
            if (entity == null)
            {
                result.Success = false;
                result.Message = "La entidad es requeridad";
                return result;
            }
            if (entity.LicenseNumber.Length > 50)
            {
                result.Success = false;
                result.Message = "El numero de la licencia debe de ser menor a 50 caracteres";
                return result;
            }
            if (entity.PhoneNumber.Length > 15)
            {
                result.Success = false;
                result.Message = "El numero telefonico debe de ser menor a 15 caracteres";
                return result;
            }
            if (entity.ConsultationFee > 10.2)
            {
                result.Success = false;
                result.Message = "El cargo por consulta no debe superar 10.2";
                return result;
            }
            if(entity.ClinicAddress.Length > 255)
            {
                result.Success = false;
                result.Message = "La direccion no puede contener mas de 255 caracteres";
                return result;
            }
            if (entity.ID == 0)
            {
                result.Success = false;
                result.Message = "Debe de ingresar un Doctor";
            }
            var existsResult = await base.Exists(d => d.Email == entity.Email);
            if (existsResult.Success)
            {
                result.Success = false;
                result.Message = "El doctor se encuentra registrado.";
                return result;
            }
            try
            {
                result.Success = true;
                result.Message = "Agregado correctamente";
                entity.CreatedAt = DateTime.Now;
                result = await base.Add(entity);
                
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error guardando el Doctor";
                logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public async override Task<OperationResult<Doctors>> Update(Doctors entity)
        {
            OperationResult<Doctors> result = new OperationResult<Doctors>();

            if (entity.LicenseNumber.Length > 50)
            {
                result.Success = false;
                result.Message = "El numero de la licencia debe de ser menor a 50 caracteres";
                return result;
            }
            if (entity.PhoneNumber.Length > 15)
            {
                result.Success = false;
                result.Message = "El numero telefonico debe de ser menor a 15 caracteres";
                return result;
            }
            if (entity.ConsultationFee > 10.2)
            {
                result.Success = false;
                result.Message = "El cargo por consulta no debe superar 10.2";
                return result;
            }
            if (entity.ClinicAddress.Length > 255)
            {
                result.Success = false;
                result.Message = "La direccion no puede contener mas de 255 caracteres";
                return result;
            }
            if (entity == null)
            {
                result.Success = false;
                result.Message = "La entidad es requerida";
                return result;
            }
            if (entity.ID == 0)
            {
                result.Success = false;
                result.Message = "La entidad es requerida";
                return result;
            }
            try
            {
                Doctors? DoctorToUpdate = await _medicalappointmentContext.Doctors.FindAsync(entity.ID);
                DoctorToUpdate.ID = entity.ID;
                DoctorToUpdate.SpecialtyID = entity.SpecialtyID;
                DoctorToUpdate.LicenseNumber = entity.LicenseNumber;
                DoctorToUpdate.YearsOfExperience = entity.YearsOfExperience;
                DoctorToUpdate.Education = entity.Education;
                DoctorToUpdate.Bio = entity.Bio;
                DoctorToUpdate.ConsultationFee = entity.ConsultationFee;
                DoctorToUpdate.ClinicAddress = entity.ClinicAddress;
                DoctorToUpdate.AvailabilityModeId = entity.AvailabilityModeId;
                DoctorToUpdate.LicenseExpirationDate = entity.LicenseExpirationDate;
                DoctorToUpdate.FirstName = entity.FirstName;
                DoctorToUpdate.LastName = entity.LastName;
                DoctorToUpdate.PhoneNumber = entity.PhoneNumber;
                DoctorToUpdate.IsActive = entity.IsActive;
                DoctorToUpdate.Email = entity.Email;
                DoctorToUpdate.UpdatedAt = entity.UpdatedAt;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando los datos";
                logger.LogError(result.Message, ex.ToString());
            }


            return result;
        }
        public async override Task<OperationResult<bool>> Remove(Doctors entity)
        {
            OperationResult<bool> result = new OperationResult<bool>();
            if (entity == null)
            {
                result.Success = false;
                result.Message = "La entidad es requerida";
                return result;
            }
            if (entity.ID == 0)
            {
                result.Success = false;
                result.Message = "La entidad es requerida";
                return result;
            }
            var filter = await base.Exists(d => d.ID == entity.ID);
            if (filter.Success)
            {
                try
                {
                    base.Remove(entity);
                    result.Success = true;
                    result.Message = "Eliminado correctamente";
                }
                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = "No fue posible eliminar la data";
                    logger.LogError(result.Message, ex.ToString());
                }

            }
            return result;
        }

        /*public async override Task<OperationResult<List<DoctorMoodule>>> GetAll()
        {
            OperationResult<List<DoctorMoodule>> result = new OperationResult<List<DoctorMoodule>>();
            try
            {
                result.Data = await (from d in _medicalappointmentContext.Doctors
                                     select new DoctorMoodule()
                                     {
                                         DoctorID = d.ID
                                     }).ToListAsync();
            }
            catch 
            {
            
            }


            return result;
        }*/
    }
}
