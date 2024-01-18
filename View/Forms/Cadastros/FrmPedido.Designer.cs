﻿namespace View
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridProdutos = new DevExpress.XtraGrid.GridControl();
            this.contextMenuPedido = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExluirItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIncluirObservacao = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtObservacaoGrid = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupDadosDoPedido = new DevExpress.XtraEditors.GroupControl();
            this.pnlDias = new DevExpress.XtraEditors.PanelControl();
            this.txtDiasParaPagamento = new Utilitarios.Componentes.MyTextBox();
            this.lblDiasParaPagar = new DevExpress.XtraEditors.LabelControl();
            this.dtPagamento = new DevExpress.XtraEditors.DateEdit();
            this.btnAdicionarNovoCliente = new DevExpress.XtraEditors.SimpleButton();
            this.spinNumeroParcelas = new DevExpress.XtraEditors.SpinEdit();
            this.cboCliente = new Utilitarios.Componentes.MyComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeNovoCliente = new Utilitarios.Componentes.MyTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pnlInserirDados = new DevExpress.XtraEditors.PanelControl();
            this.groupDadosProduto = new DevExpress.XtraEditors.GroupControl();
            this.txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.groupDadosNovoProduto = new DevExpress.XtraEditors.GroupControl();
            this.txtProduto = new Utilitarios.Componentes.MyTextBox();
            this.btnEstipularValor = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovaMarca = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorProduto = new Utilitarios.Componentes.MyTextBox();
            this.cboMarca = new Utilitarios.Componentes.MyComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Utilitarios.Componentes.MyTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdicionarProduto = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new Utilitarios.Componentes.MyTextBox();
            this.cboProduto = new Utilitarios.Componentes.MyComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblDescValorParcela = new DevExpress.XtraEditors.LabelControl();
            this.lblValorTotalPedido = new DevExpress.XtraEditors.LabelControl();
            this.lblValorParcela = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lblDataParcela1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDescDataParcela2 = new DevExpress.XtraEditors.LabelControl();
            this.lblDataParcela2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pnlValorDaParcela = new DevExpress.XtraEditors.PanelControl();
            this.pnlDatas = new DevExpress.XtraEditors.PanelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.contextMenuPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDadosDoPedido)).BeginInit();
            this.groupDadosDoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDias)).BeginInit();
            this.pnlDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasParaPagamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPagamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPagamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumeroParcelas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeNovoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInserirDados)).BeginInit();
            this.pnlInserirDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDadosProduto)).BeginInit();
            this.groupDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDadosNovoProduto)).BeginInit();
            this.groupDadosNovoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlValorDaParcela)).BeginInit();
            this.pnlValorDaParcela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatas)).BeginInit();
            this.pnlDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(1100, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.pnlDatas);
            this.panelControl4.Controls.Add(this.panelControl3);
            this.panelControl4.Location = new System.Drawing.Point(0, 623);
            this.panelControl4.Size = new System.Drawing.Size(1100, 98);
            this.panelControl4.Controls.SetChildIndex(this.panel1, 0);
            this.panelControl4.Controls.SetChildIndex(this.panelControl3, 0);
            this.panelControl4.Controls.SetChildIndex(this.pnlDatas, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(894, 2);
            this.panel1.Size = new System.Drawing.Size(204, 94);
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(118, 32);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(118, 61);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl3);
            this.panelControl2.Controls.Add(this.groupDadosDoPedido);
            this.panelControl2.Controls.Add(this.pnlInserirDados);
            this.panelControl2.Size = new System.Drawing.Size(1100, 589);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridProdutos);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(349, 128);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(749, 459);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Itens Do Pedido";
            // 
            // gridProdutos
            // 
            this.gridProdutos.ContextMenuStrip = this.contextMenuPedido;
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridProdutos.Location = new System.Drawing.Point(2, 23);
            this.gridProdutos.MainView = this.gridViewProdutos;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtObservacaoGrid});
            this.gridProdutos.Size = new System.Drawing.Size(745, 434);
            this.gridProdutos.TabIndex = 30;
            this.gridProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos});
            // 
            // contextMenuPedido
            // 
            this.contextMenuPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExluirItem,
            this.btnIncluirObservacao});
            this.contextMenuPedido.Name = "contextMenuPedido";
            this.contextMenuPedido.Size = new System.Drawing.Size(173, 48);
            // 
            // btnExluirItem
            // 
            this.btnExluirItem.Image = global::View.Properties.Resources.IconeCancelar_16px;
            this.btnExluirItem.Name = "btnExluirItem";
            this.btnExluirItem.Size = new System.Drawing.Size(172, 22);
            this.btnExluirItem.Text = "Exluir item";
            // 
            // btnIncluirObservacao
            // 
            this.btnIncluirObservacao.Image = global::View.Properties.Resources.IconeObservacao_24px;
            this.btnIncluirObservacao.Name = "btnIncluirObservacao";
            this.btnIncluirObservacao.Size = new System.Drawing.Size(172, 22);
            this.btnIncluirObservacao.Text = "Incluir Observação";
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewProdutos.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewProdutos.AutoFillColumn = this.gridColumnObservacao;
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProduto,
            this.gridColumnValor,
            this.gridColumnValorTotal,
            this.gridColumnCodigo,
            this.gridColumnMarca,
            this.gridColumnQuantidade,
            this.gridColumnObservacao});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(211)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = 1;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.LightBlue;
            formatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = 2;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            formatConditionRuleValue3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = 3;
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Name = "Format3";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(206)))));
            formatConditionRuleValue4.Appearance.BackColor2 = System.Drawing.Color.Honeydew;
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = 4;
            gridFormatRule4.Rule = formatConditionRuleValue4;
            gridFormatRule5.ApplyToRow = true;
            gridFormatRule5.Name = "Format4";
            formatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(124)))));
            formatConditionRuleValue5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleValue5.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = true;
            gridFormatRule5.Rule = formatConditionRuleValue5;
            this.gridViewProdutos.FormatRules.Add(gridFormatRule1);
            this.gridViewProdutos.FormatRules.Add(gridFormatRule2);
            this.gridViewProdutos.FormatRules.Add(gridFormatRule3);
            this.gridViewProdutos.FormatRules.Add(gridFormatRule4);
            this.gridViewProdutos.FormatRules.Add(gridFormatRule5);
            this.gridViewProdutos.GridControl = this.gridProdutos;
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewProdutos.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewProdutos.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewProdutos.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewProdutos.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewProdutos.OptionsPrint.PrintFooter = false;
            this.gridViewProdutos.OptionsPrint.PrintGroupFooter = false;
            this.gridViewProdutos.OptionsPrint.PrintVertLines = false;
            this.gridViewProdutos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProdutos.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewProdutos.OptionsSelection.MultiSelect = true;
            this.gridViewProdutos.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewProdutos.OptionsView.ColumnAutoWidth = false;
            this.gridViewProdutos.OptionsView.RowAutoHeight = true;
            this.gridViewProdutos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProdutos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnObservacao
            // 
            this.gridColumnObservacao.Caption = "Observação";
            this.gridColumnObservacao.ColumnEdit = this.txtObservacaoGrid;
            this.gridColumnObservacao.FieldName = "ObservacaosConcatenadas";
            this.gridColumnObservacao.Name = "gridColumnObservacao";
            this.gridColumnObservacao.Visible = true;
            this.gridColumnObservacao.VisibleIndex = 6;
            // 
            // txtObservacaoGrid
            // 
            this.txtObservacaoGrid.Name = "txtObservacaoGrid";
            // 
            // gridColumnProduto
            // 
            this.gridColumnProduto.Caption = "Produto";
            this.gridColumnProduto.FieldName = "ProdutoDescricao";
            this.gridColumnProduto.Name = "gridColumnProduto";
            this.gridColumnProduto.Visible = true;
            this.gridColumnProduto.VisibleIndex = 0;
            this.gridColumnProduto.Width = 115;
            // 
            // gridColumnValor
            // 
            this.gridColumnValor.Caption = "Valor Unitario";
            this.gridColumnValor.FieldName = "ValorProdutoFormatado";
            this.gridColumnValor.Name = "gridColumnValor";
            this.gridColumnValor.Visible = true;
            this.gridColumnValor.VisibleIndex = 1;
            this.gridColumnValor.Width = 87;
            // 
            // gridColumnValorTotal
            // 
            this.gridColumnValorTotal.Caption = "Valor total";
            this.gridColumnValorTotal.FieldName = "ValorTotalFormatado";
            this.gridColumnValorTotal.Name = "gridColumnValorTotal";
            this.gridColumnValorTotal.Visible = true;
            this.gridColumnValorTotal.VisibleIndex = 2;
            // 
            // gridColumnCodigo
            // 
            this.gridColumnCodigo.Caption = "Codigo";
            this.gridColumnCodigo.FieldName = "CodigoProduto";
            this.gridColumnCodigo.Name = "gridColumnCodigo";
            this.gridColumnCodigo.Visible = true;
            this.gridColumnCodigo.VisibleIndex = 3;
            // 
            // gridColumnMarca
            // 
            this.gridColumnMarca.Caption = "Marca";
            this.gridColumnMarca.FieldName = "ProdutoMarca";
            this.gridColumnMarca.Name = "gridColumnMarca";
            this.gridColumnMarca.Visible = true;
            this.gridColumnMarca.VisibleIndex = 4;
            // 
            // gridColumnQuantidade
            // 
            this.gridColumnQuantidade.Caption = "Quantidade";
            this.gridColumnQuantidade.FieldName = "Quantidade";
            this.gridColumnQuantidade.Name = "gridColumnQuantidade";
            this.gridColumnQuantidade.OptionsColumn.AllowEdit = false;
            this.gridColumnQuantidade.OptionsColumn.AllowFocus = false;
            this.gridColumnQuantidade.Visible = true;
            this.gridColumnQuantidade.VisibleIndex = 5;
            // 
            // groupDadosDoPedido
            // 
            this.groupDadosDoPedido.Controls.Add(this.pnlDias);
            this.groupDadosDoPedido.Controls.Add(this.dtPagamento);
            this.groupDadosDoPedido.Controls.Add(this.btnAdicionarNovoCliente);
            this.groupDadosDoPedido.Controls.Add(this.spinNumeroParcelas);
            this.groupDadosDoPedido.Controls.Add(this.cboCliente);
            this.groupDadosDoPedido.Controls.Add(this.labelControl12);
            this.groupDadosDoPedido.Controls.Add(this.labelControl7);
            this.groupDadosDoPedido.Controls.Add(this.labelControl1);
            this.groupDadosDoPedido.Controls.Add(this.txtNomeNovoCliente);
            this.groupDadosDoPedido.Controls.Add(this.labelControl6);
            this.groupDadosDoPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDadosDoPedido.Location = new System.Drawing.Point(349, 2);
            this.groupDadosDoPedido.Name = "groupDadosDoPedido";
            this.groupDadosDoPedido.Size = new System.Drawing.Size(749, 126);
            this.groupDadosDoPedido.TabIndex = 12;
            this.groupDadosDoPedido.Text = "Dados do Pedido";
            // 
            // pnlDias
            // 
            this.pnlDias.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDias.Controls.Add(this.txtDiasParaPagamento);
            this.pnlDias.Controls.Add(this.lblDiasParaPagar);
            this.pnlDias.Location = new System.Drawing.Point(126, 74);
            this.pnlDias.Name = "pnlDias";
            this.pnlDias.Size = new System.Drawing.Size(136, 46);
            this.pnlDias.TabIndex = 31;
            this.pnlDias.Visible = false;
            // 
            // txtDiasParaPagamento
            // 
            this.txtDiasParaPagamento.Location = new System.Drawing.Point(5, 22);
            this.txtDiasParaPagamento.Name = "txtDiasParaPagamento";
            this.txtDiasParaPagamento.Required = true;
            this.txtDiasParaPagamento.RequiredMessege = "Informe a quantidade.";
            this.txtDiasParaPagamento.Size = new System.Drawing.Size(87, 20);
            this.txtDiasParaPagamento.TabIndex = 9;
            this.txtDiasParaPagamento.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // lblDiasParaPagar
            // 
            this.lblDiasParaPagar.Location = new System.Drawing.Point(5, 3);
            this.lblDiasParaPagar.Name = "lblDiasParaPagar";
            this.lblDiasParaPagar.Size = new System.Drawing.Size(92, 13);
            this.lblDiasParaPagar.TabIndex = 10;
            this.lblDiasParaPagar.Text = "Dias entre parcelas";
            // 
            // dtPagamento
            // 
            this.dtPagamento.EditValue = null;
            this.dtPagamento.Location = new System.Drawing.Point(20, 96);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPagamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPagamento.Size = new System.Drawing.Size(100, 20);
            this.dtPagamento.TabIndex = 11;
            // 
            // btnAdicionarNovoCliente
            // 
            this.btnAdicionarNovoCliente.ImageOptions.Image = global::View.Properties.Resources.IconeAdicionar_16px;
            this.btnAdicionarNovoCliente.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdicionarNovoCliente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdicionarNovoCliente.Location = new System.Drawing.Point(406, 51);
            this.btnAdicionarNovoCliente.Name = "btnAdicionarNovoCliente";
            this.btnAdicionarNovoCliente.Size = new System.Drawing.Size(81, 20);
            this.btnAdicionarNovoCliente.TabIndex = 2;
            this.btnAdicionarNovoCliente.Text = "Adicionar";
            // 
            // spinNumeroParcelas
            // 
            this.spinNumeroParcelas.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNumeroParcelas.Location = new System.Drawing.Point(493, 51);
            this.spinNumeroParcelas.Name = "spinNumeroParcelas";
            this.spinNumeroParcelas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNumeroParcelas.Properties.IsFloatValue = false;
            this.spinNumeroParcelas.Properties.Mask.EditMask = "N00";
            this.spinNumeroParcelas.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinNumeroParcelas.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNumeroParcelas.Properties.NullText = "1";
            this.spinNumeroParcelas.Size = new System.Drawing.Size(55, 20);
            this.spinNumeroParcelas.TabIndex = 3;
            // 
            // cboCliente
            // 
            this.cboCliente.DataSource = null;
            this.cboCliente.DisplayMember = "";
            this.cboCliente.EditValue = -1;
            this.cboCliente.IdObjetoRetorno = null;
            this.cboCliente.Location = new System.Drawing.Point(20, 51);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(0);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.NaoMudarFocoTeclaEnter = false;
            this.cboCliente.NaoMudarReadOnly = false;
            this.cboCliente.PermitirTextoDigitadoQueNaoEstaNaLista = false;
            this.cboCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCliente.Properties.NullText = "";
            this.cboCliente.Required = true;
            this.cboCliente.RequiredMessage = "Informe o Cliente.";
            this.cboCliente.SelectedIndex = -1;
            this.cboCliente.SelectedValue = -1;
            this.cboCliente.Size = new System.Drawing.Size(184, 20);
            this.cboCliente.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(216, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Novo Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Data Pagamento";
            // 
            // txtNomeNovoCliente
            // 
            this.txtNomeNovoCliente.Location = new System.Drawing.Point(216, 51);
            this.txtNomeNovoCliente.Name = "txtNomeNovoCliente";
            this.txtNomeNovoCliente.Required = true;
            this.txtNomeNovoCliente.RequiredMessege = "Informe o nome do novo cliente.";
            this.txtNomeNovoCliente.Size = new System.Drawing.Size(184, 20);
            this.txtNomeNovoCliente.TabIndex = 1;
            this.txtNomeNovoCliente.Tipo = Utilitarios.Enumerators.ETipoTextBox.Padrao;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(493, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "N° Parcelas";
            // 
            // pnlInserirDados
            // 
            this.pnlInserirDados.Controls.Add(this.groupDadosProduto);
            this.pnlInserirDados.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInserirDados.Location = new System.Drawing.Point(2, 2);
            this.pnlInserirDados.Name = "pnlInserirDados";
            this.pnlInserirDados.Size = new System.Drawing.Size(347, 585);
            this.pnlInserirDados.TabIndex = 10;
            // 
            // groupDadosProduto
            // 
            this.groupDadosProduto.Controls.Add(this.txtObservacao);
            this.groupDadosProduto.Controls.Add(this.groupDadosNovoProduto);
            this.groupDadosProduto.Controls.Add(this.btnAdicionarProduto);
            this.groupDadosProduto.Controls.Add(this.labelControl11);
            this.groupDadosProduto.Controls.Add(this.labelControl8);
            this.groupDadosProduto.Controls.Add(this.txtQuantidade);
            this.groupDadosProduto.Controls.Add(this.cboProduto);
            this.groupDadosProduto.Controls.Add(this.labelControl10);
            this.groupDadosProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDadosProduto.Location = new System.Drawing.Point(2, 2);
            this.groupDadosProduto.Name = "groupDadosProduto";
            this.groupDadosProduto.Size = new System.Drawing.Size(343, 581);
            this.groupDadosProduto.TabIndex = 4;
            this.groupDadosProduto.Text = "Dados do Produto";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(21, 451);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(296, 113);
            this.txtObservacao.TabIndex = 3;
            // 
            // groupDadosNovoProduto
            // 
            this.groupDadosNovoProduto.Controls.Add(this.txtProduto);
            this.groupDadosNovoProduto.Controls.Add(this.btnEstipularValor);
            this.groupDadosNovoProduto.Controls.Add(this.btnNovaMarca);
            this.groupDadosNovoProduto.Controls.Add(this.labelControl2);
            this.groupDadosNovoProduto.Controls.Add(this.txtValorProduto);
            this.groupDadosNovoProduto.Controls.Add(this.cboMarca);
            this.groupDadosNovoProduto.Controls.Add(this.labelControl3);
            this.groupDadosNovoProduto.Controls.Add(this.labelControl5);
            this.groupDadosNovoProduto.Controls.Add(this.txtCodigo);
            this.groupDadosNovoProduto.Controls.Add(this.labelControl4);
            this.groupDadosNovoProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDadosNovoProduto.Location = new System.Drawing.Point(2, 23);
            this.groupDadosNovoProduto.Name = "groupDadosNovoProduto";
            this.groupDadosNovoProduto.Size = new System.Drawing.Size(339, 232);
            this.groupDadosNovoProduto.TabIndex = 10;
            this.groupDadosNovoProduto.Text = "Adicionar Novo Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(19, 46);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Required = true;
            this.txtProduto.RequiredMessege = "Informe o nome do Produto.";
            this.txtProduto.Size = new System.Drawing.Size(184, 20);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.Tipo = Utilitarios.Enumerators.ETipoTextBox.Padrao;
            // 
            // btnEstipularValor
            // 
            this.btnEstipularValor.Appearance.Options.UseTextOptions = true;
            this.btnEstipularValor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnEstipularValor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnEstipularValor.ImageOptions.Image = global::View.Properties.Resources.IconeCifrao_16px;
            this.btnEstipularValor.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEstipularValor.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEstipularValor.Location = new System.Drawing.Point(209, 94);
            this.btnEstipularValor.Name = "btnEstipularValor";
            this.btnEstipularValor.Size = new System.Drawing.Size(106, 20);
            this.btnEstipularValor.TabIndex = 2;
            this.btnEstipularValor.Text = "Estipular valor";
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Appearance.Options.UseTextOptions = true;
            this.btnNovaMarca.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnNovaMarca.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNovaMarca.ImageOptions.Image = global::View.Properties.Resources.IconeMarca_16px;
            this.btnNovaMarca.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNovaMarca.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNovaMarca.Location = new System.Drawing.Point(209, 198);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(106, 20);
            this.btnNovaMarca.TabIndex = 5;
            this.btnNovaMarca.Text = "Nova Marca";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Produto";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(19, 94);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Required = true;
            this.txtValorProduto.RequiredMessege = "Informe o valor do produto.";
            this.txtValorProduto.Size = new System.Drawing.Size(184, 20);
            this.txtValorProduto.TabIndex = 1;
            this.txtValorProduto.Tipo = Utilitarios.Enumerators.ETipoTextBox.Monetario;
            // 
            // cboMarca
            // 
            this.cboMarca.DataSource = null;
            this.cboMarca.DisplayMember = "";
            this.cboMarca.EditValue = -1;
            this.cboMarca.IdObjetoRetorno = null;
            this.cboMarca.Location = new System.Drawing.Point(19, 198);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(0);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.NaoMudarFocoTeclaEnter = false;
            this.cboMarca.NaoMudarReadOnly = false;
            this.cboMarca.PermitirTextoDigitadoQueNaoEstaNaLista = false;
            this.cboMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMarca.Properties.NullText = "";
            this.cboMarca.Required = true;
            this.cboMarca.RequiredMessage = "Informe a Marca.";
            this.cboMarca.SelectedIndex = -1;
            this.cboMarca.SelectedValue = -1;
            this.cboMarca.Size = new System.Drawing.Size(184, 20);
            this.cboMarca.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Valor";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 143);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Required = true;
            this.txtCodigo.RequiredMessege = "Informe o codigo do produto.";
            this.txtCodigo.Size = new System.Drawing.Size(184, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 124);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Codigo";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.ImageOptions.Image = global::View.Properties.Resources.IconeAdicionar_16px;
            this.btnAdicionarProduto.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(21, 379);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarProduto.TabIndex = 2;
            this.btnAdicionarProduto.Text = "Adicionar";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(21, 432);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(112, 13);
            this.labelControl11.TabIndex = 4;
            this.labelControl11.Text = "Observação do pedido:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(21, 320);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(21, 339);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Required = true;
            this.txtQuantidade.RequiredMessege = "Informe a quantidade.";
            this.txtQuantidade.Size = new System.Drawing.Size(87, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // cboProduto
            // 
            this.cboProduto.DataSource = null;
            this.cboProduto.DisplayMember = "";
            this.cboProduto.EditValue = -1;
            this.cboProduto.IdObjetoRetorno = null;
            this.cboProduto.Location = new System.Drawing.Point(21, 294);
            this.cboProduto.Margin = new System.Windows.Forms.Padding(0);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.NaoMudarFocoTeclaEnter = false;
            this.cboProduto.NaoMudarReadOnly = false;
            this.cboProduto.PermitirTextoDigitadoQueNaoEstaNaLista = false;
            this.cboProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProduto.Properties.NullText = "";
            this.cboProduto.Required = true;
            this.cboProduto.RequiredMessage = "Informe o Produto.";
            this.cboProduto.SelectedIndex = -1;
            this.cboProduto.SelectedValue = -1;
            this.cboProduto.Size = new System.Drawing.Size(184, 20);
            this.cboProduto.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(21, 274);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(105, 13);
            this.labelControl10.TabIndex = 9;
            this.labelControl10.Text = "Produtos cadastrados";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(14, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(142, 16);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "Valor Total do Pedido:";
            // 
            // lblDescValorParcela
            // 
            this.lblDescValorParcela.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescValorParcela.Appearance.Options.UseFont = true;
            this.lblDescValorParcela.Location = new System.Drawing.Point(12, 15);
            this.lblDescValorParcela.Name = "lblDescValorParcela";
            this.lblDescValorParcela.Size = new System.Drawing.Size(147, 16);
            this.lblDescValorParcela.TabIndex = 14;
            this.lblDescValorParcela.Text = "Valor Total da parcela:";
            // 
            // lblValorTotalPedido
            // 
            this.lblValorTotalPedido.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalPedido.Appearance.Options.UseFont = true;
            this.lblValorTotalPedido.Location = new System.Drawing.Point(162, 14);
            this.lblValorTotalPedido.Name = "lblValorTotalPedido";
            this.lblValorTotalPedido.Size = new System.Drawing.Size(24, 16);
            this.lblValorTotalPedido.TabIndex = 13;
            this.lblValorTotalPedido.Text = "      ";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcela.Appearance.Options.UseFont = true;
            this.lblValorParcela.Location = new System.Drawing.Point(165, 15);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(24, 16);
            this.lblValorParcela.TabIndex = 13;
            this.lblValorParcela.Text = "      ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(30, 14);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(188, 16);
            this.labelControl13.TabIndex = 13;
            this.labelControl13.Text = "Data pagamento 1° Parcela: ";
            // 
            // lblDataParcela1
            // 
            this.lblDataParcela1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataParcela1.Appearance.Options.UseFont = true;
            this.lblDataParcela1.Location = new System.Drawing.Point(221, 12);
            this.lblDataParcela1.Name = "lblDataParcela1";
            this.lblDataParcela1.Size = new System.Drawing.Size(24, 16);
            this.lblDataParcela1.TabIndex = 13;
            this.lblDataParcela1.Text = "      ";
            // 
            // lblDescDataParcela2
            // 
            this.lblDescDataParcela2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescDataParcela2.Appearance.Options.UseFont = true;
            this.lblDescDataParcela2.Location = new System.Drawing.Point(30, 61);
            this.lblDescDataParcela2.Name = "lblDescDataParcela2";
            this.lblDescDataParcela2.Size = new System.Drawing.Size(188, 16);
            this.lblDescDataParcela2.TabIndex = 13;
            this.lblDescDataParcela2.Text = "Data pagamento 2° Parcela: ";
            // 
            // lblDataParcela2
            // 
            this.lblDataParcela2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataParcela2.Appearance.Options.UseFont = true;
            this.lblDataParcela2.Location = new System.Drawing.Point(221, 61);
            this.lblDataParcela2.Name = "lblDataParcela2";
            this.lblDataParcela2.Size = new System.Drawing.Size(24, 16);
            this.lblDataParcela2.TabIndex = 13;
            this.lblDataParcela2.Text = "      ";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.pnlValorDaParcela);
            this.panelControl3.Controls.Add(this.labelControl9);
            this.panelControl3.Controls.Add(this.lblValorTotalPedido);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(238, 94);
            this.panelControl3.TabIndex = 15;
            // 
            // pnlValorDaParcela
            // 
            this.pnlValorDaParcela.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlValorDaParcela.Controls.Add(this.lblDescValorParcela);
            this.pnlValorDaParcela.Controls.Add(this.lblValorParcela);
            this.pnlValorDaParcela.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlValorDaParcela.Location = new System.Drawing.Point(0, 48);
            this.pnlValorDaParcela.Name = "pnlValorDaParcela";
            this.pnlValorDaParcela.Size = new System.Drawing.Size(238, 46);
            this.pnlValorDaParcela.TabIndex = 14;
            this.pnlValorDaParcela.Visible = false;
            // 
            // pnlDatas
            // 
            this.pnlDatas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDatas.Controls.Add(this.labelControl13);
            this.pnlDatas.Controls.Add(this.lblDescDataParcela2);
            this.pnlDatas.Controls.Add(this.lblDataParcela1);
            this.pnlDatas.Controls.Add(this.lblDataParcela2);
            this.pnlDatas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatas.Location = new System.Drawing.Point(240, 2);
            this.pnlDatas.Name = "pnlDatas";
            this.pnlDatas.Size = new System.Drawing.Size(344, 94);
            this.pnlDatas.TabIndex = 16;
            this.pnlDatas.Visible = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(20, 32);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(33, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Cliente";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1100, 721);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmPedido.IconOptions.Icon")));
            this.Name = "FrmPedido";
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.panelControl4, 0);
            this.Controls.SetChildIndex(this.panelControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.contextMenuPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDadosDoPedido)).EndInit();
            this.groupDadosDoPedido.ResumeLayout(false);
            this.groupDadosDoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDias)).EndInit();
            this.pnlDias.ResumeLayout(false);
            this.pnlDias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasParaPagamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPagamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPagamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumeroParcelas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeNovoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInserirDados)).EndInit();
            this.pnlInserirDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDadosProduto)).EndInit();
            this.groupDadosProduto.ResumeLayout(false);
            this.groupDadosProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDadosNovoProduto)).EndInit();
            this.groupDadosNovoProduto.ResumeLayout(false);
            this.groupDadosNovoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlValorDaParcela)).EndInit();
            this.pnlValorDaParcela.ResumeLayout(false);
            this.pnlValorDaParcela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatas)).EndInit();
            this.pnlDatas.ResumeLayout(false);
            this.pnlDatas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObservacao;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtObservacaoGrid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProduto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMarca;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantidade;
        private DevExpress.XtraEditors.GroupControl groupDadosDoPedido;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarNovoCliente;
        private DevExpress.XtraEditors.SpinEdit spinNumeroParcelas;
        private Utilitarios.Componentes.MyComboBox cboCliente;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Utilitarios.Componentes.MyTextBox txtNomeNovoCliente;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl pnlInserirDados;
        private DevExpress.XtraEditors.GroupControl groupDadosProduto;
        private DevExpress.XtraEditors.MemoEdit txtObservacao;
        private DevExpress.XtraEditors.GroupControl groupDadosNovoProduto;
        private Utilitarios.Componentes.MyTextBox txtProduto;
        private DevExpress.XtraEditors.SimpleButton btnEstipularValor;
        private DevExpress.XtraEditors.SimpleButton btnNovaMarca;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Utilitarios.Componentes.MyTextBox txtValorProduto;
        private Utilitarios.Componentes.MyComboBox cboMarca;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Utilitarios.Componentes.MyTextBox txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarProduto;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Utilitarios.Componentes.MyTextBox txtQuantidade;
        private Utilitarios.Componentes.MyComboBox cboProduto;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblDescValorParcela;
        private DevExpress.XtraEditors.LabelControl lblValorParcela;
        private DevExpress.XtraEditors.LabelControl lblValorTotalPedido;
        private System.Windows.Forms.ContextMenuStrip contextMenuPedido;
        private System.Windows.Forms.ToolStripMenuItem btnExluirItem;
        private System.Windows.Forms.ToolStripMenuItem btnIncluirObservacao;
        private DevExpress.XtraEditors.LabelControl lblDiasParaPagar;
        private Utilitarios.Componentes.MyTextBox txtDiasParaPagamento;
        private DevExpress.XtraEditors.LabelControl lblDataParcela2;
        private DevExpress.XtraEditors.LabelControl lblDataParcela1;
        private DevExpress.XtraEditors.LabelControl lblDescDataParcela2;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.DateEdit dtPagamento;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl pnlValorDaParcela;
        private DevExpress.XtraEditors.PanelControl pnlDatas;
        private DevExpress.XtraEditors.PanelControl pnlDias;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}