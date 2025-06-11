using Microsoft.EntityFrameworkCore;
using SOHome.Cooking.Entities;

namespace SOHome.Cooking.Data;

public class CookingDbContext(DbContextOptions<CookingDbContext> options) : DbContext(options)
{
    public DbSet<Recipe> Recipes => Set<Recipe>();
    public DbSet<Ingredient> Ingredients => Set<Ingredient>();
    public DbSet<Step> Steps => Set<Step>();
    public DbSet<Photo> Photos => Set<Photo>();
}