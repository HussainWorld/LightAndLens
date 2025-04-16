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
            Feedbacks = new HashSet<Feedback>();
            RentalItems = new HashSet<RentalItem>();
            RentalRequests = new HashSet<RentalRequest>();
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
        [Column("ConditionID")]
        public int ConditionId { get; set; }
        [Column("AvailabilityID")]
        public int? AvailabilityId { get; set; }

        [ForeignKey("AvailabilityId")]
        [InverseProperty("Equipment")]
        public virtual AvailabilityStatus? Availability { get; set; }
        [ForeignKey("CategoryId")]
        [InverseProperty("Equipment")]
        public virtual Category Category { get; set; } = null!;
        [ForeignKey("ConditionId")]
        [InverseProperty("Equipment")]
        public virtual ConditionStatus Condition { get; set; } = null!;
        [InverseProperty("Equipment")]
        public virtual ICollection<EquipmentImage> EquipmentImages { get; set; }
        [InverseProperty("Equipment")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [InverseProperty("Equipment")]
        public virtual ICollection<RentalItem> RentalItems { get; set; }
        [InverseProperty("Equipment")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
    }
}
