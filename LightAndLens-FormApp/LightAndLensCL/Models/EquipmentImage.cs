using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class EquipmentImage
    {
        [Key]
        [Column("ImageID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string ImagePath { get; set; } = null!;
        public bool? IsMain { get; set; }
        public byte[]? ImageData { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("EquipmentImages")]
        public virtual Equipment Equipment { get; set; } = null!;
    }
}
