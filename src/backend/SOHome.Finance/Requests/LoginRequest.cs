using MediatR;
using SOHome.Finance.DataModels;

namespace SOHome.Finance.Requests;
public class LoginRequest : IRequest<UserToken>
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public string? TOTP { get; set; }
}