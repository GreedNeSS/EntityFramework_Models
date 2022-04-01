using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenerateProperties.Models;

namespace GenerateProperties
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<Person> People => Set<Person>();

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
            //modelBuilder.Entity<Person>().Property(p => p.Id).ValueGeneratedNever(); // отмена автогенерации Id
            modelBuilder.Entity<Person>().Property(p => p.Age).HasDefaultValue(30);
            modelBuilder.Entity<Person>().Property(p => p.FirstName).HasDefaultValue("Marcus");
            modelBuilder.Entity<Person>().Property(p => p.LastName).HasDefaultValue("Aurelius");
            modelBuilder.Entity<Person>().Property(p => p.CreatedAt).HasDefaultValueSql("DATETIME('now')");
            modelBuilder.Entity<Person>().Property(p => p.Name).HasComputedColumnSql("FirstName || ' ' || LastName");
        }
    }
}
