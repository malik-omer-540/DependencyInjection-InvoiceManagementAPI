namespace DependencyInjection_InvoiceManagementAPI.Services.Interfaces
{
    public interface INotificationService
    {
        void SendNotification(string to, string message);
    }
}
