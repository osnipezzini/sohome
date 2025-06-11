namespace SOHome.Cooking.Entities;

/// <summary>
/// Represents a photo associated with a recipe or a specific step.
/// </summary>
public class Photo
{
    /// <summary>
    /// The URL of the image. Can be a local path or a web URL.
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// Alternative text or caption for the photo, useful for accessibility and context.
    /// </summary>
    public required string Caption { get; set; }
}