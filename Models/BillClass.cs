using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace Spellbook.Models
{
    public class BillMethod
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string Uuid { get; set; }
        public float Amount { get; set; }
        public int Status { get; set; }
        [Required]
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime Due_at { get; set; } = DateTime.UtcNow;
        public DateTime Cancelled_at { get; set; } = DateTime.UtcNow;


    }
}
