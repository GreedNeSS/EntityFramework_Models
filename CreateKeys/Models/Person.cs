using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CreateKeys.Models
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PassportSeria { get; set; }
        public string? PassportNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}){Name} - {PassportSeria}/{PassportNumber}";
        }
    }
}
