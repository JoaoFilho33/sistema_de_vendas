using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;  // Adicionado para utilizar a anotação [Key]

namespace trabalho_final.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }
    }
}
