using Domain.Abstract;
using Domain.Entities;

namespace Domain.Repositories;

public interface IStudentRepository : IDbGuidRepository<Student>
{
    
}