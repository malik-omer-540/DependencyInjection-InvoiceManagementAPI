using DependencyInjection_InvoiceManagementAPI.DTOs;
using DependencyInjection_InvoiceManagementAPI.Models;
using DependencyInjection_InvoiceManagementAPI.Services.Interfaces;

namespace DependencyInjection_InvoiceManagementAPI.Services
{
    public class InvoiceService
    {
        private readonly INotificationService _notificationService;

        public InvoiceService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void CreateInvoice(InvoiceDto dto)
        {
            var invoice = new Invoice
            {
                CustomerName = dto.CustomerName,
                Amount = dto.Amount,
                DueDate = dto.DueDate
            };

            // Simulate invoice persistence
            Console.WriteLine($"Invoice created for {invoice.CustomerName}");

            _notificationService.SendNotification(invoice.CustomerName, "Your invoice has been created.");
        }
    }
}
