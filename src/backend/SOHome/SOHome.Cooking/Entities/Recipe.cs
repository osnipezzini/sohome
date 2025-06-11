namespace SOHome.Cooking.Entities;

/// <summary>
/// The main class that represents a complete recipe.
/// </summary>
public class Recipe
{
    /// <summary>
    /// A unique identifier for the recipe (useful for databases).
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// The title of the recipe (e.g., "Grandma's Chocolate Cake").
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// A brief summary or introduction to the recipe.
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// A list of photos of the finished recipe. The first can be the main photo.
    /// </summary>
    public List<Photo> Photos { get; set; } = [];

    /// <summary>
    /// The total time required to prepare the recipe. TimeSpan is the ideal type for durations.
    /// </summary>
    public TimeSpan PreparationTime { get; set; }

    /// <summary>
    /// The yield of the recipe (e.g., "8 servings", "1 25cm cake").
    /// </summary>
    public required string Servings { get; set; }

    /// <summary>
    /// The difficulty level for preparation.
    /// </summary>
    public DifficultyLevel Difficulty { get; set; }

    /// <summary>
    /// The list of stages that make up the recipe.
    /// </summary>
    public List<Stage> Stages { get; set; } = [];
}