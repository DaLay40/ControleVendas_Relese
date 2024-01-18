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

namespace View.Forms.Consultas
{
    public partial class frmConsultaPagamento : FrmBase
    {
        private BindingSource bindingLog = new BindingSource();
        private List<LogPagamento> LogPagamentos = new List<LogPagamento>();
        public frmConsultaPagamento()
        {
            InitializeComponent();
            this.SetSubTitulo("Consulta Pagamento");
            LogPagamentos = CtrlSession.context.LogPagamento.ToList();
            bindingLog.DataSource = LogPagamentos;
            this.gridConsulta.DataSource = bindingLog;
            this.gridConsulta.RefreshDataSource();
            DelegarEventos();
            CalcularValor();
        }
        public frmConsultaPagamento(Int64 IdPedido)
        {
            InitializeComponent();
            this.SetSubTitulo("Consulta Log");
            LogPagamentos = CtrlSession.context.LogPagamento.Where(x => x.IdPedido == IdPedido).ToList();
            bindingLog.DataSource = LogPagamentos;
            this.gridConsulta.DataSource = bindingLog;
            this.gridConsulta.RefreshDataSource();
            DelegarEventos();
            CalcularValor();
        }
        public override void DelegarEventos()
        {
            base.DelegarEventos();
        }
        private void CalcularValor()
        {
            this.lblValorTotalRecebido.Text = this.LogPagamentos.Count > 0 ? this.LogPagamentos.Sum(x => x.ValorRecebido).Value.ToString("C") : "R$ 0,00";
        }
    }
}