using NetAngularAuth.Models;

namespace NetAngularAuth.Data
{
    public interface IUserRepository
    {
        User Create(User user);
        User GetByEmail(string email);
    }
}
