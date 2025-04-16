using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class RequestStatus
    {
        public RequestStatus()
        {
            RentalRequests = new HashSet<RentalRequest>();
        }

        [Key]
        [Column("RequestStatusID")]
        public int RequestStatusId { get; set; }
        [StringLength(50)]
        public string StatusName { get; set; } = null!;

        [InverseProperty("RequestStatus")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
    }
}
