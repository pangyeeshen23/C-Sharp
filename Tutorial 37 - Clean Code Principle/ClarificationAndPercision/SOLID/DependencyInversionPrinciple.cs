using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarificationAndPercision.SOLID
{
    class DependencyInversionPrinciple
    {
        public static void Main()
        {
            IEmailService emailService = new EmailService();
            Notification notification = new Notification(emailService);
            IEmailService mockService = new MockEmailService();
            Notification mockNoticiation = new Notification(mockService);
            notification.Send("Hello, this is a test notification.");
        }
    }

    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to} with subject {subject}");
        }
    }

    public class Notification
    {
        private readonly IEmailService _emailService;
        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Send(string message)
        {
            _emailService.SendEmail("user@example.com", "Notification", message);
        }
    }

    public class MockEmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Mock email sent to {to} with subject {subject}");
        }
    }
}
