using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Spellbook.Models
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Controller { get; set; }
        [Required]
        public string Method { get; set; }
        public int UserGroupId { get; set; }
        public DateTime Created_at { get; set; } = DateTime.UtcNow;
    }
}
