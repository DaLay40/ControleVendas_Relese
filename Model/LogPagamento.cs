using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios.Enumerators;
using Utilitarios.Extencions;

namespace Model
{
    public class LogPagamento
    {

        public Int64 Id { get; set; }
        public Int64? IdPedido { get; set; }
        public Decimal? ValorRecebido { get; set; }
        public Decimal? ValorDesconto { get; set; }
        public DateTime? Data { get; set; }
        public String FormaPagamento { get; set; }
        public Decimal? ValorRestante { get; set; }
        public Byte? Tipo { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual String NomeCliente { get { return Pedido.NomeCliente; } }
        public virtual Decimal? ValorOriginalPedido { get { return Pedido.Valor; } }
        public virtual String DescTipo { get { return ((ETipoPagamento)this.Tipo).Descricao(); } }

    }
}
