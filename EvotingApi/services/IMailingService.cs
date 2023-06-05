using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvotingApi.services
{
    public interface IMailingService
    {
        Task SendEmailAsync(string mailTo, string subject, string body);
    }
}
