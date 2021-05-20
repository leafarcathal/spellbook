using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace Spellbook.Models
{
    public class JwtToken
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string User_Id { get; set; }
        [Required]
        public string Token { get; set; }
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
        public DateTime Valid_Through { get; set; } = DateTime.UtcNow;


    }
}
