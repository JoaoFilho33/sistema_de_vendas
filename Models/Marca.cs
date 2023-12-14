using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
