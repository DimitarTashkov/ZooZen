using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooZen.Models
{
    /// <summary>
    /// Роля в системата: Admin или Client
    /// </summary>
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual ICollection<UserRole> RolesUsers { get; set; }
            = new HashSet<UserRole>();
    }
}
