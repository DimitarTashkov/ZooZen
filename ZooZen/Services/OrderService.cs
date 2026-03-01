using Microsoft.EntityFrameworkCore;
using ZooZen.Data;
using ZooZen.Models;
using ZooZen.Services.Interfaces;

namespace ZooZen.Services
{
    /// <summary>
    /// Service for managing orders in ZooZen
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly ZooZenDbContext _context;

        public OrderService(ZooZenDbContext context)
        {
            _context = context;
        }

        public Order CreateOrder(Guid userId, string customerName, string customerPhone, string customerAddress,
            List<(Guid ProductId, int Quantity)> items, string? promoCode = null)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                OrderDate = DateTime.Now,
                CustomerName = customerName,
                CustomerPhone = customerPhone,
                CustomerAddress = customerAddress,
                PromoCodeApplied = promoCode,
                IsPaid = false
            };

            decimal totalAmount = 0;

            foreach (var (productId, quantity) in items)
            {
                var product = _context.Products.Find(productId);
                if (product == null)
                    throw new Exception($"Product not found.");

                if (product.StockQuantity < quantity)
                    throw new Exception($"Insufficient stock for '{product.Name}'.");

                // Decrease stock quantity
                product.StockQuantity -= quantity;

                var orderItem = new OrderItem
                {
                    Id = Guid.NewGuid(),
                    OrderId = order.Id,
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = product.Price
                };

                order.OrderItems.Add(orderItem);
                totalAmount += product.Price * quantity;
            }

            // Apply promotional discount
            if (!string.IsNullOrEmpty(promoCode))
            {
                decimal discount = CalculateDiscount(promoCode, totalAmount);
                totalAmount -= discount;
            }

            order.TotalAmount = totalAmount;

            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public List<Order> GetOrdersByUserId(Guid userId)
        {
            return _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }

        public Order? GetOrderById(Guid orderId)
        {
            return _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefault(o => o.Id == orderId);
        }

        public void MarkOrderAsPaid(Guid orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                order.IsPaid = true;
                _context.SaveChanges();
            }
        }

        public void DeleteOrder(Guid orderId)
        {
            var order = _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefault(o => o.Id == orderId);

            if (order != null)
            {
                _context.OrderItems.RemoveRange(order.OrderItems);
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Calculate discount based on promo code
        /// </summary>
        private decimal CalculateDiscount(string promoCode, decimal totalAmount)
        {
            return promoCode.ToUpper() switch
            {
                "ZOOZEN10" => totalAmount * 0.10m,  // 10% discount
                "ZOOZEN20" => totalAmount * 0.20m,  // 20% discount
                "PETLOVER" => totalAmount * 0.15m,  // 15% discount
                _ => 0m
            };
        }
    }
}
