﻿namespace Prototipo
{
    partial class FormNovoPedido
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
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.btnConsultarPedido = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFecharPedido = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(12, 29);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(95, 20);
            this.txtPedido.TabIndex = 26;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(12, 13);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(29, 13);
            this.lblIdPedido.TabIndex = 25;
            this.lblIdPedido.Text = "Cod:";
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.Location = new System.Drawing.Point(113, 29);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarPedido.TabIndex = 27;
            this.btnConsultarPedido.Text = "Busca Pedido";
            this.btnConsultarPedido.UseVisualStyleBackColor = true;
            this.btnConsultarPedido.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(12, 96);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(155, 20);
            this.txtProduto.TabIndex = 29;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 80);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 28;
            this.lblProduto.Text = "Produto:";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(184, 96);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(27, 23);
            this.btnAnterior.TabIndex = 30;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(217, 96);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(27, 23);
            this.btnProximo.TabIndex = 31;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 143);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(155, 20);
            this.txtQuantidade.TabIndex = 33;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 127);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 32;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtPreço
            // 
            this.txtPreço.Location = new System.Drawing.Point(12, 190);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(155, 20);
            this.txtPreço.TabIndex = 35;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 174);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 34;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 223);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 36;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(12, 240);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(155, 21);
            this.cbCliente.TabIndex = 37;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 297);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFecharPedido
            // 
            this.btnFecharPedido.Location = new System.Drawing.Point(573, 306);
            this.btnFecharPedido.Name = "btnFecharPedido";
            this.btnFecharPedido.Size = new System.Drawing.Size(100, 31);
            this.btnFecharPedido.TabIndex = 38;
            this.btnFecharPedido.Text = "Finalizar";
            this.btnFecharPedido.UseVisualStyleBackColor = true;
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(325, 29);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(348, 262);
            this.dgvPedido.TabIndex = 40;
            // 
            // FormNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 370);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFecharPedido);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtPreço);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblIdPedido);
            this.Name = "FormNovoPedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Button btnConsultarPedido;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFecharPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
    }
}