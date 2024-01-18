namespace View
{
    partial class frmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarca));
            this.txtNome = new Utilitarios.Componentes.MyTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtComissao = new Utilitarios.Componentes.MyTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(339, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(0, 210);
            this.panelControl4.Size = new System.Drawing.Size(339, 44);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(134, 2);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtComissao);
            this.panelControl2.Controls.Add(this.txtNome);
            this.panelControl2.Size = new System.Drawing.Size(339, 176);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Required = false;
            this.txtNome.RequiredMessege = null;
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tipo = Utilitarios.Enumerators.ETipoTextBox.Padrao;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nome";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(32, 121);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Required = false;
            this.txtComissao.RequiredMessege = null;
            this.txtComissao.Size = new System.Drawing.Size(100, 20);
            this.txtComissao.TabIndex = 0;
            this.txtComissao.Tipo = Utilitarios.Enumerators.ETipoTextBox.Padrao;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Comissao";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(134, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "%";
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(339, 254);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMarca.IconOptions.Icon")));
            this.Name = "frmMarca";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissao.Properties)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Utilitarios.Componentes.MyTextBox txtComissao;
        private Utilitarios.Componentes.MyTextBox txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}