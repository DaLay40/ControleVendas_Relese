namespace View
{
    partial class frmEstipularValor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstipularValor));
            this.txtPorcentagemLucro = new Utilitarios.Componentes.MyTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorCompra = new Utilitarios.Componentes.MyTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemLucro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(248, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(0, 175);
            this.panelControl4.Size = new System.Drawing.Size(248, 44);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(43, 2);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Text = "Calcular";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtPorcentagemLucro);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtValorCompra);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Size = new System.Drawing.Size(248, 141);
            // 
            // txtPorcentagemLucro
            // 
            this.txtPorcentagemLucro.Location = new System.Drawing.Point(32, 93);
            this.txtPorcentagemLucro.Name = "txtPorcentagemLucro";
            this.txtPorcentagemLucro.Required = true;
            this.txtPorcentagemLucro.RequiredMessege = "Infrome a porcentagem de lucro desejada.";
            this.txtPorcentagemLucro.Size = new System.Drawing.Size(55, 20);
            this.txtPorcentagemLucro.TabIndex = 8;
            this.txtPorcentagemLucro.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(93, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "%";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Porcentagem de lucro";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(32, 47);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Required = true;
            this.txtValorCompra.RequiredMessege = "Informe o valor de compra.";
            this.txtValorCompra.Size = new System.Drawing.Size(184, 20);
            this.txtValorCompra.TabIndex = 7;
            this.txtValorCompra.Tipo = Utilitarios.Enumerators.ETipoTextBox.Monetario;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(32, 28);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Valor de compra";
            // 
            // frmEstipularValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 219);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmEstipularValor.IconOptions.Icon")));
            this.Name = "frmEstipularValor";
            this.Text = "Controle Vendas - Calcular Valor";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentagemLucro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompra.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private Utilitarios.Componentes.MyTextBox txtPorcentagemLucro;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Utilitarios.Componentes.MyTextBox txtValorCompra;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}