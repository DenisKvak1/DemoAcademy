using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database.Context;

public class ExternalDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public ExternalDbContext(DbContextOptions<ExternalDbContext> options) : base(options)
    {
    }
    
    public ExternalDbContext() : base()
    {
    }
}