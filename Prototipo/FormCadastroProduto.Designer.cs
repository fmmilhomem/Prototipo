namespace Prototipo
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblImgProduto = new System.Windows.Forms.Label();
            this.chkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.abrirArqImg = new System.Windows.Forms.OpenFileDialog();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.bntCategoria = new System.Windows.Forms.Button();
            this.txtQtdProduto = new System.Windows.Forms.TextBox();
            this.lblQtdMin = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtCodImagem = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.Location = new System.Drawing.Point(12, 230);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(112, 20);
            this.txtPreco.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(12, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 22;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(9, 214);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 19;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(9, 162);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(9, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(12, 178);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(256, 21);
            this.cbCategoria.TabIndex = 28;
            this.cbCategoria.Text = "<LISTAR>";
            this.cbCategoria.DropDown += new System.EventHandler(this.cbCategoria_DropDown);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(12, 282);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(525, 282);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 31);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblImgProduto
            // 
            this.lblImgProduto.AutoSize = true;
            this.lblImgProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblImgProduto.ForeColor = System.Drawing.Color.Black;
            this.lblImgProduto.Location = new System.Drawing.Point(378, 25);
            this.lblImgProduto.Name = "lblImgProduto";
            this.lblImgProduto.Size = new System.Drawing.Size(206, 13);
            this.lblImgProduto.TabIndex = 32;
            this.lblImgProduto.Text = "Clique duas vezes na imagem para anexar";
            // 
            // chkBoxAtivo
            // 
            this.chkBoxAtivo.AutoSize = true;
            this.chkBoxAtivo.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxAtivo.ForeColor = System.Drawing.Color.Black;
            this.chkBoxAtivo.Location = new System.Drawing.Point(12, 30);
            this.chkBoxAtivo.Name = "chkBoxAtivo";
            this.chkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkBoxAtivo.TabIndex = 33;
            this.chkBoxAtivo.Text = "Ativo";
            this.chkBoxAtivo.UseVisualStyleBackColor = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(12, 126);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 20);
            this.txtDescricao.TabIndex = 35;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(9, 110);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 34;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnEstoque
            // 
            this.btnEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnEstoque.Location = new System.Drawing.Point(209, 30);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(100, 31);
            this.btnEstoque.TabIndex = 36;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // abrirArqImg
            // 
            this.abrirArqImg.InitialDirectory = "c:\\";
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.Transparent;
            this.imgBox.BackgroundImage = global::Prototipo.Properties.Resources.icoAnexarImg;
            this.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgBox.InitialImage = null;
            this.imgBox.Location = new System.Drawing.Point(381, 41);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(244, 218);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 37;
            this.imgBox.TabStop = false;
            this.imgBox.DoubleClick += new System.EventHandler(this.imgBox_DoubleClick);
            // 
            // bntCategoria
            // 
            this.bntCategoria.ForeColor = System.Drawing.Color.Black;
            this.bntCategoria.Location = new System.Drawing.Point(274, 178);
            this.bntCategoria.Name = "bntCategoria";
            this.bntCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntCategoria.Size = new System.Drawing.Size(35, 21);
            this.bntCategoria.TabIndex = 38;
            this.bntCategoria.Text = "+";
            this.bntCategoria.UseVisualStyleBackColor = true;
            this.bntCategoria.Click += new System.EventHandler(this.bntCategoria_Click);
            // 
            // txtQtdProduto
            // 
            this.txtQtdProduto.Location = new System.Drawing.Point(253, 230);
            this.txtQtdProduto.Name = "txtQtdProduto";
            this.txtQtdProduto.Size = new System.Drawing.Size(56, 20);
            this.txtQtdProduto.TabIndex = 50;
            // 
            // lblQtdMin
            // 
            this.lblQtdMin.AutoSize = true;
            this.lblQtdMin.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdMin.Location = new System.Drawing.Point(250, 214);
            this.lblQtdMin.Name = "lblQtdMin";
            this.lblQtdMin.Size = new System.Drawing.Size(62, 13);
            this.lblQtdMin.TabIndex = 51;
            this.lblQtdMin.Text = "Quantidade";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(130, 230);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(112, 20);
            this.txtDesconto.TabIndex = 52;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Location = new System.Drawing.Point(127, 214);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(104, 13);
            this.lblDesconto.TabIndex = 53;
            this.lblDesconto.Text = "Desconto Promoção";
            // 
            // txtCodImagem
            // 
            this.txtCodImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodImagem.ForeColor = System.Drawing.Color.Black;
            this.txtCodImagem.Location = new System.Drawing.Point(334, 282);
            this.txtCodImagem.Name = "txtCodImagem";
            this.txtCodImagem.Size = new System.Drawing.Size(62, 20);
            this.txtCodImagem.TabIndex = 54;
            // 
            // btnConsulta
            // 
            this.btnConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnConsulta.Location = new System.Drawing.Point(402, 267);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsulta.Size = new System.Drawing.Size(80, 46);
            this.btnConsulta.TabIndex = 55;
            this.btnConsulta.Text = "Consulta teste ID";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtCodImagem);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblQtdMin);
            this.Controls.Add(this.txtQtdProduto);
            this.Controls.Add(this.bntCategoria);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.chkBoxAtivo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblImgProduto);
            this.Controls.Add(this.imgBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCadastroProduto";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblImgProduto;
        private System.Windows.Forms.CheckBox chkBoxAtivo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.OpenFileDialog abrirArqImg;
        private System.Windows.Forms.Button bntCategoria;
        private System.Windows.Forms.TextBox txtQtdProduto;
        private System.Windows.Forms.Label lblQtdMin;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtCodImagem;
        private System.Windows.Forms.Button btnConsulta;
    }
}