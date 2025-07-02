using DependencyInjection_InvoiceManagementAPI.DTOs;
using DependencyInjection_InvoiceManagementAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection_InvoiceManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodInvoiceController : ControllerBase
    {
        private readonly InvoiceService _invoiceService;

        public GoodInvoiceController(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public IActionResult CreateInvoice([FromBody] InvoiceDto dto)
        {
            _invoiceService.CreateInvoice(dto);
            return Ok("Invoice created (clean DI path).");
        }
    }
}
