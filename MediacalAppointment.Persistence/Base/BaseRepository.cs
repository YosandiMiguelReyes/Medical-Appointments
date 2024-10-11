using MediacalAppointment.Domain.Repositories;
using MediacalAppointment.Domain.Results;
using MediacalAppointment.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MediacalAppointment.Persistence.Base
{
    //In this class I´ll have all the basic(CRUD) funtions implemented
    public abstract class BaseRepository<TEntity, TType> : IBaseRepository<TEntity, TType> where TEntity : class where TType : IEquatable<TType>
    {
        private readonly MedicalAppointmentContext _medicalAppointmentContext;
        private DbSet<TEntity> entities;
        public BaseRepository(MedicalAppointmentContext medicalAppointmentContext)
        {
            _medicalAppointmentContext = medicalAppointmentContext;
            //Set<TEntity> helps us to save the changes in the DB the is storage in the DbContext 
            this.entities = _medicalAppointmentContext.Set<TEntity>();
        }

        public virtual async Task<OperationResult<bool>> Exists(Expression<Func<TEntity, bool>> filter)
        {
            //La instancia no es necesaria
            OperationResult<bool> result = new OperationResult<bool>();
            try
            {
                var exists = await this.entities.AnyAsync(filter);
                result.Data = exists;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ha ocurrido el siguiente error verificando que existe el registro\n {ex.Message}";
            }
            return result;

        }

        public virtual async Task<OperationResult<List<TEntity>>> GetAll()
        {
            OperationResult<List<TEntity>> result = new OperationResult<List<TEntity>>();

            try
            {
                var data = await this.entities.ToListAsync();
                result.Data = data;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ha ocurrido el siguiente error obteniendo los registros\n {ex.Message}";
            }
            return result;
        }

        public virtual async Task<OperationResult<TEntity>> GetEntityById(TType Id)
        {
            OperationResult<TEntity> result = new OperationResult<TEntity>();
            try
            {
                var entity = await this.entities.FindAsync(Id);
                result.Data = entity;
            }
            catch (Exception ex)
            {
                result.Message = $"Ha ocurrido el siguiente error obteniendo el registro\n {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public virtual async Task<OperationResult<bool>> Remove(TEntity entity)
        {
            OperationResult<bool> result = new OperationResult<bool>();
            try
            {
                this.entities.Remove(entity);
                await _medicalAppointmentContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ha ocurrido el siguiente error removiendo el registro\n {ex.Message}";
            }
            return result;
        }

        public virtual async Task<OperationResult<TEntity>> Update(TEntity entity)
        {
            OperationResult<TEntity> result = new OperationResult<TEntity>();
            try
            {
                var data = this.entities.Update(entity);
                await _medicalAppointmentContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ha ocurrido el siguiente error actualizando el registro\n {ex.Message}";
            }
            return result;
        }

        public virtual async Task<OperationResult<bool>> Add(TEntity entity)
        {
            OperationResult<bool> result = new OperationResult<bool>();
            try
            {
                this.entities.Add(entity);
                await _medicalAppointmentContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ha ocurrido el siguiente error agregando el registro\n {ex.Message}";
            }
            return result;
        }
    }
}
