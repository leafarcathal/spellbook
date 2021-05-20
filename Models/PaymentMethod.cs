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
        public string CardToken { get; set; }
        public string CardBin { get; set; }
        public string CardEnding { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }

    }
}
