using System.ComponentModel.DataAnnotations;

namespace SOHome.Cooking.Entities;

/// <summary>
/// Defines the difficulty level of a recipe.
/// </summary>
public enum DifficultyLevel
{
    [Display( Name = "Fácil")]
    Easy,
    [Display( Name = "Média")]
    Medium,
    [Display( Name = "Difícil")]
    Hard,
    Chef
}