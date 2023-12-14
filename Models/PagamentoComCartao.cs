using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class PagamentoComCartao : TipoPagamento {
        [Key]
        public new int Id { get; set; }
        public string? NumeroDoCartao { get; set; }
        public string? Bandeira { get; set; }
    }
}