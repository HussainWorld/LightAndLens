using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class AvailabilityStatus
    {
        public AvailabilityStatus()
        {
            Equipment = new HashSet<Equipment>();
        }

        [Key]
        [Column("AvailabilityID")]
        public int AvailabilityId { get; set; }
        [StringLength(50)]
        public string AvailabilityStatusName { get; set; } = null!;

        [InverseProperty("Availability")]
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
