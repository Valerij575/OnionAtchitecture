using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IProjectService
    {
        ProjectViewModel GetProjects();
    }
}
