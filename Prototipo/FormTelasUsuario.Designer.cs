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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelasUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnSubPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubConPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubSair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que deseja fazer ?";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::Prototipo.Properties.Resources.iconSair;
            this.btnSair.Location = new System.Drawing.Point(447, 183);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(180, 149);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastroProduto.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroProduto.Image = global::Prototipo.Properties.Resources.iconProduto;
            this.btnCadastroProduto.Location = new System.Drawing.Point(251, 183);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(180, 149);
            this.btnCadastroProduto.TabIndex = 5;
            this.btnCadastroProduto.Text = "Cadastro Produto";
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.Image = global::Prototipo.Properties.Resources.iconCliente;
            this.btnCadastroCliente.Location = new System.Drawing.Point(447, 27);
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
            this.btnPedido.Enabled = false;
            this.btnPedido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.Black;
            this.btnPedido.Image = global::Prototipo.Properties.Resources.iconPedido;
            this.btnPedido.Location = new System.Drawing.Point(251, 27);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(180, 149);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "Novo Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(102, 48);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem1.Text = "Users";
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSubPrincipal});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnPrincipal.Size = new System.Drawing.Size(661, 24);
            this.mnPrincipal.TabIndex = 9;
            this.mnPrincipal.Text = "mnPrincipal";
            // 
            // mnSubPrincipal
            // 
            this.mnSubPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSubUser,
            this.mnSubConPedido,
            this.mnSubSair});
            this.mnSubPrincipal.Name = "mnSubPrincipal";
            this.mnSubPrincipal.Size = new System.Drawing.Size(56, 20);
            this.mnSubPrincipal.Text = "Arquivo";
            this.mnSubPrincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnSubUser
            // 
            this.mnSubUser.Name = "mnSubUser";
            this.mnSubUser.Size = new System.Drawing.Size(160, 22);
            this.mnSubUser.Text = "Users";
            this.mnSubUser.Click += new System.EventHandler(this.mnSubUser_Click);
            // 
            // mnSubConPedido
            // 
            this.mnSubConPedido.Name = "mnSubConPedido";
            this.mnSubConPedido.Size = new System.Drawing.Size(160, 22);
            this.mnSubConPedido.Text = "Consultar Pedidos";
            this.mnSubConPedido.Click += new System.EventHandler(this.mnSubConPedido_Click);
            // 
            // mnSubSair
            // 
            this.mnSubSair.Name = "mnSubSair";
            this.mnSubSair.Size = new System.Drawing.Size(160, 22);
            this.mnSubSair.Text = "Sair";
            this.mnSubSair.Click += new System.EventHandler(this.mnSubSair_Click);
            // 
            // FormTelasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Prototipo.Properties.Resources.imgFundo;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnPrincipal);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormTelasUsuario";
            this.Text = "Menu";
            this.contextMenuStrip2.ResumeLayout(false);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnSubPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnSubUser;
        private System.Windows.Forms.ToolStripMenuItem mnSubSair;
        private System.Windows.Forms.ToolStripMenuItem mnSubConPedido;
    }
}