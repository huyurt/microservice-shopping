using Microsoft.AspNetCore.Identity;

namespace MyShopping.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
