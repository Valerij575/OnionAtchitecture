using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanOnionArchitecture.Infra.Data.Context
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
    }
}
