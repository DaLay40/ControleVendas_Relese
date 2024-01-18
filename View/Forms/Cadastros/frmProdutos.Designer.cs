namespace View
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.pictureFotoProduto = new DevExpress.XtraEditors.PictureEdit();
            this.txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEstipularValor = new DevExpress.XtraEditors.SimpleButton();
            this.btnApagarImagem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCarregarImagem = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovaMarca = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorCompraProduto = new Utilitarios.Componentes.MyTextBox();
            this.txtProduto = new Utilitarios.Componentes.MyTextBox();
            this.txtValorProduto = new Utilitarios.Componentes.MyTextBox();
            this.cboTipoProduto = new Utilitarios.Componentes.MyComboBox();
            this.cboMarca = new Utilitarios.Componentes.MyComboBox();
            this.txtQuantidadeEstoque = new Utilitarios.Componentes.MyTextBox();
            this.txtCodigo = new Utilitarios.Componentes.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompraProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Size = new System.Drawing.Size(598, 34);
            // 
            // SubTitulo
            // 
            this.SubTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SubTitulo.Appearance.Options.UseFont = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(0, 424);
            this.panelControl4.Size = new System.Drawing.Size(598, 44);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(393, 2);
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
            this.panelControl2.Controls.Add(this.pictureFotoProduto);
            this.panelControl2.Controls.Add(this.txtObservacao);
            this.panelControl2.Controls.Add(this.txtValorCompraProduto);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtProduto);
            this.panelControl2.Controls.Add(this.btnEstipularValor);
            this.panelControl2.Controls.Add(this.btnApagarImagem);
            this.panelControl2.Controls.Add(this.btnCarregarImagem);
            this.panelControl2.Controls.Add(this.btnNovaMarca);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtValorProduto);
            this.panelControl2.Controls.Add(this.cboTipoProduto);
            this.panelControl2.Controls.Add(this.cboMarca);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtQuantidadeEstoque);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.txtCodigo);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Size = new System.Drawing.Size(598, 390);
            // 
            // pictureFotoProduto
            // 
            this.pictureFotoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFotoProduto.Location = new System.Drawing.Point(416, 19);
            this.pictureFotoProduto.Name = "pictureFotoProduto";
            this.pictureFotoProduto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureFotoProduto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureFotoProduto.Size = new System.Drawing.Size(160, 140);
            this.pictureFotoProduto.TabIndex = 45;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(22, 280);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(339, 91);
            this.txtObservacao.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Valor Compra:";
            // 
            // btnEstipularValor
            // 
            this.btnEstipularValor.Appearance.Options.UseTextOptions = true;
            this.btnEstipularValor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnEstipularValor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnEstipularValor.ImageOptions.Image = global::View.Properties.Resources.IconeCifrao_16px;
            this.btnEstipularValor.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEstipularValor.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEstipularValor.Location = new System.Drawing.Point(194, 128);
            this.btnEstipularValor.Name = "btnEstipularValor";
            this.btnEstipularValor.Size = new System.Drawing.Size(99, 20);
            this.btnEstipularValor.TabIndex = 28;
            this.btnEstipularValor.Text = "Estipular valor";
            // 
            // btnApagarImagem
            // 
            this.btnApagarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagarImagem.Appearance.Options.UseTextOptions = true;
            this.btnApagarImagem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnApagarImagem.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnApagarImagem.ImageOptions.Image = global::View.Properties.Resources.IconeCancelar_16px;
            this.btnApagarImagem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnApagarImagem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnApagarImagem.Location = new System.Drawing.Point(416, 163);
            this.btnApagarImagem.Name = "btnApagarImagem";
            this.btnApagarImagem.Size = new System.Drawing.Size(77, 20);
            this.btnApagarImagem.TabIndex = 33;
            this.btnApagarImagem.Text = "Apagar";
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarImagem.Appearance.Options.UseTextOptions = true;
            this.btnCarregarImagem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCarregarImagem.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCarregarImagem.ImageOptions.Image = global::View.Properties.Resources.IconeAdicionar_16px;
            this.btnCarregarImagem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCarregarImagem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCarregarImagem.Location = new System.Drawing.Point(498, 163);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(77, 20);
            this.btnCarregarImagem.TabIndex = 34;
            this.btnCarregarImagem.Text = "Carregar";
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Appearance.Options.UseTextOptions = true;
            this.btnNovaMarca.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnNovaMarca.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNovaMarca.ImageOptions.Image = global::View.Properties.Resources.IconeMarca_16px;
            this.btnNovaMarca.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNovaMarca.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNovaMarca.Location = new System.Drawing.Point(284, 164);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(102, 20);
            this.btnNovaMarca.TabIndex = 35;
            this.btnNovaMarca.Text = "Nova Marca";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Produto:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(23, 199);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 13);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "Tipo Produto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Valor:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Marca:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(22, 260);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "Observação:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 231);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "Estoque:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Codigo:";
            // 
            // txtValorCompraProduto
            // 
            this.txtValorCompraProduto.EditValue = "0,00";
            this.txtValorCompraProduto.Location = new System.Drawing.Point(97, 95);
            this.txtValorCompraProduto.Name = "txtValorCompraProduto";
            this.txtValorCompraProduto.Required = true;
            this.txtValorCompraProduto.RequiredMessege = "Informe o valor de compra do produto.";
            this.txtValorCompraProduto.Size = new System.Drawing.Size(91, 20);
            this.txtValorCompraProduto.TabIndex = 26;
            this.txtValorCompraProduto.Tipo = Utilitarios.Enumerators.ETipoTextBox.Monetario;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(97, 60);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Required = true;
            this.txtProduto.RequiredMessege = "Informe o nome do Produto.";
            this.txtProduto.Size = new System.Drawing.Size(264, 20);
            this.txtProduto.TabIndex = 25;
            this.txtProduto.Tipo = Utilitarios.Enumerators.ETipoTextBox.Padrao;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.EditValue = "0,00";
            this.txtValorProduto.Location = new System.Drawing.Point(97, 128);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Required = true;
            this.txtValorProduto.RequiredMessege = "Informe o valor do produto.";
            this.txtValorProduto.Size = new System.Drawing.Size(91, 20);
            this.txtValorProduto.TabIndex = 27;
            this.txtValorProduto.Tipo = Utilitarios.Enumerators.ETipoTextBox.Monetario;
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.DataSource = null;
            this.cboTipoProduto.DisplayMember = "";
            this.cboTipoProduto.EditValue = -1;
            this.cboTipoProduto.IdObjetoRetorno = null;
            this.cboTipoProduto.Location = new System.Drawing.Point(97, 196);
            this.cboTipoProduto.Margin = new System.Windows.Forms.Padding(0);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.NaoMudarFocoTeclaEnter = false;
            this.cboTipoProduto.NaoMudarReadOnly = false;
            this.cboTipoProduto.PermitirTextoDigitadoQueNaoEstaNaLista = false;
            this.cboTipoProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTipoProduto.Properties.NullText = "";
            this.cboTipoProduto.Required = true;
            this.cboTipoProduto.RequiredMessage = "Informe a Marca.";
            this.cboTipoProduto.SelectedIndex = -1;
            this.cboTipoProduto.SelectedItem = -1;
            this.cboTipoProduto.SelectedValue = -1;
            this.cboTipoProduto.Size = new System.Drawing.Size(184, 20);
            this.cboTipoProduto.TabIndex = 30;
            // 
            // cboMarca
            // 
            this.cboMarca.DataSource = null;
            this.cboMarca.DisplayMember = "";
            this.cboMarca.EditValue = -1;
            this.cboMarca.IdObjetoRetorno = null;
            this.cboMarca.Location = new System.Drawing.Point(97, 164);
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
            this.cboMarca.SelectedItem = -1;
            this.cboMarca.SelectedValue = -1;
            this.cboMarca.Size = new System.Drawing.Size(184, 20);
            this.cboMarca.TabIndex = 31;
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.EditValue = "1";
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(97, 228);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Required = true;
            this.txtQuantidadeEstoque.RequiredMessege = "Informe a quantidade em estoque.";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(91, 20);
            this.txtQuantidadeEstoque.TabIndex = 32;
            this.txtQuantidadeEstoque.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Required = true;
            this.txtCodigo.RequiredMessege = "Informe o codigo do produto.";
            this.txtCodigo.Size = new System.Drawing.Size(91, 20);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.Tipo = Utilitarios.Enumerators.ETipoTextBox.Numerico;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 468);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmProdutos.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle de Vendas - Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompraProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureFotoProduto;
        private DevExpress.XtraEditors.MemoEdit txtObservacao;
        private Utilitarios.Componentes.MyTextBox txtValorCompraProduto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Utilitarios.Componentes.MyTextBox txtProduto;
        private DevExpress.XtraEditors.SimpleButton btnEstipularValor;
        private DevExpress.XtraEditors.SimpleButton btnApagarImagem;
        private DevExpress.XtraEditors.SimpleButton btnCarregarImagem;
        private DevExpress.XtraEditors.SimpleButton btnNovaMarca;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Utilitarios.Componentes.MyTextBox txtValorProduto;
        private Utilitarios.Componentes.MyComboBox cboTipoProduto;
        private Utilitarios.Componentes.MyComboBox cboMarca;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Utilitarios.Componentes.MyTextBox txtQuantidadeEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Utilitarios.Componentes.MyTextBox txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}