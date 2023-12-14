using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trabalho_final.Models;

namespace trabalho_final.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {

        }
        public DbSet<trabalho_final.Models.Cliente> Cliente { get; set; }
        public DbSet<trabalho_final.Models.Item> Item { get; set; }
        public DbSet<trabalho_final.Models.Marca> Marca { get; set; }
        public DbSet<trabalho_final.Models.NotaDeVenda> NotaDeVenda { get; set; }
        public DbSet<trabalho_final.Models.Pagamento> Pagamento { get; set; }
        public DbSet<trabalho_final.Models.Produto> Produto { get; set; }
        public DbSet<trabalho_final.Models.TipoPagamento> TipoPagamento { get; set; }
        public DbSet<trabalho_final.Models.Transportadora> Transportadora { get; set; }
        public DbSet<trabalho_final.Models.Vendedor> Vendedor { get; set; }
        public DbSet<trabalho_final.Models.PagamentoComCartao> PagamentoComCartao { get; set; }
    }
}