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
using Model;

namespace View.Forms.Cadastros
{
    public partial class frmConfiguracao : FrmBase
    {
        public frmConfiguracao()
        {
            InitializeComponent();
            this.SetSubTitulo("Configurações");
            DelegarEventos();
            this.DataLoad();
        }

        public override void CriarBinding()
        {
            this.chkExibirItens.DataBindings.Add("Checked", CtrlSession.Config, "ExibirItens", false, DataSourceUpdateMode.OnPropertyChanged, false, "");
        }
        private void DataLoad()
        {
            this.chkExibirItens.Checked = CtrlSession.Config.ExibirItens;
            if (CtrlSession.Config.Layout == 0)
                this.radioTabPanel.Checked = true;
            if (CtrlSession.Config.Layout == 1)
                this.radioMenu.Checked = true;
        }
        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.radioMenu.Click += EventoSelecionar;
            this.radioTabPanel.Click += EventoSelecionar;
            this.pictureTabPanel.Click += EventoSelecionar;
            this.pictureMenu.Click += EventoSelecionar;
        }

        private void EventoSelecionar(object sender, EventArgs e)
        {
            if (sender == radioMenu)
                this.radioTabPanel.Checked = false;
            else if (sender == radioTabPanel)
                this.radioMenu.Checked = false;
            else if(sender == pictureMenu)
            {
                this.radioTabPanel.Checked = false;
                this.radioMenu.Checked = true;
            }
            else if (sender == pictureTabPanel)
            {
                this.radioTabPanel.Checked = true;
                this.radioMenu.Checked = false;
            }
        }

        public override void EventoAntesSalvar()
        {
            byte Layout = 0;

            if (this.radioMenu.Checked)
                Layout = 1;

            CtrlSession.Config.Layout = Layout;
        }
        public override void EventoDepoisSalvar()
        {
            this.Close();
        }
    }
}