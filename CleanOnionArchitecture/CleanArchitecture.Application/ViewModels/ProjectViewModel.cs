using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public class ProjectViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
    }
}
