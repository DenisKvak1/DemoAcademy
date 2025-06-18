using Database.Context;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;

namespace Database.Repositories;

public class StudentRepository : DbGuidRepository<Student>, IStudentRepository
{
    public StudentRepository(AppDbContext context) : base(context)
    {
        
    }

    public async Task<bool> AddMarkAsync(Guid studentId, int value)
    {
        await _context.Set<Mark>().AddAsync(new Mark
        {
            StudentId = studentId,
            Value = value
        });
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task UpdateMark(Guid markId, int value)
    {
        await _context.Set<Mark>()
            .ExecuteUpdateAsync(x =>
                x.SetProperty(x => x.Value, value)
            );
        
    }

    public async Task DeleteMarkAsync(Guid markId)
    {
        await _context.Set<Mark>()
            .Where(x=> x.Id == markId)
            .ExecuteDeleteAsync();
    }
}