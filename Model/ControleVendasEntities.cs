using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Model
{
    public partial class ControleVendasEntities : DbContext
    {
        public ControleVendasEntities()
            : base(CtrlSession.GetStringConnection())
        {
        }

        public ControleVendasEntities(String Con)
            : base(Con)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ItensPedido> ItensPedido { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Observacao> Observacao { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<LogPagamento> LogPagamento { get; set; }
    }

}
