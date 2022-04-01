using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateProperties.Models
{
    internal class Person
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] // Отмена автогенерации ключа
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"{Id}){Name}. Аккаунт создан: {CreatedAt}";
        }
    }
}
