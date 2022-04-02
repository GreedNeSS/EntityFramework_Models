using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ModelConfiguration.Configurations;
//using Microsoft.EntityFrameworkCore;

namespace ModelConfiguration.Models
{
    // Вариант #3
    //[EntityTypeConfiguration(typeof(CompanyConfiguration))]
    internal class Company
    {
        public int Id { get; set; }
        public string? Title { get; set; }
    }
}
