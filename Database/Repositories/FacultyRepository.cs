using Database.Context;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;

namespace Database.Repositories;

public class FacultyRepository : DbGuidRepository<Faculty>, IFacultyRepository
{
    public FacultyRepository(AppDbContext context) : base(context)
    {
    }
}