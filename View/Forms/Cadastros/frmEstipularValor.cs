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
using View.Forms.Base;

namespace View
{
    public partial class frmEstipularValor : FrmBase
    {
        decimal ValorFinal = 0;
        public frmEstipularValor()
        {
            InitializeComponent();
            DelegarEventos();
            this.txtValorCompra.Text = "0,00";
            this.SetSubTitulo("Calcular Valor");
        }

        public frmEstipularValor(decimal valor)
        {
            InitializeComponent();
            DelegarEventos();
            this.txtValorCompra.Text = valor.ToString();
            SendKeys.Send("{Tab}");
            this.SetSubTitulo("Calcular Valor");
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.btnSalvar.Click += EventoCalcular;
        }

        private void EventoCalcular(object sender, EventArgs e)
        {
            this.ValidarCamposObrigatorios();

            decimal ValorCompra = this.txtValorCompra.Text.ToDecimal();
            decimal Porcentagem = this.txtPorcentagemLucro.Text.ToDecimal();

            this.ValorFinal = Math.Round((((Porcentagem * ValorCompra) / 100) + ValorCompra),2);

            this.Close();
        }

        public decimal Abrir()
        {
            this.ShowDialog();
            return this.ValorFinal;
        }
    }
}