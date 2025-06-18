using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;

namespace Database.Repositories;

public class TeacherRepository :  DbGuidRepository<Teacher>, ITeacherRepository 
{
    public TeacherRepository(DbContext context) : base(context)
    {
    }
}