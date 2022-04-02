using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertyConstraints.Models;

namespace PropertyConstraints
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> Employee => Set<User>();

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=adonetdb;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasCheckConstraint("Age", "Age > 0 AND Age < 120"
                //, u => u.HasName("CK_User_Age")
                );
            modelBuilder.Entity<User>().Property(u => u.Name).HasMaxLength(30);
        }
    }
}
