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
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentLog> PaymentLog { get; set; }
        public DbSet<JwtToken> JwtToken { get; set; }
    }
}
