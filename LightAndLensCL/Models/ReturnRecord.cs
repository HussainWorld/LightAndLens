using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class ReturnRecord
    {
        [Key]
        [Column("ReturnID")]
        public int ReturnId { get; set; }
        [Column("RentalID")]
        public int RentalId { get; set; }
        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ConditionStatus { get; set; } = null!;
        [Column(TypeName = "text")]
        public string? Notes { get; set; }

        [ForeignKey("RentalId")]
        [InverseProperty("ReturnRecords")]
        public virtual RentalTransaction Rental { get; set; } = null!;
    }
}
