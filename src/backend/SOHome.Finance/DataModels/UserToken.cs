
namespace SOHome.Finance.DataModels;

public class UserToken
{
    public required string AccessToken { get; set; }
    public required string TokenType { get; set; } = "Bearer";
    public required string RefreshToken { get; set; }
    public required DateTimeOffset ExpiresAt { get; set; }
    public required DateTimeOffset RefreshExpiresAt { get; set; }
}