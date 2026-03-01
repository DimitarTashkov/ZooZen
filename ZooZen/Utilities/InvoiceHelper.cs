using ZooZen.Models;
using System.Text;

namespace ZooZen.Utilities
{
    /// <summary>
    /// Helper class for generating invoices in ZooZen
    /// </summary>
    public static class InvoiceHelper
    {
        public static string GenerateOrderInvoice(Order order)
        {
            var sb = new StringBuilder();
            sb.AppendLine("============ ZOOZEN INVOICE ============");
            sb.AppendLine($"Invoice #: {order.Id.ToString().Substring(0, 8).ToUpper()}");
            sb.AppendLine($"Date:      {order.OrderDate:dd.MM.yyyy HH:mm}");
            sb.AppendLine("------------------------------------------");
            sb.AppendLine("CUSTOMER DETAILS:");
            sb.AppendLine($"Name:    {order.CustomerName}");
            sb.AppendLine($"Phone:   {order.CustomerPhone}");
            sb.AppendLine($"Address: {order.CustomerAddress}");

            if (!string.IsNullOrEmpty(order.PromoCodeApplied))
            {
                sb.AppendLine($"Promo Code: {order.PromoCodeApplied}");
            }

            sb.AppendLine("------------------------------------------");
            sb.AppendLine("ITEMS:");

            foreach (var item in order.OrderItems)
            {
                string name = item.Product?.Name ?? "Unknown item";
                sb.AppendLine($"- {name,-20} x{item.Quantity}  ${item.UnitPrice * item.Quantity:F2}");
            }

            sb.AppendLine("------------------------------------------");
            sb.AppendLine($"TOTAL:                 ${order.TotalAmount:F2}");
            sb.AppendLine($"STATUS:                {(order.IsPaid ? "PAID" : "UNPAID")}");
            sb.AppendLine("==========================================");
            sb.AppendLine("Thank you for choosing ZooZen!");

            return sb.ToString();
        }
    }
}
