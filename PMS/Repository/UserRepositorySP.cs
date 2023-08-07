using Microsoft.Data.SqlClient;
using System.Data;
using PMS.Data;
using PMS.Models;
using Dapper;

namespace ProjectRecord4_API.Repository
{
    public class UserRepositorySP : IUserRepository
    {
        private IDbConnection db;

        public UserRepositorySP(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("ProjectRecordConnection"));

        }
        public User Add(User user)
        {
            var p = new DynamicParameters();
            p.Add("@id", 0, DbType.Int32);
            p.Add("@UserId", user.UserId);
            p.Add("@UserName", user.UserName);
            p.Add("@Password", user.Password);
            this.db.Execute("usp_AddUser",p,commandType: CommandType.StoredProcedure);
            user.id = p.Get<int>("id");
            return user;
        }

        public User Find(int id)
        {
            return db.Query<User>("usp_GetUser",new { id = id}, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public List<User> GetAll()
        {
            return db.Query<User> ("usp_GetALLUsers",commandType: CommandType.StoredProcedure).ToList();
        }

        public void Remove(int id)
        {
             db.Query<User>("usp_RemoveUser", new { id = id }, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public User Update(User user)
        {
            var p = new DynamicParameters();
            p.Add("@id", user.id, DbType.Int32);
            p.Add("@UserId", user.UserId);
            p.Add("@UserName", user.UserName);
            p.Add("@Password", user.Password);
            this.db.Execute("usp_UpdateUser", p, commandType: CommandType.StoredProcedure);
            user.id = p.Get<int>("id");
            return user;
        }
    }
}
