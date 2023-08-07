using PMS.Data;
using PMS.Models;

namespace ProjectRecord4_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public User Add(User user)
        {
            _db.Add(user);
            _db.SaveChanges();
            return user;
        }

        public User Find(int id)
        {
            return _db.User.FirstOrDefault(user=>user.id == id);
        }

        public List<User> GetAll()
        {
            return _db.User.ToList();
        }

        public void Remove(int id)
        {
            User user = _db.User.FirstOrDefault(user=>user.id == id);
        }

        public User Update(User user)
        {
            _db.Update(user);
            _db.SaveChanges();
            return user;
        }
    }
}
