using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace Spellbook.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Bill_Id { get; set; }
        [Required]
        public string Uuid { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public string User_Id { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int Payment_Method_Id { get; set; }
        public string Payment_Token { get; set; }
        public string Payment_Api_Response { get; set; }
        public int Payment_Type { get; set; }
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
  

    }
}
