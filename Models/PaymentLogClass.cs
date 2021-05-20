using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Spellbook.Models
{
    public class PaymentLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Payment_Id { get; set; }
        [Required]
        public int Status { get; set; }
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
    }
}
