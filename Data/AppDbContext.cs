using Microsoft.EntityFrameworkCore;
using Spellbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spellbook.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<Permission> Permission { get; set; }
    }
}
