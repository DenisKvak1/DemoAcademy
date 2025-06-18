using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Database.Context;
using Database.Repositories;
using Domain.Repositories;

namespace WebApp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        var externalConnectionString = builder.Configuration.GetConnectionString("ExternalConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString, (optionsBuilder) =>
            {
                optionsBuilder.MigrationsAssembly("Migrations");
            });
        }); 
        builder.Services.AddDbContext<ExternalDbContext>(options =>
        {
            options.UseSqlServer(externalConnectionString, (optionsBuilder) =>
            {
                optionsBuilder.MigrationsAssembly("ExternalMigrations");
            });
        }); 
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        InjectRepository(builder.Services);
        
        builder.Services
            .AddIdentityCore<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddRoles<AppRole>()
            .AddEntityFrameworkStores<AppDbContext>();
        
        builder.Services
            .AddIdentityCore<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddRoles<AppRole>()
            .AddEntityFrameworkStores<ExternalDbContext>();
        
        
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        app.Run();
        
        // dotnet ef migrations add --project Migrations\Migrations.csproj --startup-project WebApp\WebApp.csproj --context Database.Context.AppDbContext Second
        // dotnet ef database update --context Database.Context.AppDbContext --project WebApp
    }

    private static void InjectRepository(IServiceCollection builderServices)
    {
        builderServices.AddScoped<IFacultyRepository, FacultyRepository>();
        builderServices.AddScoped<IGroupRepository, GroupRepository>();
        builderServices.AddScoped<IStudentRepository, StudentRepository>();
        builderServices.AddScoped<ITeacherRepository, TeacherRepository>();
    }
}
