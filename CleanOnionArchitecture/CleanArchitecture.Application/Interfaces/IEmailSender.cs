using SendGrid;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IEmailSender
    {
        Task<Response> SendEmailAsync(string email, string subject, string message);
        Task<Response> Execute(string apiKey, string subject, string message, string email);
    }
}
