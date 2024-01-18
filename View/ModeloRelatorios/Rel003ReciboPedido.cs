using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Model;
using System.Linq;

namespace View.ModeloRelatorios
{
    public partial class Rel003ReciboPedido : DevExpress.XtraReports.UI.XtraReport
    {
        public Rel003ReciboPedido(Pedido oPedido)
        {
            InitializeComponent();

            this.lblDataImpressao.Text = "Impresso em: " + DateTime.Now.ToShortDateString();
            this.lblDataReferencia.Text = oPedido.Data.Value.ToShortDateString();
            this.CellProduto.DataBindings.Add(new XRBinding("Text", oPedido.ItensPedido, "ProdutoMarcaDescricao"));
            this.CellQuantidade.DataBindings.Add(new XRBinding("Text", oPedido.ItensPedido, "Quantidade"));
            this.CellValorUni.DataBindings.Add(new XRBinding("Text", oPedido.ItensPedido, "ValorProdutoFormatado"));
            this.CellValor.DataBindings.Add(new XRBinding("Text", oPedido.ItensPedido, "ValorTotalFormatado"));

            this.xrLabelTotal.Text = oPedido.ItensPedido.Sum(x => x.ValorTotal).Value.ToString("C");

            this.DataSource = oPedido.ItensPedido;

        }

    }
}
