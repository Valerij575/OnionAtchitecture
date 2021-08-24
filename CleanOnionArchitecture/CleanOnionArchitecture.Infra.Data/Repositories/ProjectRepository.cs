using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanOnionArchitecture.Infra.Data.Context;
using System.Collections.Generic;

namespace CleanOnionArchitecture.Infra.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public readonly ProjectDbContext _context;

        public ProjectRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Project> GetProjects()
        {
            return _context.Projects;
        }
    }
}
