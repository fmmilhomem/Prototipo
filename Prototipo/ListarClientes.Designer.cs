﻿namespace Prototipo
{
    partial class ListarClientes
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
            this.DataGridCliente = new System.Windows.Forms.DataGridView();
            this.btListarClientes = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridCliente
            // 
            this.DataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCliente.Location = new System.Drawing.Point(85, 12);
            this.DataGridCliente.Name = "DataGridCliente";
            this.DataGridCliente.Size = new System.Drawing.Size(845, 315);
            this.DataGridCliente.TabIndex = 0;
            // 
            // btListarClientes
            // 
            this.btListarClientes.Location = new System.Drawing.Point(4, 78);
            this.btListarClientes.Name = "btListarClientes";
            this.btListarClientes.Size = new System.Drawing.Size(75, 110);
            this.btListarClientes.TabIndex = 1;
            this.btListarClientes.Text = "Listar Clientes";
            this.btListarClientes.UseVisualStyleBackColor = true;
            this.btListarClientes.Click += new System.EventHandler(this.btListarClientes_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(4, 246);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(942, 339);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btListarClientes);
            this.Controls.Add(this.DataGridCliente);
            this.Name = "ListarClientes";
            this.Text = "ListarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridCliente;
        private System.Windows.Forms.Button btListarClientes;
        private System.Windows.Forms.Button btnFechar;
    }
}