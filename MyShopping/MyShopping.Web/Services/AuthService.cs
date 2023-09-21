using MyShopping.Web.Models;
using MyShopping.Web.Service.Contract;
using MyShopping.Web.Services.Contract;
using MyShopping.Web.Utility;

namespace MyShopping.Web.Services
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;

        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                HttpMethod = HttpMethod.Post,
                Data = registrationRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/AssignRole",
            });
        }

        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                HttpMethod = HttpMethod.Post,
                Data = loginRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/login",
            });
        }

        public async Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registrationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                HttpMethod = HttpMethod.Post,
                Data = registrationRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/register",
            });
        }
    }
}
