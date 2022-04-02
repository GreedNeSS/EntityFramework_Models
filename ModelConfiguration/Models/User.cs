using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ModelConfiguration.Configurations;
//using Microsoft.EntityFrameworkCore;

namespace ModelConfiguration.Models
{
    //[EntityTypeConfiguration(typeof(UserConfiguration))]
    internal class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
