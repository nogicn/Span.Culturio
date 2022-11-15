using Span.Culturio.Api.Models;

namespace Span.Culturio.Api.Services.Auth
{
    public interface IAuthService
    {
        Task<UserDto> registerUser(UserDto registeruserdto);
        Task<LoginDto> loginUser(LoginDto logindto);
    }
}
