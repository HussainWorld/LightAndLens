using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            EquipmentImages = new HashSet<EquipmentImage>();
            RentalItems = new HashSet<RentalItem>();
        }

        [Key]
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EquipmentName { get; set; } = null!;
        [Column(TypeName = "text")]
        public string Description { get; set; } = null!;
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal RentalPricePerDay { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Equipment")]
        public virtual Category Category { get; set; } = null!;
        [InverseProperty("Equipment")]
        public virtual ICollection<EquipmentImage> EquipmentImages { get; set; }
        [InverseProperty("Equipment")]
        public virtual ICollection<RentalItem> RentalItems { get; set; }
    }
}
