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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelasUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.mnSubArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.subLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.subSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.subClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.subEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.subProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.subUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.subSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblUsuarioSair = new System.Windows.Forms.Label();
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
            this.btnCadastroProduto.Location = new System.Drawing.Point(256, 183);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(180, 149);
            this.btnCadastroProduto.TabIndex = 5;
            this.btnCadastroProduto.Text = "Cadastro Produto";
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroUsuario.Image = global::Prototipo.Properties.Resources.iconUsuarios;
            this.btnCadastroUsuario.Location = new System.Drawing.Point(447, 28);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(180, 149);
            this.btnCadastroUsuario.TabIndex = 4;
            this.btnCadastroUsuario.Text = "Cadastro Usuários";
            this.btnCadastroUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroCliente_Click);
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
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.Image = global::Prototipo.Properties.Resources.iconCliente;
            this.btnCadastroCliente.Location = new System.Drawing.Point(256, 28);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(180, 149);
            this.btnCadastroCliente.TabIndex = 10;
            this.btnCadastroCliente.Text = "Cadastro Clientes";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // mnSubArquivo
            // 
            this.mnSubArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subLogout,
            this.subSair});
            this.mnSubArquivo.Name = "mnSubArquivo";
            this.mnSubArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnSubArquivo.Text = "Arquivo";
            this.mnSubArquivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subLogout
            // 
            this.subLogout.Name = "subLogout";
            this.subLogout.Size = new System.Drawing.Size(162, 22);
            this.subLogout.Text = "Logoff            F9";
            this.subLogout.Click += new System.EventHandler(this.subLogout_Click);
            // 
            // subSair
            // 
            this.subSair.Name = "subSair";
            this.subSair.Size = new System.Drawing.Size(162, 22);
            this.subSair.Text = "Sair                 F10";
            this.subSair.Click += new System.EventHandler(this.subSair_Click);
            // 
            // mnSubEditar
            // 
            this.mnSubEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subClientes,
            this.subCategorias,
            this.subEstoque,
            this.subProdutos,
            this.subUsuarios});
            this.mnSubEditar.Name = "mnSubEditar";
            this.mnSubEditar.Size = new System.Drawing.Size(49, 20);
            this.mnSubEditar.Text = "Editar";
            this.mnSubEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subClientes
            // 
            this.subClientes.Name = "subClientes";
            this.subClientes.Size = new System.Drawing.Size(130, 22);
            this.subClientes.Text = "Clientes";
            this.subClientes.Click += new System.EventHandler(this.subClientes_Click);
            // 
            // subCategorias
            // 
            this.subCategorias.Name = "subCategorias";
            this.subCategorias.Size = new System.Drawing.Size(130, 22);
            this.subCategorias.Text = "Categorias";
            this.subCategorias.Click += new System.EventHandler(this.subCategorias_Click);
            // 
            // subEstoque
            // 
            this.subEstoque.Name = "subEstoque";
            this.subEstoque.Size = new System.Drawing.Size(130, 22);
            this.subEstoque.Text = "Estoque";
            this.subEstoque.Click += new System.EventHandler(this.subEstoque_Click);
            // 
            // subProdutos
            // 
            this.subProdutos.Name = "subProdutos";
            this.subProdutos.Size = new System.Drawing.Size(130, 22);
            this.subProdutos.Text = "Produtos";
            this.subProdutos.Click += new System.EventHandler(this.subProdutos_Click);
            // 
            // subUsuarios
            // 
            this.subUsuarios.Name = "subUsuarios";
            this.subUsuarios.Size = new System.Drawing.Size(130, 22);
            this.subUsuarios.Text = "Usuários";
            this.subUsuarios.Click += new System.EventHandler(this.subUsuarios_Click);
            // 
            // mnSubAjuda
            // 
            this.mnSubAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subSobre});
            this.mnSubAjuda.Name = "mnSubAjuda";
            this.mnSubAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnSubAjuda.Text = "Ajuda";
            this.mnSubAjuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subSobre
            // 
            this.subSobre.Name = "subSobre";
            this.subSobre.Size = new System.Drawing.Size(104, 22);
            this.subSobre.Text = "Sobre";
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSubArquivo,
            this.mnSubEditar,
            this.mnSubAjuda});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnPrincipal.Size = new System.Drawing.Size(661, 24);
            this.mnPrincipal.TabIndex = 9;
            this.mnPrincipal.Text = "mnPrincipal";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(446, 3);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(12, 16);
            this.lblUsuarioLogado.TabIndex = 11;
            this.lblUsuarioLogado.Text = " ";
            // 
            // lblUsuarioSair
            // 
            this.lblUsuarioSair.AutoSize = true;
            this.lblUsuarioSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsuarioSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuarioSair.Location = new System.Drawing.Point(285, 3);
            this.lblUsuarioSair.Name = "lblUsuarioSair";
            this.lblUsuarioSair.Size = new System.Drawing.Size(156, 16);
            this.lblUsuarioSair.TabIndex = 12;
            this.lblUsuarioSair.Text = "logoff (F9)          Usuário:";
            // 
            // FormTelasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Prototipo.Properties.Resources.imgFundo;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.lblUsuarioSair);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnPrincipal);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormTelasUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTelasUsuario_KeyDown);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem mnSubArquivo;
        private System.Windows.Forms.ToolStripMenuItem subLogout;
        private System.Windows.Forms.ToolStripMenuItem subSair;
        private System.Windows.Forms.ToolStripMenuItem mnSubEditar;
        private System.Windows.Forms.ToolStripMenuItem mnSubAjuda;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem subClientes;
        private System.Windows.Forms.ToolStripMenuItem subCategorias;
        private System.Windows.Forms.ToolStripMenuItem subEstoque;
        private System.Windows.Forms.ToolStripMenuItem subProdutos;
        private System.Windows.Forms.ToolStripMenuItem subUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subSobre;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblUsuarioSair;
    }
}