namespace View.Forms.Cadastros
{
    partial class frmConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracao));
            this.chkExibirItens = new DevExpress.XtraEditors.CheckEdit();
            this.radioTabPanel = new System.Windows.Forms.RadioButton();
            this.radioMenu = new System.Windows.Forms.RadioButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pictureMenu = new DevExpress.XtraEditors.PictureEdit();
            this.pictureTabPanel = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkExibirItens.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTabPanel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(481, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(0, 347);
            this.panelControl4.Size = new System.Drawing.Size(481, 44);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(276, 2);
            // 
            // btnConsultar
            // 
            this.btnConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.Image")));
            this.btnConsultar.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Text = "Ok";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.chkExibirItens);
            this.panelControl2.Size = new System.Drawing.Size(481, 313);
            // 
            // chkExibirItens
            // 
            this.chkExibirItens.Location = new System.Drawing.Point(25, 32);
            this.chkExibirItens.Name = "chkExibirItens";
            this.chkExibirItens.Properties.Caption = "Exibir itens do pedido na tela inicial.";
            this.chkExibirItens.Size = new System.Drawing.Size(193, 20);
            this.chkExibirItens.TabIndex = 0;
            // 
            // radioTabPanel
            // 
            this.radioTabPanel.AutoSize = true;
            this.radioTabPanel.Location = new System.Drawing.Point(22, 17);
            this.radioTabPanel.Name = "radioTabPanel";
            this.radioTabPanel.Size = new System.Drawing.Size(181, 17);
            this.radioTabPanel.TabIndex = 1;
            this.radioTabPanel.TabStop = true;
            this.radioTabPanel.Text = "                                                    ";
            this.radioTabPanel.UseVisualStyleBackColor = true;
            // 
            // radioMenu
            // 
            this.radioMenu.AutoSize = true;
            this.radioMenu.Location = new System.Drawing.Point(251, 17);
            this.radioMenu.Name = "radioMenu";
            this.radioMenu.Size = new System.Drawing.Size(181, 17);
            this.radioMenu.TabIndex = 1;
            this.radioMenu.TabStop = true;
            this.radioMenu.Text = "                                                    ";
            this.radioMenu.UseVisualStyleBackColor = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.pictureMenu);
            this.panelControl3.Controls.Add(this.pictureTabPanel);
            this.panelControl3.Controls.Add(this.radioTabPanel);
            this.panelControl3.Controls.Add(this.radioMenu);
            this.panelControl3.Location = new System.Drawing.Point(12, 101);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(457, 206);
            this.panelControl3.TabIndex = 2;
            // 
            // pictureMenu
            // 
            this.pictureMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMenu.EditValue = global::View.Properties.Resources.ImagemExemploLayoutMenu;
            this.pictureMenu.Location = new System.Drawing.Point(251, 36);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureMenu.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureMenu.Size = new System.Drawing.Size(184, 140);
            this.pictureMenu.TabIndex = 47;
            // 
            // pictureTabPanel
            // 
            this.pictureTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTabPanel.EditValue = global::View.Properties.Resources.ImagemExemploLayoutTabPanel;
            this.pictureTabPanel.Location = new System.Drawing.Point(22, 36);
            this.pictureTabPanel.Name = "pictureTabPanel";
            this.pictureTabPanel.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureTabPanel.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureTabPanel.Size = new System.Drawing.Size(184, 140);
            this.pictureTabPanel.TabIndex = 46;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Layout";
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 391);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmConfiguracao.IconOptions.Icon")));
            this.Name = "frmConfiguracao";
            this.Text = "frmConfiguracao";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkExibirItens.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTabPanel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkExibirItens;
        private System.Windows.Forms.RadioButton radioMenu;
        private System.Windows.Forms.RadioButton radioTabPanel;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureMenu;
        private DevExpress.XtraEditors.PictureEdit pictureTabPanel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}