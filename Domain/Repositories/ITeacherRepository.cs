using Domain.Abstract;
using Domain.Entities;

namespace Domain.Repositories;

public interface ITeacherRepository  : IDbGuidRepository<Teacher>
{
    
}