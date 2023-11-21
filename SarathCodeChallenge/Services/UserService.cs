using SarathCodeChallenge.Database;
using SarathCodeChallenge.Entites;
using System.Security.Claims;

namespace SarathCodeChallenge.Services
{
    public class UserService : IUserService
    {
        private readonly MyContext context = null;
        public UserService (MyContext context)
        {
            context = context;
        }

        internal static void AddUser(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateUser(object user)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                if(user != null)
                {
                    context.Users.Update(user);
                    context.SaveChanges ();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User ValidateUser(string UserEmail, string Password)
        {
           return context.Users.SingleOrDefault(u=>u.UserEmail== u.UserEmail && u.Password== Password);
        }

        public User ValidteUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
