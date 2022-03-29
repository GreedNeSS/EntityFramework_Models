using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CreateIndex.Models
{
    [Index("Id", "Age")]
    [Index("PhoneNumber", IsUnique = true, Name = "Phone_Index")]
    internal class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PassportSeria { get; set; }
        public string? PassportNumber { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}){Name} - {PassportSeria}/{PassportNumber}";
        }
    }
}
