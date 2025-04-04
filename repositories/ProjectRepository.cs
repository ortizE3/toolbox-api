using interfaces.Repositories;
using models.Projects;
using toolbox_api.Data;

namespace repositories
{
    public class ProjectRepository: IProjectRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProjectRepository(AppDbContext appDbContext) 
        { 
            _appDbContext = appDbContext;
        }


        public async Task<Project> CreateProject(Project request)
        {
            var project = await _appDbContext.Projects.AddAsync(request);
            await _appDbContext.SaveChangesAsync();
            return project.Entity;
        }

        public IEnumerable<Project> GetProjects(string userId)
        {
            var projects = _appDbContext.Projects.Where(x => x.UserId == userId).ToList();

            return projects;
        }
    }
}
