using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModel
{
    public class ProjectViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
    }
}
