using PMS.Models;

namespace ProjectRecord4_API.Repository
{
    public interface IProjectRepository
    {
        Project Find(int id);

        List<Project> GetAll();

        Project Add(Project project);

        Project Update(Project project);

        void Remove(int id);
    }
}
