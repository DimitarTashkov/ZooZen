using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static ZooZen.Common.Constants.ValidationConstants.UserConstants;

namespace ZooZen.Models
{
    /// <summary>
    /// Потребител на системата ZooZen (Админ или Клиент)
    /// </summary>
    public class User
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
            this.UserRoles = new HashSet<UserRole>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(PasswordMaxLength)]
        public string PasswordHash { get; set; } = null!;

        [MaxLength(NameMaxLength)]
        public string? FirstName { get; set; }

        [MaxLength(NameMaxLength)]
        public string? LastName { get; set; }

        [MaxLength(PhoneMaxLength)]
        public string? Phone { get; set; }

        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
