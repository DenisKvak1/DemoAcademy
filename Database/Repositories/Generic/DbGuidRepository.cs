using Domain.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Generic;

public class DbGuidRepository<T> : DbRepository<T, Guid>
where T:class, IDbEntity<Guid>
{
    public DbGuidRepository(DbContext context) : base(context)
    {
    }
}