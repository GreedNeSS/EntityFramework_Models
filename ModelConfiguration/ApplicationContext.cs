using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelConfiguration.Models;
using ModelConfiguration.Configurations;

namespace ModelConfiguration
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Company> Companies => Set<Company>();

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=testdb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Вариант #1
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());

            // Вариант #2
            //modelBuilder.Entity<User>(UserConfigure);
            //modelBuilder.Entity<Company>(CompanyConfigure);
        }

        // Вариант #2
        private void UserConfigure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("People").Property(u => u.Name).IsRequired();
            builder.Property(u => u.Id).HasColumnName("User_id");
        }

        // Вариант #2
        private void CompanyConfigure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Enterprises").Property(c => c.Title).IsRequired();
        }
    }
}
