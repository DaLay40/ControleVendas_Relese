using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Model.DTOS;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace View.ModeloRelatorios
{
    public partial class Rel002ProdutosEmEstoque : XtraReport
    {
        public Rel002ProdutosEmEstoque(List<Produto> lista)
        {
            InitializeComponent();

            this.lblDataImpressao.Text = "Impresso em: " + DateTime.Now.ToShortDateString();

            this.pictureCellImagem.DataBindings.Add(new XRBinding("ImageSource", lista, "ImagemConvertida"));
            this.CellProduto.DataBindings.Add(new XRBinding("Text", lista, "Descricao"));
            this.CellMarca.DataBindings.Add(new XRBinding("Text", lista, "MarcaNome"));
            this.CellQuantidade.DataBindings.Add(new XRBinding("Text", lista, "Estoque"));
            this.CellValor.DataBindings.Add(new XRBinding("Text", lista, "ValorProdutoFormatado"));

            this.DataSource = lista;

        }

    }
}
