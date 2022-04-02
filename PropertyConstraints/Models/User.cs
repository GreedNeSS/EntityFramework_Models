using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PropertyConstraints.Models
{
    internal class User
    {
        private int age;

        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(2)]
        public string? Name { get; set; }
        public string? Address { get; set; }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Address: {Address}";
        }
    }
}
