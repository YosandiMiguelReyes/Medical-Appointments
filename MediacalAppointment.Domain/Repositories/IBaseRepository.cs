
using MediacalAppointment.Domain.Results;
using System.Linq.Expressions;

namespace MediacalAppointment.Domain.Repositories
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class where TType : IEquatable<TType>
    {
        Task<OperationResult<TEntity>> Update(TEntity entity);
        Task<OperationResult<TEntity>> Remove(TEntity entity);
        Task<OperationResult<TEntity>> GetAll();
        Task<OperationResult<TEntity>> GetEntityById(TType Id);
        Task<OperationResult<TEntity>> Exists(Expression<Func<TEntity, bool>> predicate);
    }
}
