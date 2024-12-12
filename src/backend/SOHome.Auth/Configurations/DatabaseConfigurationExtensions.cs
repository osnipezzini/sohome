using Microsoft.EntityFrameworkCore;
using SOHome.Auth.Data;

namespace SOHome.Auth.Configurations;

public static class DatabaseConfigurationExtensions
{
    public static void AddDatabaseConfiguration(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connectionString));

    }
}