using Abstract;

namespace Domain.Abstract;

public interface IDbGuidRepository<T> : IDbRepository<T, Guid>
where T:class, IDbEntity<Guid>
{
    
}