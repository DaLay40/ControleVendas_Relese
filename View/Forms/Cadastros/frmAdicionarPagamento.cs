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
using Utilitarios.Extencions;
using Utilitarios.Enumerators;
using Utilitarios.MyMsg;
using Utilitarios;

namespace View.Forms.Cadastros
{
    public partial class frmAdicionarPagamento : FrmBase
    {
        Pedido oPedido;
        public frmAdicionarPagamento(Pedido pedido)
        {
            InitializeComponent();
            this.SetSubTitulo("Adicionar pagamento");
            oPedido = pedido;
            DelegarEventos();
            DataLoad();
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.txtValorRecebido.Leave += EventoLeaveValor;
            this.btnConsultar.Click += EventoConsultar;
        }

        private void EventoLeaveValor(object sender, EventArgs e)
        {
            if(!this.txtValorRecebido.Text.IsNullOrEmpty() && this.txtValorRecebido.Text.ToDecimal() != 0)
            {
                decimal ValorRecebido = this.txtValorRecebido.Text.ToDecimal();

                if (oPedido.ValorAPagar < ValorRecebido)
                {
                    this.txtValorRecebido.Text = "0,00";
                    throw new MyExeption("O valor informado é maior que o valor a receber.", ETipoException.Aviso,Tamanho:ETamanhoMsgBox.Pequeno);
                }
            }
        }

        public override void EventoAntesSalvar()
        {

            this.txtValorRecebido.Validar();
            this.txtFormaPagamento.Validar();

            decimal ValorPago = this.txtValorRecebido.Text.ToDecimal();
            decimal ValorDesconto = 0;
            if (!this.txtValorDesconto.Text.IsNullOrEmpty())
                ValorDesconto = this.txtValorDesconto.Text.ToDecimal();

            this.oPedido.ValorPago = this.oPedido.ValorAPagar == this.oPedido.Valor ? ValorPago : this.oPedido.ValorPago + ValorPago;
            this.oPedido.DataPago = DateTime.Now;
            this.oPedido.ValorAPagar = this.oPedido.Valor - this.oPedido.ValorPago;
            ETipoPagamento tipo = oPedido.ValorAPagar == 0 ? ETipoPagamento.Total : ETipoPagamento.Parcial;

            LogPagamento log = new LogPagamento()
            {
                IdPedido = this.oPedido.Id,
                ValorRecebido = ValorPago - ValorDesconto,
                ValorDesconto = ValorDesconto,
                Data = DateTime.Now,
                FormaPagamento = this.txtFormaPagamento.Text,
                ValorRestante = this.oPedido.ValorAPagar,
                Tipo = (byte)tipo
            };
            CtrlSession.context.LogPagamento.Add(log);

            oPedido.Situacao = tipo.Equals(ETipoPagamento.Total) ? (byte)ESituacaoPedido.Pago : (byte)ESituacaoPedido.PagoParcial;
        }

        public override void EventoDepoisSalvar()
        {
            this.LimparCampos();
            MyMsgBox.Exibir("Pagamento Adicionado com Sucesso", "Controle Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Sucesso, ETamanhoMsgBox.PequenoFixo);
            //this.Close();
            DataLoad();
        }

        private void EventoConsultar(object sender, EventArgs e)
        {
            ChamadaFroms.ConsultaLog(this.oPedido.Id);
        }

        private void DataLoad()
        {
            this.txtValorRecebido.Text = "0,00";
            this.txtValorDesconto.Text = "0,00";
            this.lblValorRestante.Text = oPedido.ValorAPagar.HasValue ? oPedido.ValorAPagar.Value.ToString("C") : "";

        }
    }
}