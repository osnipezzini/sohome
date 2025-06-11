using SOHome.Cooking.Entities;

namespace SOHome.Cooking.Repositories;

public interface IRecipeRepository
{
    Task<IEnumerable<Recipe>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Recipe?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Recipe> AddAsync(Recipe recipe, CancellationToken cancellationToken = default);
    Task<Recipe> UpdateAsync(Recipe recipe, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}