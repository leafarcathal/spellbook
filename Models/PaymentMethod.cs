using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace Spellbook.Models
{
    public class PaymentMethod
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [CreditCard]
        public string Card_Token { get; set; }
        public string Card_Bin { get; set; }
        public string Card_Ending { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }

    }
}
