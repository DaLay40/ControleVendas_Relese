namespace View
{
    partial class frmRel001ProdutosMaisVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRel001ProdutosMaisVendidos));
            this.dtFim = new DevExpress.XtraEditors.DateEdit();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboMarca = new Utilitarios.Componentes.MyComboBox();
            this.txtConteudoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConteudoView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(319, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(0, 241);
            this.panelControl4.Size = new System.Drawing.Size(319, 44);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(114, 2);
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageOptions.Image = global::View.Properties.Resources.IconeImprimir_16px;
            this.btnConsultar.Location = new System.Drawing.Point(118, 9);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(37, 9);
            this.btnSalvar.Visible = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cboMarca);
            this.panelControl2.Controls.Add(this.dtFim);
            this.panelControl2.Controls.Add(this.dtInicio);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Size = new System.Drawing.Size(319, 207);
            // 
            // dtFim
            // 
            this.dtFim.EditValue = null;
            this.dtFim.Location = new System.Drawing.Point(37, 152);
            this.dtFim.Name = "dtFim";
            this.dtFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFim.Size = new System.Drawing.Size(100, 20);
            this.dtFim.TabIndex = 9;
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = null;
            this.dtInicio.Location = new System.Drawing.Point(37, 104);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Size = new System.Drawing.Size(100, 20);
            this.dtInicio.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Data Final";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Data inicio";
            // 
            // cboMarca
            // 
            this.cboMarca.DataSource = null;
            this.cboMarca.DisplayMember = "";
            this.cboMarca.IdObjetoRetorno = null;
            this.cboMarca.Location = new System.Drawing.Point(37, 50);
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
            this.cboMarca.Required = false;
            this.cboMarca.RequiredMessage = null;
            this.cboMarca.SelectedIndex = -1;
            this.cboMarca.SelectedItem = null;
            this.cboMarca.SelectedValue = null;
            this.cboMarca.Size = new System.Drawing.Size(120, 20);
            this.cboMarca.TabIndex = 16;
            // 
            // txtConteudoView
            // 
            this.txtConteudoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtConteudoView.Name = "txtConteudoView";
            this.txtConteudoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtConteudoView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Marca";
            // 
            // frmRel001ProdutosMaisVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(319, 285);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmRel001ProdutosMaisVendidos.IconOptions.Icon")));
            this.Name = "frmRel001ProdutosMaisVendidos";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConteudoView)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        public DevExpress.XtraEditors.DateEdit dtFim;
        public DevExpress.XtraEditors.DateEdit dtInicio;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        private Utilitarios.Componentes.MyComboBox cboMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView txtConteudoView;
        public DevExpress.XtraEditors.LabelControl labelControl1;
    }
}