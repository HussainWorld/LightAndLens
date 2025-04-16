using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class RentalTransaction
    {
        public RentalTransaction()
        {
            RentalItems = new HashSet<RentalItem>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("RentalID")]
        public int RentalId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal RentalFee { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? DepositPaid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [Column("RequestID")]
        public int RequestId { get; set; }

        [ForeignKey("RequestId")]
        [InverseProperty("RentalTransactions")]
        public virtual RentalRequest Request { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("RentalTransactions")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("Rental")]
        public virtual ICollection<RentalItem> RentalItems { get; set; }
        [InverseProperty("Rental")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
