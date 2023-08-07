using PMS.Models;

namespace ProjectRecord4_API.Repository
{
    public interface IUserRepository
    {

        User Find(int id);

        List<User> GetAll();

        User Add(User user);

        User Update(User user);

        void Remove(int id);
    }
}
