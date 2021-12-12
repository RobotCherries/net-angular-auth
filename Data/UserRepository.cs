using System.Linq;
using NetAngularAuth.Data;
using NetAngularAuth.Models;

namespace NetAngularAuth.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public User Create(User user)
        {
            _userContext.Users.Add(user);
            user.Id = _userContext.SaveChanges();

            return user;
        }

        public User GetByEmail(string email)
        {
            return _userContext.Users.FirstOrDefault(user => user.Email == email);
        }
    }
}
