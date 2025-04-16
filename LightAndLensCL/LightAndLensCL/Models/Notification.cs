using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class Notification
    {
        [Key]
        [Column("NotificationID")]
        public int NotificationId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Message { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        public bool IsRead { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Notifications")]
        public virtual User User { get; set; } = null!;
    }
}
