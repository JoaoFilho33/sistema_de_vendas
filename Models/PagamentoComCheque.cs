using System.ComponentModel.DataAnnotations;

namespace trabalho_final.Models
{
    public class PagamentoComCheque : TipoPagamento
    {
        [Key]
        public new int Id { get; set; }
        public int Banco { get; set; }
        public string? NomeDoBanco { get; set; }
    }
}
