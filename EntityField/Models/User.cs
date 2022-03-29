using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityField.Models
{
    internal class User
    {
        private string name;
        private int id;
        private int age;

        public int Id => id;
        public int Age => age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {name}, Age: {Age}";
        }
    }
}
