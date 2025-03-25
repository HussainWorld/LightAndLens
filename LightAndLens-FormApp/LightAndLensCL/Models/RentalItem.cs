using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class RentalItem
    {
        [Key]
        [Column("RentalItemID")]
        public int RentalItemId { get; set; }
        [Column("RentalID")]
        public int RentalId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Subtotal { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("RentalItems")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("RentalId")]
        [InverseProperty("RentalItems")]
        public virtual RentalTransaction Rental { get; set; } = null!;
    }
}
