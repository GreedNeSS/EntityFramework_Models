using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MappingTablesAndColumns.Models;

namespace MappingTablesAndColumns
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> Users => Set<User>();

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=People.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("Users_1");
            //modelBuilder.Entity<User>().Property("Id").HasColumnName("Person_Id");
        }
    }
}
