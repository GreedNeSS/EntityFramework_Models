using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConstructor.Models
{
    internal class Address
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public int Home { get; set; }

        public Address(string street, int home)
        {
            Street = street;
            Home = home;
            Console.WriteLine("Called ctor Address");
        }

        public override string ToString()
        {
            return $"{Street} {Home}";
        }
    }
}
