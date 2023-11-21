using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.Services
{
    public interface IUserService
    {
        void AddUser(User user);
        void UpdateUser(User user);
        User ValidateUser(String UserEmail, string Password);
        User ValidteUser(string email, string password);
    }
}
