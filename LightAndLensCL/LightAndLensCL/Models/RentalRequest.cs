using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class RentalRequest
    {
        public RentalRequest()
        {
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        [Column("RequestID")]
        public int RequestId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [Column(TypeName = "date")]
        public DateTime RequestStartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime RequestEndDate { get; set; }
        [Column("RequestStatusID")]
        public int RequestStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestSetDate { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("RentalRequests")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("RequestStatusId")]
        [InverseProperty("RentalRequests")]
        public virtual RequestStatus RequestStatus { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("RentalRequests")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("Request")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
