namespace Todooo.Services
{
    public interface IAuthService
    {
        bool Login(string Email, string Password);
    }

    public class AuthService : IAuthService
    {
        public bool Login(string Email, string Password)
        {
            return LoginService.Reverse(Email) == Password;
        }
    }
}
