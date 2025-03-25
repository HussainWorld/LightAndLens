using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    [Index("CategoryName", Name = "IX_Categories", IsUnique = true)]
    public partial class Category
    {
        public Category()
        {
            Equipment = new HashSet<Equipment>();
        }

        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CategoryName { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
