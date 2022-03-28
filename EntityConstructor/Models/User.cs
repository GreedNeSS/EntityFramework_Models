using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityConstructor.Models
{
    internal class User
    {
        private int age;

        public int Id { get; set; }
        public string? Name { get; set; }
        public Address? Address { get; set; }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Called ctor User");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
