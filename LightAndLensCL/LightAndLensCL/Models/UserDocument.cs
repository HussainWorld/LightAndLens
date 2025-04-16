using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LightAndLensCL.Models
{
    public partial class UserDocument
    {
        [Key]
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; } = null!;
        [StringLength(250)]
        public string FileName { get; set; } = null!;
        [StringLength(50)]
        public string FileType { get; set; } = null!;
        public byte[] FileData { get; set; } = null!;
    }
}
