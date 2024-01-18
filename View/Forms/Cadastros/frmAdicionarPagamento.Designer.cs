namespace View.Forms.Cadastros
{
    partial class frmAdicionarPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarPagamento));
            this.txtValorRecebido = new Utilitarios.Componentes.MyTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorDesconto = new Utilitarios.Componentes.MyTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFormaPagamento = new Utilitarios.Componentes.MyTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblValorRestante = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRecebido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormaPagamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(302, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Size = new System.Drawing.Size(302, 44);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(97, 2);
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.Image")));
            this.btnConsultar.Text = "Historico";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblValorRestante);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtFormaPagamento);
            this.panelControl2.Controls.Add(this.txtValorDesconto);
            this.panelControl2.Controls.Add(this.txtValorRecebido);
            this.panelControl2.Size = new System.Drawing.Size(302, 250);
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Location = new System.Drawing.Point(32, 29);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Required = true;
            this.txtValorRecebido.RequiredMessege = "Informe o valor recebido.";
            this.txtValorRecebido.Size = new System.Drawing.Size(216, 20);
            this.txtValorRecebido.TabIndex = 1;
            this.txtValorRecebido.Tipo = Utilitarios.Enumerators.ETipoTextBox.Monetario;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Valor recebido";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(32, 81);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Required = false;
            this.txtValorDesconto.RequiredMessege = "";
            this.txtValorDesconto.Size = new System.Drawing.Size(216, 20);
            this.txtValorDesconto.TabIndex = 1;
            this.txtValorDesconto.Tipo = Utilitarios.Enumerators.ETipoTextBox.Monetario;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Valor de desconto";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(32, 133);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Required = true;
            this.txtFormaPagamento.RequiredMessege = "Informe a forma de pagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(216, 20);
            this.txtFormaPagamento.TabIndex = 1;
            this.txtFormaPagamento.Tipo = Utilitarios.Enumerators.ETipoTextBox.Padrao;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Forma de pagamento";
            // 
            // lblValorRestante
            // 
            this.lblValorRestante.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRestante.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblValorRestante.Appearance.Options.UseFont = true;
            this.lblValorRestante.Appearance.Options.UseForeColor = true;
            this.lblValorRestante.Location = new System.Drawing.Point(111, 190);
            this.lblValorRestante.Name = "lblValorRestante";
            this.lblValorRestante.Size = new System.Drawing.Size(49, 16);
            this.lblValorRestante.TabIndex = 2;
            this.lblValorRestante.Text = "R$ 0,00";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Valor restante:";
            // 
            // frmAdicionarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 328);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmAdicionarPagamento.IconOptions.Icon")));
            this.Name = "frmAdicionarPagamento";
            this.Text = "frmAdicionarPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRecebido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormaPagamento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Utilitarios.Componentes.MyTextBox txtValorRecebido;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Utilitarios.Componentes.MyTextBox txtValorDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Utilitarios.Componentes.MyTextBox txtFormaPagamento;
        private DevExpress.XtraEditors.LabelControl lblValorRestante;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}