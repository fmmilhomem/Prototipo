namespace Prototipo
{
    partial class FormTelasUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que deseja fazer ?";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSair.Image = global::Prototipo.Properties.Resources.iconSair;
            this.btnSair.Location = new System.Drawing.Point(225, 235);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(180, 149);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastroProduto.Image = global::Prototipo.Properties.Resources.iconProduto;
            this.btnCadastroProduto.Location = new System.Drawing.Point(40, 235);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(180, 149);
            this.btnCadastroProduto.TabIndex = 5;
            this.btnCadastroProduto.Text = "Cadastro Produto";
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.Image = global::Prototipo.Properties.Resources.iconCliente;
            this.btnCadastroCliente.Location = new System.Drawing.Point(225, 80);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(180, 149);
            this.btnCadastroCliente.TabIndex = 4;
            this.btnCadastroCliente.Text = "Cadastro Cliente";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Image = global::Prototipo.Properties.Resources.iconPedido;
            this.btnPedido.Location = new System.Drawing.Point(40, 80);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(180, 149);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "Novo Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // FormTelasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTelasUsuario";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnSair;
    }
}