using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DefiningModels.Models
{
    [NotMapped]
    internal class Company
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
    }
}
