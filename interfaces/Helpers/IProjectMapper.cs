

using models.Projects;

namespace interfaces.Helpers
{
    public interface IProjectMapper
    {
        Project RequestToProject(CreateProjectRequest createProjectRequest);
    }
}
