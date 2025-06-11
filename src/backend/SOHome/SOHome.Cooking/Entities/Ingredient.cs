namespace SOHome.Cooking.Entities;

/// <summary>
/// Represents a single ingredient with its quantity and unit of measurement.
/// </summary>
public class Ingredient
{
    /// <summary>
    /// The name of the ingredient (e.g., "Flour").
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// The required amount of the ingredient. Using 'double' allows for fractions (e.g., 1.5).
    /// </summary>
    public double Quantity { get; set; }

    /// <summary>
    /// The unit of measurement (e.g., "cups", "g", "ml", "tablespoon").
    /// </summary>
    public required string Unit { get; set; }

    /// <summary>
    /// An optional note about the ingredient (e.g., "sifted", "at room temperature").
    /// </summary>
    public string? Notes { get; set; }
}