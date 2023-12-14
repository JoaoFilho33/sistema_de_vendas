using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class TipoPagamento
    {
        [Display(Name = "Codigo"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome do Cobrado")]
        public string NomeDoCobrado { get; set; } = string.Empty;
        [Display(Name = "Informações Adicionais")]
        public string InformacoesAdicionais { get; set; } = string.Empty;
    }
}