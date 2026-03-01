using ZooZen.Models;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;

namespace ZooZen.Services
{
    /// <summary>
    /// Service for invoice generation in ZooZen.
    /// Delegates to InvoiceHelper for creating text-based invoices.
    /// </summary>
    public class InvoiceService : IInvoiceService
    {
        public string GenerateInvoiceText(Order order)
        {
            return InvoiceHelper.GenerateOrderInvoice(order);
        }
    }
}
