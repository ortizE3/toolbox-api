using interfaces.Helpers;
using interfaces.Manager;
using interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using models.Projects;

namespace managers
{
    public class ProjectManager: IProjectManager
    {
        IProjectMapper _projectMapper;
        IProjectRepository _projectRepository;
        public ProjectManager(IProjectRepository projectRepository, IProjectMapper projectMapper) 
        {
            _projectRepository = projectRepository;
            _projectMapper = projectMapper;
        }

        public async Task<Project> CreateProject(CreateProjectRequest request)
        {
            var project = _projectMapper.RequestToProject(request);
            return await _projectRepository.CreateProject(project);
        }


        public IEnumerable<Project> GetAllProjects(string userId)
        {
            return _projectRepository.GetProjects(userId);
        }
        
    }
}
