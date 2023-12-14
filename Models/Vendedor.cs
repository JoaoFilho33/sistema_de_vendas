using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}