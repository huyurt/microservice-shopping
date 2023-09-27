using MyShopping.Web.Services.Contract;
using MyShopping.Web.Utility;

namespace MyShopping.Web.Services
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Response.Cookies.Delete(SD.TokenCookie);
        }

        public string? GetToken()
        {
            if (_contextAccessor.HttpContext?.Request.Cookies.TryGetValue(SD.TokenCookie, out var cookie) ?? false)
            {
                return cookie;
            }
            return null;
        }

        public void SetToken(string token)
        {
            _contextAccessor.HttpContext?.Response.Cookies.Append(SD.TokenCookie, token);
        }
    }
}
