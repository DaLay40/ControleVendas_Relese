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
using Utilitarios.Extencions;
using Model;
using Utilitarios.Enumerators;
using Utilitarios.Classes;
using Utilitarios.MyMsg;
using System.IO;
using View.Forms.Base;
using Utilitarios;

namespace View
{
    public partial class frmProdutos : FrmBase
    {
        private Produto oProduto = new Produto();
        private bool ProdutoSalvo = false;
        public frmProdutos()
        {
            InitializeComponent();
            DataLoad();
            DelegarEventos();
            this.SetSubTitulo("Cadastro Produtos");
        }

        public override void CriarBinding()
        {
            base.CriarBinding();

            this.txtCodigo.DataBindings.Add(new Binding("Text", this.oProduto, "CodigoProduto", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
            this.txtProduto.DataBindings.Add(new Binding("Text", this.oProduto, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
            this.txtValorCompraProduto.DataBindings.Add(new Binding("Text", this.oProduto, "ValorCompra", true, DataSourceUpdateMode.OnPropertyChanged, "0,00", "N2"));
            this.txtValorProduto.DataBindings.Add(new Binding("Text", this.oProduto, "ValorProduto", true, DataSourceUpdateMode.OnPropertyChanged, "0,00", "N2"));
            this.cboMarca.DataBindings.Add(new Binding("SelectedValue", this.oProduto, "MarcaId", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
            this.cboTipoProduto.DataBindings.Add(new Binding("SelectedValue", this.oProduto, "ETipo", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
            this.txtQuantidadeEstoque.DataBindings.Add(new Binding("Text", this.oProduto, "Estoque", true, DataSourceUpdateMode.OnPropertyChanged, "0", ""));
            this.txtObservacao.DataBindings.Add(new Binding("Text", this.oProduto, "Observacao", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
            this.pictureFotoProduto.DataBindings.Add(new Binding("Image", this.oProduto, "ImagemConvertida", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.btnEstipularValor.Click += EventoEstipularValor;
            this.btnNovaMarca.Click += EventoNovaMarca;
            this.btnConsultar.Click += EventoConsulta;
            this.FormClosing += EventoFechamentoTela;
            this.btnCarregarImagem.Click += EventoCarregarImagem;
            this.btnApagarImagem.Click += EventoApagarImagem;

        }
       
        private void EventoApagarImagem(object sender, EventArgs e)
        {
            pictureFotoProduto.Image = null;
            if (oProduto.IsNotNull())
            {
                oProduto.Imagem = null;
            }
        }

        private void EventoCarregarImagem(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Carregar imagem do comprovante de pagamento";
            fileDialog.Filter = ("Fotos (*jpg; *png; *jpeg) | *jpg; *png; *jpeg");
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureFotoProduto.Image = System.Drawing.Image.FromFile(fileDialog.FileName);
                oProduto.Imagem = System.IO.File.ReadAllBytes(fileDialog.FileName);
            }
        }

        private void EventoFechamentoTela(object sender, FormClosingEventArgs e)
        {
            if (!ProdutoSalvo)
            {
                if (MyMsgBox.Exibir("Os dados não foram salvos. Deseja descartar as alterações?", "Controle Vendas", EBotoesMyMsgBox.SimNao, EIconeMyMsgBox.Pergunta) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        public override void EventoAntesSalvar()
        {
            this.Validar();

            if (this.oProduto.Id == 0)
                CtrlSession.context.Produto.Add(this.oProduto);

            MyMsgBox.Exibir("Produto Salvo com sucesso.", "Controle de Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Sucesso);
            ProdutoSalvo = true;
            
        }

        public override void EventoDepoisSalvar()
        {
            ClearBinding();
            this.oProduto = new Produto();
            this.LimparCampos();
            CriarBinding();
            CtrlSession.AtualizarListaProdutos();
        }

        private void EventoConsulta(object sender, EventArgs e)
        {
            this.oProduto = (Produto)ChamadaFroms.Consultar(ETipoConsulta.Produto);
            AtualizarBinding();
        }

        private void EventoNovaMarca(object sender, EventArgs e)
        {
            ChamadaFroms.Marca();
            this.CarregarCboMarca();
        }

        private void EventoEstipularValor(object sender, EventArgs e)
        {
            this.txtValorProduto.Text = ChamadaFroms.CalcularValor(this.txtValorCompraProduto.Text.ToDecimal()).ToString();
        }

        #region Metodos
       
        private void DataLoad()
        {
            CarregarCboMarca();
            CarregarCboTipo();
        }
        private void Validar()
        {
            this.txtProduto.Validar();
            this.txtCodigo.Validar();
            this.txtValorProduto.Validar();
            this.cboMarca.Validar();

            if ((ETipoProduto)this.cboTipoProduto.SelectedValue == ETipoProduto.ProtaEntrega)
            {
                this.txtValorCompraProduto.Validar();
                this.txtQuantidadeEstoque.Validar();
            }

            if (this.oProduto.Id == 0 && CtrlSession.Produtos.Any(x => x.CodigoProduto == this.txtCodigo.Text.ToInt32()))
                throw new MyExeption("Ja existe um produto com esse codigo cadastrado.", Tipo: ETipoException.Aviso);

        }
        private void CarregarCboMarca()
        {
            this.cboMarca.SetDataSource(CtrlSession.Marcas, "Id", "Nome", "Nome", "Marca");
        }
        private void CarregarCboTipo()
        {
            this.cboTipoProduto.SetDataSource(Util.GetDataSource(typeof(ETipoProduto)), "Value", "Key", "Key", "Tipo Produto");
        }

        #endregion


    }
}