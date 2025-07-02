using DependencyInjection_InvoiceManagementAPI.DTOs;
using DependencyInjection_InvoiceManagementAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection_InvoiceManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadInvoiceController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateInvoice([FromBody] InvoiceDto dto)
        {
            // Directly instantiating dependencies (BAD PRACTICE)
            var emailService = new EmailNotificationService();
            var invoiceService = new InvoiceService(emailService);
            invoiceService.CreateInvoice(dto);

            return Ok("Invoice created (bad code path).");
        }
    }
}
