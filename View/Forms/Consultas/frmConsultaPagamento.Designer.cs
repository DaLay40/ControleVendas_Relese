namespace View.Forms.Consultas
{
    partial class frmConsultaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPagamento));
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
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorRecebido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorRestante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSelecionarConta = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorTotalRecebido = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelecionarConta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(1317, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lblValorTotalRecebido);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Location = new System.Drawing.Point(0, 445);
            this.panelControl4.Size = new System.Drawing.Size(1317, 44);
            this.panelControl4.Controls.SetChildIndex(this.panel1, 0);
            this.panelControl4.Controls.SetChildIndex(this.labelControl1, 0);
            this.panelControl4.Controls.SetChildIndex(this.lblValorTotalRecebido, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1112, 2);
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
            this.panelControl2.Controls.Add(this.gridConsulta);
            this.panelControl2.Size = new System.Drawing.Size(1317, 411);
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridConsulta.Location = new System.Drawing.Point(2, 2);
            this.gridConsulta.MainView = this.gridViewConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSelecionarConta});
            this.gridConsulta.Size = new System.Drawing.Size(1313, 407);
            this.gridConsulta.TabIndex = 34;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewConsulta.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewConsulta.AutoFillColumn = this.gridColumnCliente;
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCliente,
            this.gridColumnValorOriginal,
            this.gridColumnValorRecebido,
            this.gridColumnValorDesconto,
            this.gridColumnData,
            this.gridColumnFormaPagamento,
            this.gridColumnValorRestante,
            this.gridColumnTipo});
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
            this.gridViewConsulta.FormatRules.Add(gridFormatRule1);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule2);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule3);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule4);
            this.gridViewConsulta.FormatRules.Add(gridFormatRule5);
            this.gridViewConsulta.GridControl = this.gridConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewConsulta.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewConsulta.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewConsulta.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewConsulta.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewConsulta.OptionsPrint.PrintFooter = false;
            this.gridViewConsulta.OptionsPrint.PrintGroupFooter = false;
            this.gridViewConsulta.OptionsPrint.PrintVertLines = false;
            this.gridViewConsulta.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewConsulta.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewConsulta.OptionsSelection.MultiSelect = true;
            this.gridViewConsulta.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridViewConsulta.OptionsView.RowAutoHeight = true;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
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
            this.gridColumnCliente.Width = 152;
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
            this.gridColumnId.Width = 62;
            // 
            // gridColumnValorOriginal
            // 
            this.gridColumnValorOriginal.Caption = "Valor Pedido";
            this.gridColumnValorOriginal.FieldName = "ValorOriginalPedido";
            this.gridColumnValorOriginal.Name = "gridColumnValorOriginal";
            this.gridColumnValorOriginal.OptionsColumn.AllowEdit = false;
            this.gridColumnValorOriginal.OptionsColumn.AllowFocus = false;
            this.gridColumnValorOriginal.Visible = true;
            this.gridColumnValorOriginal.VisibleIndex = 2;
            this.gridColumnValorOriginal.Width = 152;
            // 
            // gridColumnValorRecebido
            // 
            this.gridColumnValorRecebido.Caption = "Valor recebido";
            this.gridColumnValorRecebido.FieldName = "ValorRecebido";
            this.gridColumnValorRecebido.Name = "gridColumnValorRecebido";
            this.gridColumnValorRecebido.OptionsColumn.AllowEdit = false;
            this.gridColumnValorRecebido.OptionsColumn.AllowFocus = false;
            this.gridColumnValorRecebido.Visible = true;
            this.gridColumnValorRecebido.VisibleIndex = 3;
            this.gridColumnValorRecebido.Width = 152;
            // 
            // gridColumnValorDesconto
            // 
            this.gridColumnValorDesconto.Caption = "Desconto";
            this.gridColumnValorDesconto.FieldName = "ValorDesconto";
            this.gridColumnValorDesconto.Name = "gridColumnValorDesconto";
            this.gridColumnValorDesconto.OptionsColumn.AllowEdit = false;
            this.gridColumnValorDesconto.OptionsColumn.AllowFocus = false;
            this.gridColumnValorDesconto.Visible = true;
            this.gridColumnValorDesconto.VisibleIndex = 4;
            this.gridColumnValorDesconto.Width = 152;
            // 
            // gridColumnData
            // 
            this.gridColumnData.Caption = "Data";
            this.gridColumnData.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumnData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnData.FieldName = "Data";
            this.gridColumnData.Name = "gridColumnData";
            this.gridColumnData.OptionsColumn.AllowEdit = false;
            this.gridColumnData.OptionsColumn.AllowFocus = false;
            this.gridColumnData.Visible = true;
            this.gridColumnData.VisibleIndex = 5;
            this.gridColumnData.Width = 152;
            // 
            // gridColumnFormaPagamento
            // 
            this.gridColumnFormaPagamento.Caption = "Forma De Pagamento";
            this.gridColumnFormaPagamento.FieldName = "FormaPagamento";
            this.gridColumnFormaPagamento.Name = "gridColumnFormaPagamento";
            this.gridColumnFormaPagamento.OptionsColumn.AllowEdit = false;
            this.gridColumnFormaPagamento.OptionsColumn.AllowFocus = false;
            this.gridColumnFormaPagamento.Visible = true;
            this.gridColumnFormaPagamento.VisibleIndex = 6;
            this.gridColumnFormaPagamento.Width = 152;
            // 
            // gridColumnValorRestante
            // 
            this.gridColumnValorRestante.Caption = "Valor Restante apos pagamento";
            this.gridColumnValorRestante.FieldName = "ValorRestante";
            this.gridColumnValorRestante.Name = "gridColumnValorRestante";
            this.gridColumnValorRestante.OptionsColumn.AllowEdit = false;
            this.gridColumnValorRestante.OptionsColumn.AllowFocus = false;
            this.gridColumnValorRestante.Visible = true;
            this.gridColumnValorRestante.VisibleIndex = 7;
            this.gridColumnValorRestante.Width = 152;
            // 
            // gridColumnTipo
            // 
            this.gridColumnTipo.Caption = "Tipo Pagamento";
            this.gridColumnTipo.FieldName = "DescTipo";
            this.gridColumnTipo.Name = "gridColumnTipo";
            this.gridColumnTipo.OptionsColumn.AllowEdit = false;
            this.gridColumnTipo.OptionsColumn.AllowFocus = false;
            this.gridColumnTipo.Visible = true;
            this.gridColumnTipo.VisibleIndex = 8;
            this.gridColumnTipo.Width = 162;
            // 
            // chkSelecionarConta
            // 
            this.chkSelecionarConta.AutoHeight = false;
            this.chkSelecionarConta.Name = "chkSelecionarConta";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Total Recebido:";
            // 
            // lblValorTotalRecebido
            // 
            this.lblValorTotalRecebido.Location = new System.Drawing.Point(91, 16);
            this.lblValorTotalRecebido.Name = "lblValorTotalRecebido";
            this.lblValorTotalRecebido.Size = new System.Drawing.Size(24, 13);
            this.lblValorTotalRecebido.TabIndex = 13;
            this.lblValorTotalRecebido.Text = "        ";
            // 
            // frmConsultaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 489);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmConsultaPagamento.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(1170, 521);
            this.Name = "frmConsultaPagamento";
            this.Text = "frmConsultaLog";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelecionarConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSelecionarConta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorOriginal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorRecebido;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorRestante;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTipo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblValorTotalRecebido;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnData;
    }
}