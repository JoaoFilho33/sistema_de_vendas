// Pagamento
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace trabalho_final.Models
{
    public class Pagamento
    {
          [Display(Name = "Codigo"), Key()]
        public int Id { get; set; }
        [Display(Name = "Valor")]
        public double Valor { get; set; }
        [Display(Name = "Pago")]
        public bool Pago { get; set; }
         [Display(Name = "Data Limite")]
        public DateTime DataLimite { get; set; }
        public NotaDeVenda? NotaDeVenda { get; set; } = null!;
        [Display(Name = "Nota de Venda"), ForeignKey("NotaDeVenda")]
        public int? NotaDeVendaId { get; set; }  = null!;
    }
}
