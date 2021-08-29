using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanOnionArchitecture.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanOnionArchitecture.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddTransient<IEmailSender, EmailSender>();
        }
    }
}
