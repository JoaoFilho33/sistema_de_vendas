using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace trabalho_final.Models
{
    public class Produto
    {
        [Display(Name = "Codigo"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public int Quantidade { get; set; }
        [Display(Name = "Preço")]
        public string Nome { get; set; } = string.Empty;
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty;
        [Display(Name = "Quantidade")]
        public double Preco { get; set; }
        [Display(Name = "Marca")]
        public Marca? Marca { get; set; } 
        [Display(Name = "Marca"), Required(), ForeignKey("Marca")]
        public int MarcaId { get; set; }
        [Display(Name = "Itens")]
        public ICollection<Item> Itens { get; set; } = new List<Item>();
    }
}