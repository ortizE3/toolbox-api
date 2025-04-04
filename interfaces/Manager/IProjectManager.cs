using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Projects;

namespace interfaces.Manager
{
    public interface IProjectManager
    {
        Task<Project> CreateProject(CreateProjectRequest request);
        IEnumerable<Project> GetAllProjects(string userId);
        Task DeleteProject(string projectId);
        Task EditProject(Project updatedProject);
        List<Project> QueryProjects(QueryProjectsRequest queryProjectsRequest);
    }
}
