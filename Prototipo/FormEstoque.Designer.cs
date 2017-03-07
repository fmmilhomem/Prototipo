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
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblImgProduto = new System.Windows.Forms.Label();
            this.txtBoxQtd = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(12, 33);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(42, 20);
            this.txtBoxId.TabIndex = 0;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(12, 77);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNome.TabIndex = 1;
            // 
            // lblImgProduto
            // 
            this.lblImgProduto.AutoSize = true;
            this.lblImgProduto.Location = new System.Drawing.Point(179, 17);
            this.lblImgProduto.Name = "lblImgProduto";
            this.lblImgProduto.Size = new System.Drawing.Size(87, 13);
            this.lblImgProduto.TabIndex = 33;
            this.lblImgProduto.Text = "Imagem Produto:";
            // 
            // txtBoxQtd
            // 
            this.txtBoxQtd.Location = new System.Drawing.Point(12, 119);
            this.txtBoxQtd.Name = "txtBoxQtd";
            this.txtBoxQtd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQtd.TabIndex = 34;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Location = new System.Drawing.Point(12, 17);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(29, 13);
            this.lblIdProduto.TabIndex = 35;
            this.lblIdProduto.Text = "Cod:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "Nome:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 103);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 37;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 245);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(243, 245);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 31);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // imgProduto
            // 
            this.imgProduto.Location = new System.Drawing.Point(182, 33);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(161, 165);
            this.imgProduto.TabIndex = 32;
            this.imgProduto.TabStop = false;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(710, 377);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.txtBoxQtd);
            this.Controls.Add(this.lblImgProduto);
            this.Controls.Add(this.imgProduto);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxId);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormEstoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.Label lblImgProduto;
        private System.Windows.Forms.TextBox txtBoxQtd;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}