namespace DependencyInjection_InvoiceManagementAPI.DTOs
{
    public class InvoiceDto
    {
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
    }
}
