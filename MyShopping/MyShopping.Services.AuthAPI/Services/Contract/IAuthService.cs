using MyShopping.Services.AuthAPI.Models.Dto;

namespace MyShopping.Services.AuthAPI.Services.Contract
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);

        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);

        Task<bool> AssignRole(string email, string roleName);
    }
}
