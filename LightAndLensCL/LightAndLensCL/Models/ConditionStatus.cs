using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class ConditionStatus
    {
        public ConditionStatus()
        {
            Equipment = new HashSet<Equipment>();
        }

        [Key]
        [Column("ConditionID")]
        public int ConditionId { get; set; }
        [StringLength(50)]
        public string ConditionName { get; set; } = null!;

        [InverseProperty("Condition")]
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
