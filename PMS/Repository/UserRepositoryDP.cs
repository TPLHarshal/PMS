using Microsoft.Data.SqlClient;
using System.Data;
using PMS.Data;
using PMS.Models;
using Dapper;

namespace ProjectRecord4_API.Repository
{
    public class UserRepositoryDP : IUserRepository
    {
        private IDbConnection db;

        public UserRepositoryDP(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("ProjectRecordConnection"));

        }
        public User Add(User user)
        {
            var sqlquery = "Insert Into [dbo].[User] ([UserId],[UserName],[Password]) Values(@UserId,@UserName,@Password); "
                            + "Select Cast(Scope_Identity() as int);";
            var id = db.Query<int>(sqlquery ,user).Single();
            user.id = id;
            return user;
        }

        public User Find(int id)
        {
            var sqlquery = "SELECT *  FROM [dbo].[User] Where id = @id";
            return db.Query<User>(sqlquery, new { @id = id }).Single();
        }

        public List<User> GetAll()
        {
            var sqlquery = "Select * From [dbo].[User]";
            return db.Query<User> (sqlquery).ToList();
        }

        public void Remove(int id)
        {
            var sqlquery = "Delete [dbo].[User] Where id=@id";
            db.Execute(sqlquery,new {@id=id});


        }

        public User Update(User user)
        {
            var sqlquery = "  Update [dbo].[User] Set UserId=@UserId, UserName=@UserName,Password=@Password Where id = @id";
            db.Execute(sqlquery, user);
            return user;
        }
    }
}
