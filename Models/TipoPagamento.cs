using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class TipoPagamento
    {
        [Key]
        public int Id { get; set; }
        public string? NomeDoCobrado { get; set; }
        public string? InformacoesAdicionais { get; set; }
    }
}