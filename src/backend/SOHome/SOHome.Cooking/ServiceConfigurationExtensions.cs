using Microsoft.EntityFrameworkCore;
using SOHome.Cooking.Data;
using SOHome.Cooking.Repositories;
using SOHome.Cooking.Repositories.Impl;

namespace SOHome.Cooking;

public static class ServiceConfigurationExtensions
{
    public static void AddSOHomeCooking(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("CookingDb");
        services.AddDbContext<CookingDbContext>(options => 
            options.UseNpgsql(connectionString, b => 
                b.MigrationsAssembly(typeof(CookingDbContext).Assembly.FullName)).UseSnakeCaseNamingConvention());
        
        services.AddScoped<IRecipeRepository, RecipeRepositoryImpl>();
    }
    public static void UseSOHomeCooking(this IApplicationBuilder _)
    {
    }
}
