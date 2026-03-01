using ZooZen.Models;

namespace ZooZen.Services.Interfaces
{
    /// <summary>
    /// ????????? ?? ?????????? ?? ??????? ? ZooZen
    /// </summary>
    public interface IOrderService
    {
        Order CreateOrder(Guid userId, string customerName, string customerPhone, string customerAddress,
            List<(Guid ProductId, int Quantity)> items, string? promoCode = null);
        List<Order> GetOrdersByUserId(Guid userId);
        List<Order> GetAllOrders();
        Order? GetOrderById(Guid orderId);
        void MarkOrderAsPaid(Guid orderId);
        void DeleteOrder(Guid orderId);
    }
}
