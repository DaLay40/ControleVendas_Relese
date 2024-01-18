using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model;
using Utilitarios.Enumerators;
using View.Forms;
using Utilitarios.Extencions;
using View.ModeloRelatorios;
using DevExpress.XtraReports.UI;
using View.Forms.Base;

namespace View
{
    public partial class frmEstoqueProdutos : FrmBase
    {
        BindingSource bindingProdutos = new BindingSource();
        public frmEstoqueProdutos()
        {
            InitializeComponent();
            DataLoad();
            DelegarEventos();
            this.SetSubTitulo("Produtos em estoque");
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.btnNovoProduto.Click += EventoNovoProduto;
            this.btnAdicionarProduto.Click += EventoAdicionar;
            this.btnImprimirEstoque.Click += EventoImprimir;

        }

        private void EventoImprimir(object sender, EventArgs e)
        {
            Rel002ProdutosEmEstoque rel = new Rel002ProdutosEmEstoque(CtrlSession.Produtos.Where(x => x.Tipo == (byte)ETipoProduto.ProtaEntrega && x.Estoque > 0).ToList());
            rel.Show();
        }

        private void EventoAdicionar(object sender, EventArgs e)
        {
            cboProduto.ValidarComMsg();
            txtQuantidade.Validar();

            Int64 idProduto = (Int64)this.cboProduto.SelectedValue;

            CtrlSession.context.Produto.Find(idProduto).Estoque += this.txtQuantidade.Text.ToInt32();
            CtrlSession.context.SaveChanges();
            this.AtualizaLista();

        }

        private void EventoNovoProduto(object sender, EventArgs e)
        {
            ChamadaFroms.Produtos();
            CtrlSession.AtualizarListaProdutos();
            DataLoad();

        }

        private void DataLoad()
        {
            CarregarCboProdutos();
            AtualizaLista();
        }

        private void CarregarCboProdutos()
        {
            this.cboProduto.SetDataSource(CtrlSession.Produtos.Where(x => x.Tipo == (byte)ETipoProduto.ProtaEntrega), "Id", "CodigoDescricao", "CodigoDescricao", "Produto", true);
        }

        private void AtualizaLista()
        {
            List<Produto> Lista = (List<Produto>)CtrlSession.Produtos.Where(x => x.Tipo == (byte)ETipoProduto.ProtaEntrega).ToList();
            this.bindingProdutos.DataSource = Lista;
            this.gridProdutos.DataSource = this.bindingProdutos;
            this.gridProdutos.RefreshDataSource();
        }
    }
}