using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects();
    }
}
