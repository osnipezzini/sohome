using Microsoft.EntityFrameworkCore;
using SOHome.Cooking.Data;
using SOHome.Cooking.Entities;

namespace SOHome.Cooking.Repositories.Impl;

internal class RecipeRepositoryImpl(CookingDbContext dbContext) : IRecipeRepository
{
    private readonly CookingDbContext _dbContext = dbContext;

    public async Task<IEnumerable<Recipe>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Recipes
            .AsNoTracking()
            .ToArrayAsync(cancellationToken);
    }

    public async Task<Recipe?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Recipes
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
    }

    public async Task<Recipe> AddAsync(Recipe recipe, CancellationToken cancellationToken = default)
    {
        _dbContext.Recipes.Add(recipe);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return recipe;
    }

    public async Task<Recipe> UpdateAsync(Recipe recipe, CancellationToken cancellationToken = default)
    {
        _dbContext.Recipes.Update(recipe);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return recipe;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        await _dbContext.Recipes
            .Where(recipe => recipe.Id == id)
            .ExecuteDeleteAsync(cancellationToken);
    }
}