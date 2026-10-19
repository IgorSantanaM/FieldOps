using FieldOps.Domain.Core.Model;

namespace FieldOps.Domain.Core.Data
{
    public interface IRepository<T, TId> where T : IAggregateRoot, new() where TId : notnull
    {
        Task<TId> AddAsync(T entity, CancellationToken cancellationToken = default);
        void Update(T entity, CancellationToken cancellationToken = default);
        void Delete(T entity, CancellationToken cancellationToken = default); 
    }
}
