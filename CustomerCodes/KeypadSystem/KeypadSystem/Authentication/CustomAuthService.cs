using System.Security.Claims;

namespace KeypadSystem.Authentication
{
    public class CustomAuthService
    {
        public CustomAuthService()
        {
            Users = new Dictionary<string, ClaimsPrincipal>();
        }
        public Dictionary<string, ClaimsPrincipal> Users { get; set; }
    }
}
