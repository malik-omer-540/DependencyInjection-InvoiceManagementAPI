using DependencyInjection_InvoiceManagementAPI.Services.Interfaces;

namespace DependencyInjection_InvoiceManagementAPI.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string to, string message)
        {
            Console.WriteLine($"Sending Email to {to}: {message}");
        }
    }
}
