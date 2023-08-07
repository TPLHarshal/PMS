using Microsoft.EntityFrameworkCore;
using PMS.Models;

namespace PMS.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }

      
    }
}
