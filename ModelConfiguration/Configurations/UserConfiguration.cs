using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelConfiguration.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModelConfiguration.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("People").Property(u => u.Name).IsRequired();
            builder.Property(u => u.Id).HasColumnName("User_Id");
        }
    }
}
