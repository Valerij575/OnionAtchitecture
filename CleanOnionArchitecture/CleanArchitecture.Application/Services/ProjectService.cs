using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
    public class ProjectService : IProjectService
    {
        public readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public ProjectViewModel GetProjects()
        {
            return new ProjectViewModel
            {
                Projects = _projectRepository.GetProjects()
            };
        }
    }
}
