using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace trabalho_final.Models
{
    public class Item
    {
        [Display(Name = "Codigo"), Key()]
        public int Id { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        [Display(Name = "Percentual")]
        public int Percentual { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Produto")]
        public Produto? Produto { get; set; }
        [Display(Name = "Produto"), Required(), ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public NotaDeVenda? NotaDeVenda { get; set; } = null!;
        [Display(Name = "Nota de Venda"), ForeignKey("NotaDeVenda")]
        public int? NotaDeVendaId { get; set; } = null!;
    }
}
