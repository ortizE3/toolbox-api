using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Projects;

namespace interfaces.Repositories
{
    public interface IProjectRepository
    {
        Task<Project> CreateProject(Project request);
        IEnumerable<Project> GetProjects(string userId);
        Task DeleteProject(string projectId);
        Task EditProject(Project updatedProject);
        List<Project> QueryProjects(QueryProjectsRequest queryProjectsRequest);
    }
}
