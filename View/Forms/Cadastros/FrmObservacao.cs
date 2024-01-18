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
using View.Forms.Base;
using Utilitarios.MyMsg;
using Model;
using Utilitarios.Extencions;
using Utilitarios.Enumerators;

namespace View.Forms.Cadastros
{
    public partial class FrmObservacao : FrmBase
    {
        private ETipoObservacao Tipo;
        private Int64 IdPrimary;
        private Observacao oObservacao = new Observacao();
        public FrmObservacao(ETipoObservacao Tipo, Int64 IdPrimary)
        {
            InitializeComponent();
            this.DelegarEventos();
            this.CriarBinding();
            this.Tipo = Tipo;
            this.IdPrimary = IdPrimary;
            this.SetSubTitulo("Obervações");
        }

        public override void CriarBinding()
        {
            this.txtObservacao.DataBindings.Add(new Binding("Text", this.oObservacao, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged, "", ""));
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.btnConsultar.Click += EventoConsultar;
        }

        private void EventoConsultar(object sender, EventArgs e)
        {
            oObservacao = (Observacao)ChamadaFroms.Consultar(ETipoConsulta.Observacao);
            this.AtualizarBinding();
        }

        public override void EventoAntesSalvar()
        {
            if (this.txtObservacao.Text.IsNullOrEmpty())
            {
                if (MyMsgBox.Exibir("Você deseja excluir essa observação ?", "Controle Vendas", EBotoesMyMsgBox.SimNao, EIconeMyMsgBox.Pergunta) == DialogResult.Yes)
                {
                    CtrlSession.context.Observacao.Remove(this.oObservacao);
                }
                else
                {
                    MyMsgBox.Exibir("Nenhuma alteração foi realizada", "Controle Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Aviso);
                    return;
                }
            }
            else
            {
                if (this.oObservacao.Id == 0)
                {

                    this.oObservacao.Data = DateTime.Now;
                    this.oObservacao.Tipo = (byte)Tipo;
                    this.oObservacao.IdPrimary = IdPrimary;

                    CtrlSession.context.Observacao.Add(oObservacao);
                }
            }

        }

        public override void EventoDepoisSalvar()
        {
            MyMsgBox.Exibir("Alterações realizadas com sucesso", "Controle Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Sucesso);
            this.Close();
        }
    }
}