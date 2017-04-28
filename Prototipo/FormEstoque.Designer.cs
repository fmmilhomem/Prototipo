namespace Prototipo
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblImgProduto = new System.Windows.Forms.Label();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.DataGridEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxId
            // 
            this.txtBoxId.ForeColor = System.Drawing.Color.Black;
            this.txtBoxId.Location = new System.Drawing.Point(44, 49);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(42, 20);
            this.txtBoxId.TabIndex = 0;
            this.txtBoxId.TextChanged += new System.EventHandler(this.txtBoxId_TextChanged);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.ForeColor = System.Drawing.Color.Black;
            this.txtBoxNome.Location = new System.Drawing.Point(92, 49);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNome.TabIndex = 1;
            this.txtBoxNome.TextChanged += new System.EventHandler(this.txtBoxNome_TextChanged);
            // 
            // lblImgProduto
            // 
            this.lblImgProduto.AutoSize = true;
            this.lblImgProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblImgProduto.ForeColor = System.Drawing.Color.Black;
            this.lblImgProduto.Location = new System.Drawing.Point(383, 33);
            this.lblImgProduto.Name = "lblImgProduto";
            this.lblImgProduto.Size = new System.Drawing.Size(87, 13);
            this.lblImgProduto.TabIndex = 33;
            this.lblImgProduto.Text = "Imagem Produto:";
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblIdProduto.ForeColor = System.Drawing.Color.Black;
            this.lblIdProduto.Location = new System.Drawing.Point(41, 33);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(29, 13);
            this.lblIdProduto.TabIndex = 35;
            this.lblIdProduto.Text = "Cod:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(89, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "Nome:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(44, 261);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Fechar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(536, 261);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 31);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // imgProduto
            // 
            this.imgProduto.Location = new System.Drawing.Point(386, 49);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(250, 206);
            this.imgProduto.TabIndex = 32;
            this.imgProduto.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::Prototipo.Properties.Resources.iconsearch;
            this.btnBuscar.Location = new System.Drawing.Point(298, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 23);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // DataGridEstoque
            // 
            this.DataGridEstoque.AllowUserToAddRows = false;
            this.DataGridEstoque.AllowUserToDeleteRows = false;
            this.DataGridEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEstoque.BackgroundColor = System.Drawing.Color.Silver;
            this.DataGridEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEstoque.Location = new System.Drawing.Point(44, 75);
            this.DataGridEstoque.MultiSelect = false;
            this.DataGridEstoque.Name = "DataGridEstoque";
            this.DataGridEstoque.ReadOnly = true;
            this.DataGridEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEstoque.Size = new System.Drawing.Size(313, 180);
            this.DataGridEstoque.TabIndex = 49;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.DataGridEstoque);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.lblImgProduto);
            this.Controls.Add(this.imgProduto);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxId);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEstoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.Label lblImgProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView DataGridEstoque;
    }
}