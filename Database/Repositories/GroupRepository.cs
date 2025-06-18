using Database.Context;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using Domain.Entities;
using Domain.Repositories;

namespace Database.Repositories;

public class GroupRepository : DbGuidRepository<Group>, IGroupRepository
{
    public GroupRepository(AppDbContext context) : base(context)
    {
    }
}