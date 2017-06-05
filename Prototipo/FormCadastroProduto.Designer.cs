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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.DataGridProduto = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.Location = new System.Drawing.Point(25, 227);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(92, 20);
            this.txtPreco.TabIndex = 25;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(25, 74);
            this.txtNome.MaxLength = 70;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 22;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(22, 211);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(45, 13);
            this.lblPreco.TabIndex = 19;
            this.lblPreco.Text = "* Preço:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(22, 171);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 13);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "* Categoria:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(22, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "* Nome:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Enabled = false;
            this.cbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(25, 187);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(256, 21);
            this.cbCategoria.TabIndex = 28;
            this.cbCategoria.DropDown += new System.EventHandler(this.cbCategoria_DropDown);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(25, 282);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(534, 282);
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
            this.chkBoxAtivo.Checked = true;
            this.chkBoxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAtivo.Enabled = false;
            this.chkBoxAtivo.ForeColor = System.Drawing.Color.Black;
            this.chkBoxAtivo.Location = new System.Drawing.Point(25, 27);
            this.chkBoxAtivo.Name = "chkBoxAtivo";
            this.chkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkBoxAtivo.TabIndex = 33;
            this.chkBoxAtivo.Text = "Ativo";
            this.chkBoxAtivo.UseVisualStyleBackColor = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(25, 113);
            this.txtDescricao.MaxLength = 500;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 55);
            this.txtDescricao.TabIndex = 35;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(22, 97);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 34;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnEstoque
            // 
            this.btnEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnEstoque.Image = global::Prototipo.Properties.Resources.iconEstoque;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(180, 37);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(92, 31);
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
            this.imgBox.Enabled = false;
            this.imgBox.InitialImage = null;
            this.imgBox.Location = new System.Drawing.Point(381, 41);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(253, 235);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 37;
            this.imgBox.TabStop = false;
            this.imgBox.DoubleClick += new System.EventHandler(this.imgBox_DoubleClick);
            // 
            // bntCategoria
            // 
            this.bntCategoria.ForeColor = System.Drawing.Color.Black;
            this.bntCategoria.Location = new System.Drawing.Point(287, 187);
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
            this.txtQtdProduto.Enabled = false;
            this.txtQtdProduto.Location = new System.Drawing.Point(230, 227);
            this.txtQtdProduto.Name = "txtQtdProduto";
            this.txtQtdProduto.Size = new System.Drawing.Size(92, 20);
            this.txtQtdProduto.TabIndex = 50;
            this.txtQtdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdProduto_TextChanged);
            // 
            // lblQtdMin
            // 
            this.lblQtdMin.AutoSize = true;
            this.lblQtdMin.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdMin.Location = new System.Drawing.Point(227, 211);
            this.lblQtdMin.Name = "lblQtdMin";
            this.lblQtdMin.Size = new System.Drawing.Size(65, 13);
            this.lblQtdMin.TabIndex = 51;
            this.lblQtdMin.Text = "Quantidade:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(128, 227);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(92, 20);
            this.txtDesconto.TabIndex = 52;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Location = new System.Drawing.Point(125, 211);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(86, 13);
            this.lblDesconto.TabIndex = 53;
            this.lblDesconto.Text = "Desc Promoção:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::Prototipo.Properties.Resources.iconsearch;
            this.btnBuscar.Location = new System.Drawing.Point(327, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 31);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // DataGridProduto
            // 
            this.DataGridProduto.AllowUserToAddRows = false;
            this.DataGridProduto.AllowUserToDeleteRows = false;
            this.DataGridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridProduto.BackgroundColor = System.Drawing.Color.Silver;
            this.DataGridProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridProduto.Location = new System.Drawing.Point(25, 96);
            this.DataGridProduto.MultiSelect = false;
            this.DataGridProduto.Name = "DataGridProduto";
            this.DataGridProduto.ReadOnly = true;
            this.DataGridProduto.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.DataGridProduto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridProduto.Size = new System.Drawing.Size(347, 180);
            this.DataGridProduto.TabIndex = 55;
            this.DataGridProduto.Visible = false;
            this.DataGridProduto.SelectionChanged += new System.EventHandler(this.DataGridProduto_SelectionChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = global::Prototipo.Properties.Resources.iconEditar;
            this.btnEditar.Location = new System.Drawing.Point(277, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 31);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.DataGridProduto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduto)).EndInit();
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView DataGridProduto;
        private System.Windows.Forms.Button btnEditar;
    }
}