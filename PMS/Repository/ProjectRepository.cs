using PMS.Data;
using PMS.Models;

namespace ProjectRecord4_API.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _db;

        public ProjectRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Project Add(Project project)
        {
            _db.Add(project);
            _db.SaveChanges();
            return project;
        }

        public Project Find(int id)
        {
            return _db.Project.FirstOrDefault(project => project.id == id);
        }

        public List<Project> GetAll()
        {
            return _db.Project.ToList();
        }

        public void Remove(int id)
        {
            Project project = _db.Project.FirstOrDefault(project=>project.id == id);
        }

        public Project Update(Project project)
        {
            _db.Update(project);
            _db.SaveChanges();
            return project;
        }
    }
}
