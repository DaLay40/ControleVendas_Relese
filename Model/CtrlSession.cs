using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Utilitarios.Enumerators;

namespace Model
{
    public static class CtrlSession
    {
        private static ETipoInicioApp _tipoInicioApp = ETipoInicioApp.Principal;

        public static ControleVendasEntities context = new ControleVendasEntities();

        public static Config Config = new Config();
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Marca> Marcas = new List<Marca>();
        public static List<Pedido> Pedidos = new List<Pedido>();
        public static List<Produto> Produtos = new List<Produto>();

        public static ETipoInicioApp TipoInicioApp { get { return _tipoInicioApp; } }

        public static string GetStringConnection()
        {
            switch (TipoInicioApp)
            {
                case ETipoInicioApp.Teste:
                    return "name=ControleVendasEntities_Teste";
                case ETipoInicioApp.Principal:
                    return "name=ControleVendasEntities";
                default:
                    return "name=ControleVendasEntities";
            }
        }

        public static void GerarListas()
        {
            AtualizarConfiguracoes();
            AtualizarListaClientes();
            AtualizarListaMarcas();
            AtualizarListaProdutos();
            AtualizarListaPedidos();
            Observacao.GeraLista();
        }

        public static void AtualizarListaMarcas()
        {
            Marcas = context.Marca.ToList();
            ReCalcularComissoa();
        }

        public static void AtualizarListaClientes()
        {
            Clientes = context.Cliente.ToList();
        }

        public static void AtualizarListaPedidos()
        {
            Pedidos = context.Pedido.ToList();
            ReCalcularValorPedido();
        }

        public static void AtualizarListaProdutos()
        {
            Produtos = context.Produto.ToList<Model.Produto>();
            ReCalcularValorPedido();
        }

        public static void AtualizarConfiguracoes()
        {
            Config = context.Config.ToList().Max();
        }

        public static void ReCalcularComissoa()
        {
            Pedidos.ForEach(x => { x.ValorTotalComicao = x.ItensPedido.CalcularComissao(); });
            context.SaveChanges();
        }

        public static void ReCalcularValorPedido()
        {
           
            foreach(var item in Pedidos)
            {
                item.ItensPedido.ForEach(x => { x.ValorTotal = Produtos.Where(y => y.Id == x.ProdutoId).Single().ValorProduto * x.Quantidade; });
                item.Valor = item.ItensPedido.Sum(x => x.ValorTotal);
            }

            ReCalcularComissoa();
            context.SaveChanges();
        }

        public static void VerificarDataVencimento()
        {
            foreach(var item in Pedidos)
            {
                if(item.Situacao == (byte)ESituacaoPedido.EmAndamento)
                {
                    if(item.DataPagamento < DateTime.Now)
                    {
                        if(item.NumeroParcela > 1)
                        {
                            if (item.DataPagamento.Value.AddDays(item.DiasEntreParcelas.Value) < DateTime.Now)
                            {
                                item.Situacao = (byte)ESituacaoPedido.SegundaVencida;
                            }
                            else
                            {
                                item.Situacao = (byte)ESituacaoPedido.PrimeiraVencida;
                            }
                        }
                        else
                        {
                            item.Situacao = (byte)ESituacaoPedido.Vencido;
                        }
                    }
                }
            }
            context.SaveChanges();
        }
      
        public static decimal CalcularComissao(this List<ItensPedido> lista)
        {
            decimal valor = 0;
            foreach (var i in lista)
            {
                decimal porcentagem = i.Produto.Marca.PorcentagemComicao.Value;
                decimal valorProd = i.ValorTotal.Value;

                if (valor == 0)
                    valor = ((porcentagem * valorProd) / 100);
                else
                    valor += ((porcentagem * valorProd) / 100);

            }
            return valor;
        }

    }
}
