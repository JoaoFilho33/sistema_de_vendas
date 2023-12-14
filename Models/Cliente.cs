using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class Cliente
    {
        [Display(Name = "Codigo"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
    }
}
