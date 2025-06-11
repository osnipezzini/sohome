namespace SOHome.Cooking.Entities;

/// <summary>
/// Represents a single instruction (a step) within a preparation stage.
/// </summary>
public class Step
{
    /// <summary>
    /// The order number of the step to ensure the correct sequence.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// The description of the instruction to be performed.
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// An optional photo illustrating this specific step.
    /// </summary>
    public Photo? Photo { get; set; } 
}