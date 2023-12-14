using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class Vendedor
    {
        [ Display(Name = "Codigo"),Key()]
        public int Id { get; set; }
        [ Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;
    }
}