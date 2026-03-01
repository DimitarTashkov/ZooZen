using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooZen.Models
{
    /// <summary>
    /// Връзка между потребител и роля (Many-to-Many)
    /// </summary>
    [PrimaryKey(nameof(UserId), nameof(RoleId))]
    public class UserRole
    {
        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public Guid RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; } = null!;
    }
}
