﻿using System;
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
using Utilitarios.Classes;
using Utilitarios.Enumerators;
using Utilitarios;
using View.Forms.Base;

namespace View
{
    public partial class FrmConsulta : FrmBase
    {
        private BindingSource bindingGenerico = new BindingSource();
        private List<Generico> listaGenerica = new List<Generico>();
        private object Retorno;
        private Generico RetornoIntermediario;
        private ETipoConsulta TipoConsulta;

        public FrmConsulta(ETipoConsulta TipoConsulta)
        {
            InitializeComponent();
            DelegarEventos();
            this.SetSubTitulo("Consultar " + this.TipoConsulta.Descricao());
            this.TipoConsulta = TipoConsulta;
            DataLoad();
        }

        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.gridConsulta.DoubleClick += EventoRetorno;
            this.FormClosed += EventoFechar;
        }


        private void EventoFechar(object sender, FormClosedEventArgs e)
        {
            if (this.Retorno.IsNull())
            {
                switch (this.TipoConsulta)
                {
                    case ETipoConsulta.Cliente:
                    {
                        this.Retorno = this.Retorno.IsNull() ? new Cliente() : this.Retorno;
                        break;
                    }
                    case ETipoConsulta.Observacao:
                    {
                        this.Retorno = this.Retorno.IsNull() ? new Observacao() : this.Retorno;
                        break;
                    }
                    case ETipoConsulta.Marca:
                    {
                        this.Retorno = this.Retorno.IsNull() ? new Marca() : this.Retorno;
                        break;
                    }
                    case ETipoConsulta.Produto:
                    {
                        this.Retorno = this.Retorno.IsNull() ? new Produto() : this.Retorno;
                        break;
                    }
                }
            }
        }

        private void DataLoad()
        {
            switch (this.TipoConsulta)
            {
                case ETipoConsulta.Cliente:
                {
                    this.listaGenerica = CtrlSession.context.Cliente.ToList<object>().ToGenerica();
                    break;
                }
                case ETipoConsulta.Observacao:
                {
                    this.listaGenerica = CtrlSession.context.Observacao.ToList<object>().ToGenerica();
                    break;
                }
                case ETipoConsulta.Marca:
                {
                    this.listaGenerica = CtrlSession.context.Marca.ToList<object>().ToGenerica();
                    break;
                }
                case ETipoConsulta.Produto:
                {
                    this.listaGenerica = CtrlSession.context.Produto.ToList<object>().ToGenerica();
                    break;
                }
                
            }

            if (this.listaGenerica.Count <= 0)
                throw new MyExeption("Não existem registros para essa consulta.", ETipoException.Aviso);

            this.bindingGenerico.DataSource = this.listaGenerica;
            this.gridConsulta.DataSource = this.bindingGenerico;
            this.gridConsulta.RefreshDataSource();

        }

        private void EventoRetorno(object sender, EventArgs e)
        {
            this.RetornoIntermediario = (Generico)this.bindingGenerico.CurrencyManager.Current;
            this.ConverterRetorno();
            this.Destroy();
            this.Close();
        }

        private void ConverterRetorno()
        {

            switch (this.TipoConsulta)
            {
                case ETipoConsulta.Cliente:
                {
                    this.Retorno = CtrlSession.context.Cliente.Find(this.RetornoIntermediario.Id);
                    this.Retorno = this.Retorno.IsNull() ? new Cliente() : this.Retorno;
                    break;
                }
                case ETipoConsulta.Observacao:
                {
                    this.Retorno = CtrlSession.context.Observacao.Find(this.RetornoIntermediario.Id);
                    this.Retorno = this.Retorno.IsNull() ? new Observacao() : this.Retorno;
                    break;
                }
                case ETipoConsulta.Marca:
                {
                    this.Retorno = CtrlSession.context.Marca.Find(this.RetornoIntermediario.Id);
                    this.Retorno = this.Retorno.IsNull() ? new Marca() : this.Retorno;
                    break;
                }
                case ETipoConsulta.Produto:
                {
                    this.Retorno = CtrlSession.context.Produto.Find(this.RetornoIntermediario.Id);
                    this.Retorno = this.Retorno.IsNull() ? new Produto() : this.Retorno;
                    break;
                }
            }


        }

        public object Consultar()
        {
            this.ShowDialog();
            return Retorno;
        }
       
        private void Destroy()
        {
            this.bindingGenerico = null;
            this.listaGenerica = null;
            this.RetornoIntermediario = null;
        }

    }
}