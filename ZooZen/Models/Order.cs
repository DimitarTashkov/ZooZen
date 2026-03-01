using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooZen.Models
{
    /// <summary>
    /// Поръчка в зоомагазина ZooZen
    /// </summary>
    public class Order
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public virtual User User { get; set; } = null!;

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalAmount { get; set; }

        /// <summary>Име на клиента при поръчка</summary>
        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>Телефон на клиента при поръчка</summary>
        [Required]
        [MaxLength(20)]
        public string CustomerPhone { get; set; } = string.Empty;

        /// <summary>Адрес за доставка</summary>
        [Required]
        [MaxLength(200)]
        public string CustomerAddress { get; set; } = string.Empty;

        /// <summary>Приложен промо код (ако има)</summary>
        public string? PromoCodeApplied { get; set; }

        /// <summary>Дали поръчката е платена</summary>
        public bool IsPaid { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}