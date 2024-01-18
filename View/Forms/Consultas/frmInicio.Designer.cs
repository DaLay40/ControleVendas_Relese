namespace View
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue5 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue6 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue7 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue8 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.gridColumnByteSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtFim = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboMarca = new Utilitarios.Componentes.MyComboBox();
            this.txtConteudoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LayoutTabPanel = new DevExpress.XtraEditors.PanelControl();
            this.XtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnMarca = new DevExpress.XtraEditors.SimpleButton();
            this.btnProdutos = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovoPedido = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnRel001_MaisVendidos = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnConsultarPagamentos = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstoque = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.btnConfiguracoes = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorTotalComissao = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlPrincipal = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridPedidos = new DevExpress.XtraGrid.GridControl();
            this.subMenuPedidos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSubMenuEditarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubMenuFinalizarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubMenuCancelarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubMenuIncluirObservacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubMenuAdicionarPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubMenuImprimirRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnObservacoes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtObservacao = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnItens = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtItens = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorRecebido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorRestante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorComissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnParcelas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cboSituacao = new Utilitarios.Componentes.MyComboBox();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.MenuStripLayout2 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuNovoPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRel001_MaisVendidos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuPagamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConteudoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutTabPanel)).BeginInit();
            this.LayoutTabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl)).BeginInit();
            this.XtraTabControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.subMenuPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSituacao.Properties)).BeginInit();
            this.MenuStripLayout2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Size = new System.Drawing.Size(1366, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lblValorTotalComissao);
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Location = new System.Drawing.Point(0, 552);
            this.panelControl4.Size = new System.Drawing.Size(1366, 44);
            this.panelControl4.Controls.SetChildIndex(this.labelControl5, 0);
            this.panelControl4.Controls.SetChildIndex(this.panel1, 0);
            this.panelControl4.Controls.SetChildIndex(this.lblValorTotalComissao, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1161, 2);
            this.panel1.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.Image")));
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(0, 147);
            this.panelControl2.Size = new System.Drawing.Size(1366, 405);
            // 
            // gridColumnByteSituacao
            // 
            this.gridColumnByteSituacao.Caption = "gridColumn1";
            this.gridColumnByteSituacao.FieldName = "Situacao";
            this.gridColumnByteSituacao.Name = "gridColumnByteSituacao";
            this.gridColumnByteSituacao.OptionsColumn.AllowEdit = false;
            this.gridColumnByteSituacao.OptionsColumn.AllowFocus = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Valor total de comissão:";
            // 
            // dtFim
            // 
            this.dtFim.EditValue = null;
            this.dtFim.Location = new System.Drawing.Point(294, 58);
            this.dtFim.Name = "dtFim";
            this.dtFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFim.Size = new System.Drawing.Size(100, 20);
            this.dtFim.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(294, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Data Final";
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = null;
            this.dtInicio.Location = new System.Drawing.Point(173, 58);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Size = new System.Drawing.Size(100, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(173, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Data Inicial";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.DataSource = null;
            this.cboMarca.DisplayMember = "";
            this.cboMarca.IdObjetoRetorno = null;
            this.cboMarca.Location = new System.Drawing.Point(26, 58);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(0);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.NaoMudarFocoTeclaEnter = false;
            this.cboMarca.NaoMudarReadOnly = false;
            this.cboMarca.PermitirTextoDigitadoQueNaoEstaNaLista = false;
            this.cboMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMarca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cboMarca.Properties.ImmediatePopup = true;
            this.cboMarca.Properties.NullText = "";
            this.cboMarca.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboMarca.Properties.PopupSizeable = false;
            this.cboMarca.Properties.PopupView = this.txtConteudoView;
            this.cboMarca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboMarca.Required = true;
            this.cboMarca.RequiredMessage = null;
            this.cboMarca.SelectedIndex = -1;
            this.cboMarca.SelectedItem = null;
            this.cboMarca.SelectedValue = null;
            this.cboMarca.Size = new System.Drawing.Size(120, 20);
            this.cboMarca.TabIndex = 0;
            // 
            // txtConteudoView
            // 
            this.txtConteudoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtConteudoView.Name = "txtConteudoView";
            this.txtConteudoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtConteudoView.OptionsView.ShowGroupPanel = false;
            // 
            // LayoutTabPanel
            // 
            this.LayoutTabPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.LayoutTabPanel.Appearance.BackColor2 = System.Drawing.Color.White;
            this.LayoutTabPanel.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.LayoutTabPanel.Appearance.Options.UseBackColor = true;
            this.LayoutTabPanel.Appearance.Options.UseBorderColor = true;
            this.LayoutTabPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LayoutTabPanel.Controls.Add(this.XtraTabControl);
            this.LayoutTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutTabPanel.Location = new System.Drawing.Point(0, 58);
            this.LayoutTabPanel.Name = "LayoutTabPanel";
            this.LayoutTabPanel.Size = new System.Drawing.Size(1366, 89);
            this.LayoutTabPanel.TabIndex = 27;
            // 
            // XtraTabControl
            // 
            this.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.XtraTabControl.Name = "XtraTabControl";
            this.XtraTabControl.SelectedTabPage = this.xtraTabPage1;
            this.XtraTabControl.Size = new System.Drawing.Size(1366, 89);
            this.XtraTabControl.TabIndex = 3;
            this.XtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnMarca);
            this.xtraTabPage1.Controls.Add(this.btnProdutos);
            this.xtraTabPage1.Controls.Add(this.btnNovoPedido);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1364, 64);
            this.xtraTabPage1.Text = "Cadastros";
            // 
            // btnMarca
            // 
            this.btnMarca.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnMarca.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnMarca.Appearance.Options.UseBorderColor = true;
            this.btnMarca.Appearance.Options.UseFont = true;
            this.btnMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMarca.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.ImageOptions.Image")));
            this.btnMarca.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMarca.Location = new System.Drawing.Point(163, 0);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(71, 64);
            this.btnMarca.TabIndex = 1;
            this.btnMarca.Text = "Marcas";
            // 
            // btnProdutos
            // 
            this.btnProdutos.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnProdutos.Appearance.Options.UseFont = true;
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProdutos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.ImageOptions.Image")));
            this.btnProdutos.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnProdutos.Location = new System.Drawing.Point(90, 0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(73, 64);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnNovoPedido.Appearance.Options.UseFont = true;
            this.btnNovoPedido.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovoPedido.ImageOptions.Image = global::View.Properties.Resources.IconeNovoPedido_24px;
            this.btnNovoPedido.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNovoPedido.Location = new System.Drawing.Point(0, 0);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(90, 64);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.Text = "Novo Pedido";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnRel001_MaisVendidos);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1364, 64);
            this.xtraTabPage2.Text = "Relatórios";
            // 
            // btnRel001_MaisVendidos
            // 
            this.btnRel001_MaisVendidos.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnRel001_MaisVendidos.Appearance.Options.UseFont = true;
            this.btnRel001_MaisVendidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRel001_MaisVendidos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRel001_MaisVendidos.ImageOptions.Image")));
            this.btnRel001_MaisVendidos.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRel001_MaisVendidos.Location = new System.Drawing.Point(0, 0);
            this.btnRel001_MaisVendidos.Name = "btnRel001_MaisVendidos";
            this.btnRel001_MaisVendidos.Size = new System.Drawing.Size(90, 64);
            this.btnRel001_MaisVendidos.TabIndex = 1;
            this.btnRel001_MaisVendidos.Text = "Mais Vendidos";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.btnConsultarPagamentos);
            this.xtraTabPage3.Controls.Add(this.btnEstoque);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1364, 64);
            this.xtraTabPage3.Text = "Consultas";
            // 
            // btnConsultarPagamentos
            // 
            this.btnConsultarPagamentos.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnConsultarPagamentos.Appearance.Options.UseFont = true;
            this.btnConsultarPagamentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultarPagamentos.ImageOptions.Image = global::View.Properties.Resources.IconeConsultarPagamentos_24px;
            this.btnConsultarPagamentos.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnConsultarPagamentos.Location = new System.Drawing.Point(90, 0);
            this.btnConsultarPagamentos.Name = "btnConsultarPagamentos";
            this.btnConsultarPagamentos.Size = new System.Drawing.Size(90, 64);
            this.btnConsultarPagamentos.TabIndex = 3;
            this.btnConsultarPagamentos.Text = "Pagamentos";
            // 
            // btnEstoque
            // 
            this.btnEstoque.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnEstoque.Appearance.Options.UseFont = true;
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstoque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.ImageOptions.Image")));
            this.btnEstoque.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEstoque.Location = new System.Drawing.Point(0, 0);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(90, 64);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.btnConfiguracoes);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1364, 64);
            this.xtraTabPage4.Text = "Outros";
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnConfiguracoes.Appearance.Options.UseFont = true;
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfiguracoes.ImageOptions.Image = global::View.Properties.Resources.IconeConfiduracao_24px;
            this.btnConfiguracoes.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(90, 64);
            this.btnConfiguracoes.TabIndex = 4;
            this.btnConfiguracoes.Text = "Configurações";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(419, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Situação";
            // 
            // lblValorTotalComissao
            // 
            this.lblValorTotalComissao.Location = new System.Drawing.Point(132, 16);
            this.lblValorTotalComissao.Name = "lblValorTotalComissao";
            this.lblValorTotalComissao.Size = new System.Drawing.Size(22, 13);
            this.lblValorTotalComissao.TabIndex = 2;
            this.lblValorTotalComissao.Text = "0,00";
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.groupControl1);
            this.pnlPrincipal.Controls.Add(this.groupControl2);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 147);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1366, 405);
            this.pnlPrincipal.TabIndex = 26;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridPedidos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 102);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1362, 301);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Pedidos";
            // 
            // gridPedidos
            // 
            this.gridPedidos.ContextMenuStrip = this.subMenuPedidos;
            this.gridPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPedidos.EmbeddedNavigator.Appearance.Options.UseTextOptions = true;
            this.gridPedidos.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridPedidos.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPedidos.Location = new System.Drawing.Point(2, 23);
            this.gridPedidos.MainView = this.gridViewPedidos;
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtObservacao,
            this.txtItens});
            this.gridPedidos.Size = new System.Drawing.Size(1358, 276);
            this.gridPedidos.TabIndex = 29;
            this.gridPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedidos});
            // 
            // subMenuPedidos
            // 
            this.subMenuPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSubMenuEditarPedido,
            this.btnSubMenuFinalizarPedido,
            this.btnSubMenuCancelarPedido,
            this.btnSubMenuIncluirObservacoes,
            this.btnSubMenuAdicionarPagamento,
            this.btnSubMenuImprimirRecibo});
            this.subMenuPedidos.Name = "subMenuPedidos";
            this.subMenuPedidos.Size = new System.Drawing.Size(190, 136);
            // 
            // btnSubMenuEditarPedido
            // 
            this.btnSubMenuEditarPedido.Image = global::View.Properties.Resources.IconeEditar_24px;
            this.btnSubMenuEditarPedido.Name = "btnSubMenuEditarPedido";
            this.btnSubMenuEditarPedido.Size = new System.Drawing.Size(189, 22);
            this.btnSubMenuEditarPedido.Text = "Editar Pedido";
            // 
            // btnSubMenuFinalizarPedido
            // 
            this.btnSubMenuFinalizarPedido.Image = global::View.Properties.Resources.IconeSucesso_24px;
            this.btnSubMenuFinalizarPedido.Name = "btnSubMenuFinalizarPedido";
            this.btnSubMenuFinalizarPedido.Size = new System.Drawing.Size(189, 22);
            this.btnSubMenuFinalizarPedido.Text = "Finalizar Pedido";
            // 
            // btnSubMenuCancelarPedido
            // 
            this.btnSubMenuCancelarPedido.Image = global::View.Properties.Resources.IconeCancelar_24px;
            this.btnSubMenuCancelarPedido.Name = "btnSubMenuCancelarPedido";
            this.btnSubMenuCancelarPedido.Size = new System.Drawing.Size(189, 22);
            this.btnSubMenuCancelarPedido.Text = "Cancelar Pedido";
            // 
            // btnSubMenuIncluirObservacoes
            // 
            this.btnSubMenuIncluirObservacoes.Image = global::View.Properties.Resources.IconeObservacao_24px;
            this.btnSubMenuIncluirObservacoes.Name = "btnSubMenuIncluirObservacoes";
            this.btnSubMenuIncluirObservacoes.Size = new System.Drawing.Size(189, 22);
            this.btnSubMenuIncluirObservacoes.Text = "Incluir Observação";
            // 
            // btnSubMenuAdicionarPagamento
            // 
            this.btnSubMenuAdicionarPagamento.Image = global::View.Properties.Resources.IconeCifrao_16px;
            this.btnSubMenuAdicionarPagamento.Name = "btnSubMenuAdicionarPagamento";
            this.btnSubMenuAdicionarPagamento.Size = new System.Drawing.Size(189, 22);
            this.btnSubMenuAdicionarPagamento.Text = "Adicionar Pagamento";
            // 
            // btnSubMenuImprimirRecibo
            // 
            this.btnSubMenuImprimirRecibo.Image = global::View.Properties.Resources.IconeConsultarPagamentos_16px;
            this.btnSubMenuImprimirRecibo.Name = "btnSubMenuImprimirRecibo";
            this.btnSubMenuImprimirRecibo.Size = new System.Drawing.Size(189, 22);
            this.btnSubMenuImprimirRecibo.Text = "Imprimir Recibo";
            // 
            // gridViewPedidos
            // 
            this.gridViewPedidos.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewPedidos.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewPedidos.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewPedidos.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridViewPedidos.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewPedidos.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPedidos.AutoFillColumn = this.gridColumnObservacoes;
            this.gridViewPedidos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCliente,
            this.gridColumnItens,
            this.gridColumnValor,
            this.gridColumnValorRecebido,
            this.gridColumnValorRestante,
            this.gridColumnData,
            this.gridColumnValorComissao,
            this.gridColumnSituacao,
            this.gridColumnParcelas,
            this.gridColumnByteSituacao,
            this.gridColumnObservacoes});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gridColumnByteSituacao;
            gridFormatRule1.Name = "EmAndamento";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(211)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = ((byte)(0));
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.gridColumnByteSituacao;
            gridFormatRule2.Name = "Finalizado";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.LightBlue;
            formatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = ((byte)(2));
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.gridColumnByteSituacao;
            gridFormatRule3.Name = "Cancelado";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            formatConditionRuleValue3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = ((byte)(1));
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Column = this.gridColumnByteSituacao;
            gridFormatRule4.Name = "Vencido";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleValue4.Appearance.BackColor2 = System.Drawing.Color.White;
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = ((byte)(3));
            gridFormatRule4.Rule = formatConditionRuleValue4;
            gridFormatRule5.ApplyToRow = true;
            gridFormatRule5.Column = this.gridColumnByteSituacao;
            gridFormatRule5.Name = "ParcelaVencida";
            formatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleValue5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleValue5.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = ((byte)(4));
            gridFormatRule5.Rule = formatConditionRuleValue5;
            gridFormatRule6.ApplyToRow = true;
            gridFormatRule6.Column = this.gridColumnByteSituacao;
            gridFormatRule6.Name = "SegundaParcelaVencida";
            formatConditionRuleValue6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleValue6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleValue6.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue6.Value1 = ((byte)(5));
            gridFormatRule6.Rule = formatConditionRuleValue6;
            gridFormatRule7.ApplyToRow = true;
            gridFormatRule7.Column = this.gridColumnByteSituacao;
            gridFormatRule7.Name = "PagoParcial";
            formatConditionRuleValue7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            formatConditionRuleValue7.Appearance.BackColor2 = System.Drawing.Color.White;
            formatConditionRuleValue7.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue7.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue7.Value1 = ((byte)(6));
            gridFormatRule7.Rule = formatConditionRuleValue7;
            gridFormatRule8.ApplyToRow = true;
            gridFormatRule8.Column = this.gridColumnByteSituacao;
            gridFormatRule8.Name = "Pago";
            formatConditionRuleValue8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue8.Appearance.BackColor2 = System.Drawing.Color.White;
            formatConditionRuleValue8.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue8.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue8.Value1 = ((byte)(7));
            gridFormatRule8.Rule = formatConditionRuleValue8;
            this.gridViewPedidos.FormatRules.Add(gridFormatRule1);
            this.gridViewPedidos.FormatRules.Add(gridFormatRule2);
            this.gridViewPedidos.FormatRules.Add(gridFormatRule3);
            this.gridViewPedidos.FormatRules.Add(gridFormatRule4);
            this.gridViewPedidos.FormatRules.Add(gridFormatRule5);
            this.gridViewPedidos.FormatRules.Add(gridFormatRule6);
            this.gridViewPedidos.FormatRules.Add(gridFormatRule7);
            this.gridViewPedidos.FormatRules.Add(gridFormatRule8);
            this.gridViewPedidos.GridControl = this.gridPedidos;
            this.gridViewPedidos.Name = "gridViewPedidos";
            this.gridViewPedidos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewPedidos.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewPedidos.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewPedidos.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPedidos.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPedidos.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPedidos.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPedidos.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewPedidos.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewPedidos.OptionsPrint.ExpandAllDetails = true;
            this.gridViewPedidos.OptionsPrint.PrintFooter = false;
            this.gridViewPedidos.OptionsPrint.PrintGroupFooter = false;
            this.gridViewPedidos.OptionsPrint.PrintVertLines = false;
            this.gridViewPedidos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPedidos.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewPedidos.OptionsSelection.MultiSelect = true;
            this.gridViewPedidos.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewPedidos.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridViewPedidos.OptionsView.RowAutoHeight = true;
            this.gridViewPedidos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPedidos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnObservacoes
            // 
            this.gridColumnObservacoes.Caption = "Observações";
            this.gridColumnObservacoes.ColumnEdit = this.txtObservacao;
            this.gridColumnObservacoes.FieldName = "ObservacaosConcatenadas";
            this.gridColumnObservacoes.Name = "gridColumnObservacoes";
            this.gridColumnObservacoes.OptionsColumn.AllowEdit = false;
            this.gridColumnObservacoes.OptionsColumn.AllowFocus = false;
            this.gridColumnObservacoes.Visible = true;
            this.gridColumnObservacoes.VisibleIndex = 10;
            this.gridColumnObservacoes.Width = 173;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Name = "txtObservacao";
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.OptionsColumn.AllowEdit = false;
            this.gridColumnId.OptionsColumn.AllowFocus = false;
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            this.gridColumnId.Width = 109;
            // 
            // gridColumnCliente
            // 
            this.gridColumnCliente.Caption = "Cliente";
            this.gridColumnCliente.FieldName = "NomeCliente";
            this.gridColumnCliente.Name = "gridColumnCliente";
            this.gridColumnCliente.OptionsColumn.AllowEdit = false;
            this.gridColumnCliente.OptionsColumn.AllowFocus = false;
            this.gridColumnCliente.Visible = true;
            this.gridColumnCliente.VisibleIndex = 1;
            this.gridColumnCliente.Width = 176;
            // 
            // gridColumnItens
            // 
            this.gridColumnItens.Caption = "Itens";
            this.gridColumnItens.ColumnEdit = this.txtItens;
            this.gridColumnItens.FieldName = "ItensConcatenados";
            this.gridColumnItens.Name = "gridColumnItens";
            this.gridColumnItens.OptionsColumn.AllowEdit = false;
            this.gridColumnItens.OptionsColumn.AllowFocus = false;
            this.gridColumnItens.Visible = true;
            this.gridColumnItens.VisibleIndex = 2;
            this.gridColumnItens.Width = 193;
            // 
            // txtItens
            // 
            this.txtItens.Name = "txtItens";
            // 
            // gridColumnValor
            // 
            this.gridColumnValor.Caption = "Valor";
            this.gridColumnValor.FieldName = "ValorFormatado";
            this.gridColumnValor.Name = "gridColumnValor";
            this.gridColumnValor.OptionsColumn.AllowEdit = false;
            this.gridColumnValor.OptionsColumn.AllowFocus = false;
            this.gridColumnValor.Visible = true;
            this.gridColumnValor.VisibleIndex = 4;
            this.gridColumnValor.Width = 128;
            // 
            // gridColumnValorRecebido
            // 
            this.gridColumnValorRecebido.Caption = "Valor Recebido";
            this.gridColumnValorRecebido.FieldName = "ValorPagoFormatado";
            this.gridColumnValorRecebido.Name = "gridColumnValorRecebido";
            this.gridColumnValorRecebido.OptionsColumn.AllowEdit = false;
            this.gridColumnValorRecebido.OptionsColumn.AllowFocus = false;
            this.gridColumnValorRecebido.Visible = true;
            this.gridColumnValorRecebido.VisibleIndex = 5;
            this.gridColumnValorRecebido.Width = 96;
            // 
            // gridColumnValorRestante
            // 
            this.gridColumnValorRestante.Caption = "Valor a Receber";
            this.gridColumnValorRestante.FieldName = "ValorAPagarFormatado";
            this.gridColumnValorRestante.Name = "gridColumnValorRestante";
            this.gridColumnValorRestante.OptionsColumn.AllowEdit = false;
            this.gridColumnValorRestante.OptionsColumn.AllowFocus = false;
            this.gridColumnValorRestante.Visible = true;
            this.gridColumnValorRestante.VisibleIndex = 6;
            this.gridColumnValorRestante.Width = 108;
            // 
            // gridColumnData
            // 
            this.gridColumnData.Caption = "Data";
            this.gridColumnData.FieldName = "Data";
            this.gridColumnData.Name = "gridColumnData";
            this.gridColumnData.OptionsColumn.AllowEdit = false;
            this.gridColumnData.OptionsColumn.AllowFocus = false;
            this.gridColumnData.Visible = true;
            this.gridColumnData.VisibleIndex = 3;
            this.gridColumnData.Width = 84;
            // 
            // gridColumnValorComissao
            // 
            this.gridColumnValorComissao.Caption = "Comissão";
            this.gridColumnValorComissao.FieldName = "ValorTotalComissaoFormatado";
            this.gridColumnValorComissao.Name = "gridColumnValorComissao";
            this.gridColumnValorComissao.OptionsColumn.AllowEdit = false;
            this.gridColumnValorComissao.OptionsColumn.AllowFocus = false;
            this.gridColumnValorComissao.Visible = true;
            this.gridColumnValorComissao.VisibleIndex = 7;
            this.gridColumnValorComissao.Width = 117;
            // 
            // gridColumnSituacao
            // 
            this.gridColumnSituacao.Caption = "Situação";
            this.gridColumnSituacao.FieldName = "StringSituacao";
            this.gridColumnSituacao.Name = "gridColumnSituacao";
            this.gridColumnSituacao.OptionsColumn.AllowEdit = false;
            this.gridColumnSituacao.OptionsColumn.AllowFocus = false;
            this.gridColumnSituacao.Visible = true;
            this.gridColumnSituacao.VisibleIndex = 8;
            this.gridColumnSituacao.Width = 86;
            // 
            // gridColumnParcelas
            // 
            this.gridColumnParcelas.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnParcelas.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnParcelas.Caption = "N° Parcelas";
            this.gridColumnParcelas.FieldName = "NumeroParcela";
            this.gridColumnParcelas.Name = "gridColumnParcelas";
            this.gridColumnParcelas.OptionsColumn.AllowEdit = false;
            this.gridColumnParcelas.OptionsColumn.AllowFocus = false;
            this.gridColumnParcelas.Visible = true;
            this.gridColumnParcelas.VisibleIndex = 9;
            this.gridColumnParcelas.Width = 65;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cboSituacao);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.dtFim);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.dtInicio);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.cboMarca);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1362, 100);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Filtros";
            // 
            // cboSituacao
            // 
            this.cboSituacao.DataSource = null;
            this.cboSituacao.DisplayMember = "";
            this.cboSituacao.IdObjetoRetorno = null;
            this.cboSituacao.Location = new System.Drawing.Point(419, 58);
            this.cboSituacao.Margin = new System.Windows.Forms.Padding(0);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.NaoMudarFocoTeclaEnter = false;
            this.cboSituacao.NaoMudarReadOnly = false;
            this.cboSituacao.PermitirTextoDigitadoQueNaoEstaNaLista = false;
            this.cboSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSituacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cboSituacao.Properties.ImmediatePopup = true;
            this.cboSituacao.Properties.NullText = "";
            this.cboSituacao.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboSituacao.Properties.PopupSizeable = false;
            this.cboSituacao.Properties.PopupView = this.gridView1;
            this.cboSituacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSituacao.Required = true;
            this.cboSituacao.RequiredMessage = null;
            this.cboSituacao.SelectedIndex = -1;
            this.cboSituacao.SelectedItem = null;
            this.cboSituacao.SelectedValue = null;
            this.cboSituacao.Size = new System.Drawing.Size(120, 20);
            this.cboSituacao.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 2";
            // 
            // MenuStripLayout2
            // 
            this.MenuStripLayout2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.aplicaçãoToolStripMenuItem});
            this.MenuStripLayout2.Location = new System.Drawing.Point(0, 0);
            this.MenuStripLayout2.Name = "MenuStripLayout2";
            this.MenuStripLayout2.Size = new System.Drawing.Size(1366, 24);
            this.MenuStripLayout2.TabIndex = 32;
            this.MenuStripLayout2.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuNovoPedido,
            this.btnMenuProduto,
            this.btnMenuMarca});
            this.cadastrosToolStripMenuItem.Image = global::View.Properties.Resources.IconeAdicionar_16px;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // btnMenuNovoPedido
            // 
            this.btnMenuNovoPedido.Image = global::View.Properties.Resources.IconeNovoPedido_16px;
            this.btnMenuNovoPedido.Name = "btnMenuNovoPedido";
            this.btnMenuNovoPedido.Size = new System.Drawing.Size(143, 22);
            this.btnMenuNovoPedido.Text = "Novo Pedido";
            // 
            // btnMenuProduto
            // 
            this.btnMenuProduto.Image = global::View.Properties.Resources.IconeProduto_16px;
            this.btnMenuProduto.Name = "btnMenuProduto";
            this.btnMenuProduto.Size = new System.Drawing.Size(143, 22);
            this.btnMenuProduto.Text = "Produtos";
            // 
            // btnMenuMarca
            // 
            this.btnMenuMarca.Image = global::View.Properties.Resources.IconeMarca_24px;
            this.btnMenuMarca.Name = "btnMenuMarca";
            this.btnMenuMarca.Size = new System.Drawing.Size(143, 22);
            this.btnMenuMarca.Text = "Marcas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuRel001_MaisVendidos});
            this.relatóriosToolStripMenuItem.Image = global::View.Properties.Resources.IconeRelatorio_16px;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // btnMenuRel001_MaisVendidos
            // 
            this.btnMenuRel001_MaisVendidos.Image = global::View.Properties.Resources.IconeRelatorio_16px;
            this.btnMenuRel001_MaisVendidos.Name = "btnMenuRel001_MaisVendidos";
            this.btnMenuRel001_MaisVendidos.Size = new System.Drawing.Size(150, 22);
            this.btnMenuRel001_MaisVendidos.Text = "Mais Vendidos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuEstoque,
            this.btnMenuPagamentos});
            this.consultasToolStripMenuItem.Image = global::View.Properties.Resources.IconeConsulta_16px;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // btnMenuEstoque
            // 
            this.btnMenuEstoque.Image = global::View.Properties.Resources.IconeEstoque_16px;
            this.btnMenuEstoque.Name = "btnMenuEstoque";
            this.btnMenuEstoque.Size = new System.Drawing.Size(140, 22);
            this.btnMenuEstoque.Text = "Estoque";
            // 
            // btnMenuPagamentos
            // 
            this.btnMenuPagamentos.Image = global::View.Properties.Resources.IconeConsultarPagamentos_16px;
            this.btnMenuPagamentos.Name = "btnMenuPagamentos";
            this.btnMenuPagamentos.Size = new System.Drawing.Size(140, 22);
            this.btnMenuPagamentos.Text = "Pagamentos";
            // 
            // aplicaçãoToolStripMenuItem
            // 
            this.aplicaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuConfiguracao});
            this.aplicaçãoToolStripMenuItem.Name = "aplicaçãoToolStripMenuItem";
            this.aplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aplicaçãoToolStripMenuItem.Text = "Outros";
            // 
            // btnMenuConfiguracao
            // 
            this.btnMenuConfiguracao.Image = global::View.Properties.Resources.IconeConfiduracao_16px;
            this.btnMenuConfiguracao.Name = "btnMenuConfiguracao";
            this.btnMenuConfiguracao.Size = new System.Drawing.Size(151, 22);
            this.btnMenuConfiguracao.Text = "Configurações";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 596);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.LayoutTabPanel);
            this.Controls.Add(this.MenuStripLayout2);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmInicio.IconOptions.Icon")));
            this.KeyPreview = true;
            this.Name = "frmInicio";
            this.Text = "Controle de Vendas - Versão : 1.1";
            this.Controls.SetChildIndex(this.MenuStripLayout2, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.LayoutTabPanel, 0);
            this.Controls.SetChildIndex(this.panelControl4, 0);
            this.Controls.SetChildIndex(this.panelControl2, 0);
            this.Controls.SetChildIndex(this.pnlPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConteudoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutTabPanel)).EndInit();
            this.LayoutTabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl)).EndInit();
            this.XtraTabControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.subMenuPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSituacao.Properties)).EndInit();
            this.MenuStripLayout2.ResumeLayout(false);
            this.MenuStripLayout2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dtFim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Utilitarios.Componentes.MyComboBox cboMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView txtConteudoView;
        private DevExpress.XtraEditors.PanelControl LayoutTabPanel;
        private DevExpress.XtraTab.XtraTabControl XtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnMarca;
        private DevExpress.XtraEditors.SimpleButton btnProdutos;
        private DevExpress.XtraEditors.SimpleButton btnNovoPedido;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnRel001_MaisVendidos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.SimpleButton btnEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblValorTotalComissao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnByteSituacao;
        private DevExpress.XtraEditors.PanelControl pnlPrincipal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridPedidos;
        private System.Windows.Forms.ContextMenuStrip subMenuPedidos;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuEditarPedido;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuFinalizarPedido;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuCancelarPedido;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuIncluirObservacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObservacoes;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorComissao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnParcelas;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Utilitarios.Componentes.MyComboBox cboSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuAdicionarPagamento;
        private DevExpress.XtraEditors.SimpleButton btnConsultarPagamentos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorRecebido;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorRestante;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnItens;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtItens;
        private System.Windows.Forms.MenuStrip MenuStripLayout2;
        private System.Windows.Forms.ToolStripMenuItem aplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuConfiguracao;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.SimpleButton btnConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuNovoPedido;
        private System.Windows.Forms.ToolStripMenuItem btnMenuProduto;
        private System.Windows.Forms.ToolStripMenuItem btnMenuMarca;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRel001_MaisVendidos;
        private System.Windows.Forms.ToolStripMenuItem btnMenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem btnMenuPagamentos;
        private System.Windows.Forms.ToolStripMenuItem btnSubMenuImprimirRecibo;
    }
}