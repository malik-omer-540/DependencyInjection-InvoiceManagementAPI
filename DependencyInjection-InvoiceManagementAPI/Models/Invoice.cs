namespace DependencyInjection_InvoiceManagementAPI.Models
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
    }
}
