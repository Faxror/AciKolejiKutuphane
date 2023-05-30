using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Context
{
    public class KContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-I45D279;database=AciKolejiKağıthane; Integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>()
    .HasOne(s => s.school)
    .WithMany()
    .HasForeignKey(s => s.SchoolID);
            builder.Entity<Records>()
               .HasKey(s => s.RecordID);
            builder.Entity<IdentityUserLogin<string>>().HasNoKey();
            builder.Entity<IdentityUserRole<string>>().HasNoKey();
            builder.Entity<IdentityUserToken<string>>().HasNoKey();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Records> Records { get; set; }
        public DbSet<school> Schools { get; set; }
    }
}
