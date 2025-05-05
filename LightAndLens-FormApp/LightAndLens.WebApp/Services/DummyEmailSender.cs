using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using System;

namespace LightAndLens.WebApp.Services
{
    public class DummyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            
            Console.WriteLine($"[DummyEmail] To: {email}, Subject: {subject}");
            return Task.CompletedTask;
        }
    }
}
