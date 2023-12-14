using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public double Preco { get; set; }
        public int Percentual { get; set; }
        public int Quantidade { get; set; }
        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
