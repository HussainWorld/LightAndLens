using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    [Index("Email", Name = "IX_Users", IsUnique = true)]
    public partial class User
    {
        public User()
        {
            Notifications = new HashSet<Notification>();
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string FullName { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string PasswordHash { get; set; } = null!;
        public int? PhoneNumber { get; set; }
        [Column("RoleID")]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; } = null!;
        [InverseProperty("User")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
