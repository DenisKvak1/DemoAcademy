using Domain.Abstract;
using Domain.Entities;

namespace Domain.Repositories;

public interface IStudentRepository : IDbGuidRepository<Student>
{
    Task<bool> AddMarkAsync(Guid studentId, int value);
    Task UpdateMark(Guid markId, int value);
    Task DeleteMarkAsync(Guid markId);
}