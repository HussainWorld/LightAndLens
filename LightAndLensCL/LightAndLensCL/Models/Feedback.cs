using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        [Column("FeedbackID")]
        public int FeedbackId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        public int Rating { get; set; }
        [Column(TypeName = "text")]
        public string? Comments { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("Feedbacks")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Feedbacks")]
        public virtual User User { get; set; } = null!;
    }
}
