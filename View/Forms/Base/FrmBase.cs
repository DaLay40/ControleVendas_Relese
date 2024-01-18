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
using Utilitarios.Extencions;

namespace View.Forms.Base
{
    public partial class FrmBase : DevExpress.XtraEditors.XtraForm
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        public bool ConfigurarBinding = true;

        public virtual void EventoAntesSalvar() { }

        public virtual void EventoDepoisSalvar() { }

        public virtual void AtualizarBinding()
        {
            ClearBinding();
            CriarBinding();
        }

        public void Salvar()
        {
            CtrlSession.context.SaveChanges();
        }

        public virtual void ClearBinding()
        {
            foreach(Control ctr in this.Controls)
            {
                if (ctr.HasChildren)
                    ClearBinding(ctr);

                ctr.DataBindings.Clear();
            }
        }

        private void ClearBinding(Control control)
        {
            foreach (Control ctr in control.Controls)
            {
                if (ctr.HasChildren)
                    ClearBinding(ctr);

                ctr.DataBindings.Clear();
            }
        }

        public virtual void CriarBinding() { }

        public virtual void DelegarEventos()
        {
            this.btnSalvar.Click += EventoBaseSalvar;
            this.Load += EventoBaseLoad;
            this.FormClosed += EventoTelaFechada;
        }

        private void EventoTelaFechada(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        public virtual void EventoBaseLoad(object sender, EventArgs e)
        {
            CriarBinding();
            SetTitulo();
        }

        public void EventoBaseSalvar(object sender, EventArgs e)
        {
            EventoAntesSalvar();

            Salvar();

            EventoDepoisSalvar();
        }

        public void SetSubTitulo(String SubTitulo)
        {
            this.SubTitulo.Text = SubTitulo;
        }

        public void SetTitulo()
        {
            this.Text = "Controle de Vendas - " + CtrlSession.TipoInicioApp.Descricao() + " - Versão : " + CtrlSession.Config.Version;
        }
    }
}