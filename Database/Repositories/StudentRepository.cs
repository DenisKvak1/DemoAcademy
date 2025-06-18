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
}