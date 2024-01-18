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
using View.Forms;
using Utilitarios;
using Utilitarios.Enumerators;
using Model;
using Utilitarios.Extencions;
using Utilitarios.Classes;
using View.Forms.Base;
using Utilitarios.Componentes;
using Utilitarios.MyMsg;
using View.ModeloRelatorios;

namespace View
{
    public partial class frmInicio : FrmBase
    {

        BindingSource bindingPedidos = new BindingSource();

        public frmInicio()
        {
            InitializeComponent();
            DelegarEventos();
            this.SetSubTitulo("Controle de Vendas");
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            ////Layout TabPanel
                //Aba Cadastro
                this.btnNovoPedido.Click += EventoClickNovoPedido;
                this.btnMarca.Click += EventoClickMarca;
                this.btnProdutos.Click += EventoClickProdutos;
                //
                //Aba Relatórios
                this.btnRel001_MaisVendidos.Click += EventoTelaFiltroRel001;
                //
                //Aba Consultas
                this.btnEstoque.Click += EventoAbrirEstoque;
                this.btnConsultarPagamentos.Click += EventoConsultarPagamentos;
                //
                //Aba Outros
                this.btnConfiguracoes.Click += EventoAbrirConfiguracoes;
            //
            ////Layout Menu
                //Aba Cadastro
                this.btnMenuNovoPedido.Click += EventoClickNovoPedido;
                this.btnMenuMarca.Click += EventoClickMarca;
                this.btnMenuProduto.Click += EventoClickProdutos;
                //
                //Aba Relatórios
                this.btnMenuRel001_MaisVendidos.Click += EventoTelaFiltroRel001;
                //
                //Aba Consultas
                this.btnMenuEstoque.Click += EventoAbrirEstoque;
                this.btnMenuPagamentos.Click += EventoConsultarPagamentos;
                //
                //Menu Outros
                this.btnMenuConfiguracao.Click += EventoAbrirConfiguracoes;
            
            //
            //Filtros
            this.cboMarca.EditValueChanged += EventoFiltrar;
            this.cboSituacao.EditValueChanged += EventoFiltrar;
            this.dtInicio.EditValueChanged += EventoFiltrar;
            this.dtFim.EditValueChanged += EventoFiltrar;
            //
            //Context Menu
            this.subMenuPedidos.Opened += EventoAbrirMenuStrip;
            this.btnSubMenuEditarPedido.Click += EventoEditarPedido;
            this.btnSubMenuFinalizarPedido.Click += EventoMudarSituacaoPedido;
            this.btnSubMenuCancelarPedido.Click += EventoMudarSituacaoPedido;
            this.btnSubMenuIncluirObservacoes.Click += EventoIncluirObservacao;
            this.btnSubMenuAdicionarPagamento.Click += EventoAdicionarPagamento;
            this.btnSubMenuImprimirRecibo.Click += EventoImprimirRecibo;
            //

        }

        #region Eventos 
        private void EventoAbrirMenuStrip(object sender, EventArgs e)
        {
            Pedido oPedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;

            if (oPedido.Situacao == (byte)ESituacaoPedido.Pago || oPedido.Situacao == (byte)ESituacaoPedido.Finalizado)
                this.btnSubMenuAdicionarPagamento.Text = "Consultar Pagamentos";
            else
                this.btnSubMenuAdicionarPagamento.Text = "Adicionar Pagamento";
        }
        private void EventoEditarPedido(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;
            ChamadaFroms.TelaPedidos(pedido);
            DataLoad();
        }
        private void EventoClickNovoPedido(object sender, EventArgs e)
        {
            ChamadaFroms.TelaPedidos();
            DataLoad();
        }
        private void EventoClickMarca(object sender, EventArgs e)
        {
            ChamadaFroms.Marca();
            DataLoad();
        }
        private void EventoFiltrar(object sender, EventArgs e)
        {

            CtrlSession.VerificarDataVencimento();

            Int64? IdMarca = null;
            int? IdSituacao = null;
            DateTime? DataInicio = null;
            DateTime? DataFim = null;

            DataInicio = this.dtInicio.DateTime;
            DataFim = this.dtFim.DateTime;

            if (this.cboMarca.Validar())
                IdMarca = (Int64)this.cboMarca.SelectedValue;

            if (this.cboSituacao.Validar())
                IdSituacao = (int)this.cboSituacao.SelectedValue;

            List<Pedido> lista = (from p in CtrlSession.Pedidos
                                  where (IdMarca.IsNull() || p.ItensPedido.Any(x => x.Produto.MarcaId == IdMarca))
                                        && (IdSituacao.IsNull() && p.Situacao != 1 || p.Situacao == IdSituacao )
                                        && p.Data >= DataInicio && p.Data <= DataFim
                                  select p).ToList();

            AtualizarListaPedidos(lista);
        }
        private void EventoMudarSituacaoPedido(object sender, EventArgs e)
        {
            Pedido oPedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;

            if (sender.Equals(this.btnSubMenuFinalizarPedido))
            {
                oPedido.Situacao = (Byte)ESituacaoPedido.Finalizado;
            }
            else if (sender.Equals(this.btnSubMenuCancelarPedido))
            {
                oPedido.Situacao = (Byte)ESituacaoPedido.Cancelado;
            }
            CtrlSession.context.SaveChanges();
            this.gridPedidos.RefreshDataSource();
        }
        private void EventoIncluirObservacao(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;
            ChamadaFroms.Observacao(ETipoObservacao.Pedido, pedido.Id);
            this.gridPedidos.RefreshDataSource();
        }
        private void EventoClickProdutos(object sender, EventArgs e)
        {
            ChamadaFroms.Produtos();
            DataLoad();

        }
        private void EventoTelaFiltroRel001(object sender, EventArgs e)
        {
            ChamadaFroms.Rel001();
        }
        private void EventoAbrirEstoque(object sender, EventArgs e)
        {
            ChamadaFroms.Estoque();
            DataLoad();
        }
        private void EventoAdicionarPagamento(object sender, EventArgs e)
        {
            Pedido oPedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;
            if (((ToolStripMenuItem)sender).Text == "Consultar Pagamentos")
                ChamadaFroms.ConsultaLog(oPedido.Id);
            else
                ChamadaFroms.Pagamento(oPedido);

            DataLoad();
        }
        private void EventoConsultarPagamentos(object sender, EventArgs e)
        {
            ChamadaFroms.ConsultaLog();
        }
        private void EventoAbrirConfiguracoes(object sender, EventArgs e)
        {
            ChamadaFroms.Configuracao();
            DataLoad();
        }
        public override void EventoBaseLoad(object sender, EventArgs e)
        {
            base.EventoBaseLoad(sender, e);
            DataLoad();
            SetValorPadrao();
        }
        private void EventoImprimirRecibo(object sender, EventArgs e)
        {
            Pedido oPedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;
            Rel003ReciboPedido rel = new Rel003ReciboPedido(oPedido);
            rel.Show();

        }

        #endregion

        #region Metodos

        private void DataLoad()
        {
            CarregarComboMarca();
            CarregarComboSituacao();
            EventoFiltrar(null, null);
            ConfigurarTela();
        }

        private void CarregarComboMarca()
        {
            this.cboMarca.SetDataSource(CtrlSession.Marcas, "Id", "Nome", "Nome", "Marca", true);
        }

        private void CarregarComboSituacao()
        {
            this.cboSituacao.SetDataSource(Util.GetDataSource(typeof(ESituacaoPedido)), "Value", "Key", "Key", "Situação",true);
        }

        private void AtualizarListaPedidos(List<Pedido> lista)
        {
            this.gridColumnItens.Visible = CtrlSession.Config.ExibirItens;

            this.bindingPedidos.DataSource = lista;
            this.gridPedidos.DataSource = this.bindingPedidos;
            this.gridPedidos.RefreshDataSource();
            CalcularValorComissao(lista);
        }

        private void SetValorPadrao()
        {
            DateTime primeiroDia = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            DateTime ultimoDia = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month));
            this.dtInicio.DateTime = primeiroDia;
            this.dtFim.DateTime = ultimoDia;
            this.cboSituacao.SelectedValue = ESituacaoPedido.EmAndamento;
            DataLoad();
        }

        private void CalcularValorComissao(List<Pedido> lista)
        {
            this.lblValorTotalComissao.Text = lista.Sum(x => x.ValorTotalComicao.Value).ToString("C");
        }
        private void ConfigurarTela()
        {
            if (CtrlSession.Config.Layout == (byte)ELayoutInicio.ControlePorTabPage)
            {
                this.MenuStripLayout2.Visible = false;
                this.LayoutTabPanel.Visible = true;

            }
            else if (CtrlSession.Config.Layout == (byte)ELayoutInicio.ControlePorMenu)
            {
                this.MenuStripLayout2.Visible = true;
                this.LayoutTabPanel.Visible = false;
            }
        }

        #endregion

        
    }
}