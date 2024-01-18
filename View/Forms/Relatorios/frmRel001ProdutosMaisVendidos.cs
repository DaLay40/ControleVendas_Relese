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
using Model.DTOS;
using System.Data.SqlClient;
using Model;
using DevExpress.Utils.Extensions;
using View.ModeloRelatorios;
using DevExpress.XtraReports.UI;
using View.Forms.Base;

namespace View
{
    public partial class frmRel001ProdutosMaisVendidos :FrmBase
    {
        public frmRel001ProdutosMaisVendidos()
        {
            InitializeComponent();
            DelegarEventos();
            CarregarCboMarcas();
            this.SetSubTitulo("Relatório de Produtos mais vendidos");
        }
        public override void DelegarEventos()
        {
            base.DelegarEventos();
            this.btnConsultar.Click += EventoCosultar;
        }

        private void EventoCosultar(object sender, EventArgs e)
        {
            if (this.dtInicio.EditValue.IsNull() || this.dtFim.EditValue.IsNull())
                throw new MyExeption("Informe uma data inicial e uma data final", Utilitarios.Enumerators.ETipoException.Aviso);

            DateTime dataInicial = this.dtInicio.DateTime;
            DateTime dataFinal = this.dtFim.DateTime;
            Int64? IdMarca = this.cboMarca.SelectedValue.IsNotNull() && this.cboMarca.SelectedValue != (object)-1 ? (Int64?)this.cboMarca.SelectedValue : null;

            SqlParameter obj0 = new SqlParameter("@dataInicio", dataInicial);
            SqlParameter obj1 = new SqlParameter("@datafim", dataFinal);
            SqlParameter obj2 = new SqlParameter("@IdMarca", IdMarca.IsNull()? (Object)DBNull.Value : IdMarca);
        
            List<rel001ProdutosMaisVendidos> lista = CtrlSession.context.Database.SqlQuery<rel001ProdutosMaisVendidos>
                                                                        ("Exec proc_rel001_MaisVendidos @dataInicio, @datafim,@IdMarca"
                                                                            , obj0, obj1, obj2).ToList();
            lista.ForEach(x => { x.dataInicial = dataInicial; x.datafinal = dataFinal; });
            Rel001ProdutosMaisVendidos rel = new Rel001ProdutosMaisVendidos(lista);
            rel.Show();
        }

        private void CarregarCboMarcas()
        {
            this.cboMarca.SetDataSource(CtrlSession.Marcas, "Id", "Nome", "Nome", "Marca", true);
        }
    }
}