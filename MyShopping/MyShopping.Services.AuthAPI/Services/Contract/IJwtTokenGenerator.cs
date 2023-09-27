using MyShopping.Services.AuthAPI.Models;

namespace MyShopping.Services.AuthAPI.Services.Contract
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
