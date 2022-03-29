using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CreateIndex.Models;

namespace CreateIndex
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<Person> People { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PeopleDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasIndex(p => new { p.PassportSeria, p.PassportNumber });
            modelBuilder.Entity<Person>().HasIndex(p => p.Name).IsUnique().HasFilter("[Name] is not null");
        }
    }
}
