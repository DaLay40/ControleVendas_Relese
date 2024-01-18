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
using Utilitarios.Extencions;
using Utilitarios;
using Utilitarios.Enumerators;
using Model;
using Utilitarios.MyMsg;
using View.Forms;
using View.Forms.Base;

namespace View
{
    public partial class frmMarca : FrmBase
    {
        private Marca oMarca = new Marca();

        public frmMarca()
        {
            InitializeComponent();
            DelegarEventos();
            this.SetSubTitulo("Cadastro Marca");
        }

        public override void CriarBinding()
        {
            this.txtNome.DataBindings.Add(new Binding("Text", this.oMarca, "Nome", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
            this.txtComissao.DataBindings.Add(new Binding("Text", this.oMarca, "PorcentagemComicao", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.btnConsultar.Click += EventoConsultarMarcas;
        }

        #region Eventos

        public override void EventoAntesSalvar()
        {
            if (this.txtNome.Text.IsNullOrEmpty())
                throw new MyExeption("Informe o nome da marca.", ETipoException.Aviso);

            if (this.txtComissao.Text.IsNullOrEmpty())
                throw new MyExeption("Informe a porcentagem de comissão da marca.", ETipoException.Aviso);

            if (CtrlSession.Marcas.Any(x => x.Nome == this.txtNome.Text) && (oMarca.Id == 0 || oMarca.Nome != this.txtNome.Text))
                throw new MyExeption("Uma marca com esse nome ja esta cadastrada.", ETipoException.Aviso);

            if (oMarca.Id == 0)
                CtrlSession.context.Marca.Add(oMarca);

        }

        public override void EventoDepoisSalvar()
        {
            MyMsgBox.Exibir("Marca cadastrada com sucesso", "Controle de Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Sucesso);
            ClearBinding();
            this.LimparCampos();
            this.oMarca = new Marca();
            CriarBinding();
        }

        private void EventoConsultarMarcas(object sender, EventArgs e)
        {
            this.oMarca = (Marca)ChamadaFroms.Consultar(ETipoConsulta.Marca);
            this.AtualizarBinding();
        }

        #endregion
    }
}