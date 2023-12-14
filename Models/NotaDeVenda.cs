using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class NotaDeVenda
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }
        public virtual TipoPagamento? TipoPagamentoNota { get; set; }
        public virtual Pagamento? PagamentoNota { get; set; }
        public virtual Transportadora? TransportadoraNota { get; set; }
        public virtual Vendedor? VendedorNota { get; set; }
        public virtual Cliente? ClienteNota { get; set; }
        
    }
}