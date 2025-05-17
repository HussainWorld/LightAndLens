using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class Log
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column(TypeName = "text")]
        public string Action { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        public User? User { get; set; }
    }
}
