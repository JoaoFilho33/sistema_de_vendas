using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace trabalho_final.Models
{
    public class NotaDeVenda
    {

        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Data")]
        public DateTime Data { get; set; }
        [Display(Name = "Tipo")]
        public bool Tipo { get; set; }

        public Cliente? Cliente { get; set; }
        [Display(Name = "Cliente"), ForeignKey("Cliente")]
        public int? ClienteId { get; set; }
        public Vendedor? Vendedor { get; set; }
        [Display(Name = "Vendedor"), ForeignKey("Vendedor")]
        public int? VendedorId { get; set; }

        public Transportadora? Transportadora { get; set; }
        [Display(Name = "Transportadora"), ForeignKey("Transportadora")]
        public int? TransportadoraId { get; set; }

        public TipoPagamento? TipoDePagamento { get; set; }
        [Display(Name = "Tipo de Pagamento"), ForeignKey("TipoPagamento")]
        public int? TipoDePagamentoId { get; set; }
        public ICollection<Item> Itens { get; set; } = new List<Item>();
        public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
        public void Cancelar()
        {
            if (Tipo)
            {
                throw new InvalidOperationException("A nota já foi cancelada!");
            }

            Tipo = true;
        }

        public void Devolver()
        {
            if (!Tipo)
            {
                throw new InvalidOperationException("A nota já foi devolvida!");
            }

            Tipo = false;
        }
    }
}
