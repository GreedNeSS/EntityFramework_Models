using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RequiredProperty.Models
{
    internal class User
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Company { get; set; }
        public string Country { get; set; } = "";
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
