using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InitializeFirstData.Models;

namespace InitializeFirstData
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
            Company microsoft = new Company { Id = 1, Title = "Microsoft" };
            Company apple = new Company { Id = 2, Title = "Apple" };

            modelBuilder.Entity<Company>().HasData(microsoft, apple);
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Ruslan", Age = 30, CompanyId = microsoft.Id},
                new User { Id = 2, Name = "Marcus", Age = 45, CompanyId = microsoft.Id },
                new User { Id = 3, Name = "Henry", Age = 22, CompanyId = apple.Id });
        }
    }
}
