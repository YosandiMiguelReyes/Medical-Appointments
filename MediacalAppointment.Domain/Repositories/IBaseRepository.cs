
using MediacalAppointment.Domain.Results;
using System;
using System.Formats.Tar;
using System.Linq.Expressions;

namespace MediacalAppointment.Domain.Repositories
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        Task<OperationResult> Update(TEntity entity);
        Task<OperationResult> Remove(TEntity entity);
        Task<OperationResult> GetAll();
        Task<OperationResult> GetEntityById(TType Id);
        Task<OperationResult> Exists(Expression<Func<TEntity, bool>> predicate);
    }
}
