namespace SOHome.Cooking.Entities;

/// <summary>
/// Represents a stage of the recipe (e.g., "Dough", "Frosting", "Assembly").
/// It groups a set of ingredients and the steps for that stage's preparation.
/// </summary>
public class Stage
{
    /// <summary>
    /// The title of the stage (e.g., "Preparing the Dough").
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// A list of ingredients required specifically for this stage.
    /// </summary>
    public List<Ingredient> Ingredients { get; set; } = [];

    /// <summary>
    /// An ordered list of steps to complete this stage.
    /// </summary>
    public List<Step> Steps { get; set; } = [];
}