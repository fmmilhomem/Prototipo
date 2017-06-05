namespace Prototipo
{
    partial class FormCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblAlterarCadastro = new System.Windows.Forms.Label();
            this.cbTipoPerfil = new System.Windows.Forms.ComboBox();
            this.DataGridUsuario = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(15, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "*Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(18, 87);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 23);
            this.txtNome.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(15, 119);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 16);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "*Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(15, 173);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 16);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "*Senha:";
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblTipoPerfil.Location = new System.Drawing.Point(15, 224);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(79, 16);
            this.lblTipoPerfil.TabIndex = 4;
            this.lblTipoPerfil.Text = "*Tipo Perfil:";
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(18, 138);
            this.txtLogin.MaxLength = 100;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(224, 23);
            this.txtLogin.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(18, 192);
            this.txtSenha.MaxLength = 64;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(224, 23);
            this.txtSenha.TabIndex = 8;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblCadastro.Location = new System.Drawing.Point(15, 14);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(497, 16);
            this.lblCadastro.TabIndex = 13;
            this.lblCadastro.Text = "Informe os dados para efetuarmos o cadastro ou clique e altere os dados do usuári" +
    "o.";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(557, 288);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 35);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(18, 288);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 35);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAlterarCadastro
            // 
            this.lblAlterarCadastro.AutoSize = true;
            this.lblAlterarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblAlterarCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblAlterarCadastro.Location = new System.Drawing.Point(291, 44);
            this.lblAlterarCadastro.Name = "lblAlterarCadastro";
            this.lblAlterarCadastro.Size = new System.Drawing.Size(298, 16);
            this.lblAlterarCadastro.TabIndex = 14;
            this.lblAlterarCadastro.Text = "Clique para buscar os usuários e selecione abaixo:";
            // 
            // cbTipoPerfil
            // 
            this.cbTipoPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPerfil.Enabled = false;
            this.cbTipoPerfil.ForeColor = System.Drawing.Color.Black;
            this.cbTipoPerfil.FormattingEnabled = true;
            this.cbTipoPerfil.Items.AddRange(new object[] {
            "A",
            "E"});
            this.cbTipoPerfil.Location = new System.Drawing.Point(18, 243);
            this.cbTipoPerfil.Name = "cbTipoPerfil";
            this.cbTipoPerfil.Size = new System.Drawing.Size(224, 24);
            this.cbTipoPerfil.TabIndex = 9;
            // 
            // DataGridUsuario
            // 
            this.DataGridUsuario.AllowUserToAddRows = false;
            this.DataGridUsuario.AllowUserToDeleteRows = false;
            this.DataGridUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridUsuario.BackgroundColor = System.Drawing.Color.Silver;
            this.DataGridUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUsuario.Location = new System.Drawing.Point(248, 66);
            this.DataGridUsuario.MultiSelect = false;
            this.DataGridUsuario.Name = "DataGridUsuario";
            this.DataGridUsuario.ReadOnly = true;
            this.DataGridUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUsuario.Size = new System.Drawing.Size(396, 201);
            this.DataGridUsuario.TabIndex = 12;
            this.DataGridUsuario.SelectionChanged += new System.EventHandler(this.DataGridUsuario_SelectionChanged);
            this.DataGridUsuario.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::Prototipo.Properties.Resources.iconsearch;
            this.btnBuscar.Location = new System.Drawing.Point(595, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 22);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkBoxAtivo
            // 
            this.chkBoxAtivo.AutoSize = true;
            this.chkBoxAtivo.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxAtivo.Checked = true;
            this.chkBoxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAtivo.Enabled = false;
            this.chkBoxAtivo.ForeColor = System.Drawing.Color.Black;
            this.chkBoxAtivo.Location = new System.Drawing.Point(18, 44);
            this.chkBoxAtivo.Name = "chkBoxAtivo";
            this.chkBoxAtivo.Size = new System.Drawing.Size(55, 20);
            this.chkBoxAtivo.TabIndex = 1;
            this.chkBoxAtivo.Text = "Ativo";
            this.chkBoxAtivo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = global::Prototipo.Properties.Resources.iconEditar;
            this.btnEditar.Location = new System.Drawing.Point(171, 45);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 22);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Image = global::Prototipo.Properties.Resources.icoNovo;
            this.btnNovo.Location = new System.Drawing.Point(136, 45);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(36, 22);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = global::Prototipo.Properties.Resources.iconLixeira;
            this.btnDeletar.Location = new System.Drawing.Point(206, 45);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(36, 22);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Prototipo.Properties.Resources.imgFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.chkBoxAtivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.DataGridUsuario);
            this.Controls.Add(this.cbTipoPerfil);
            this.Controls.Add(this.lblAlterarCadastro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblTipoPerfil);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblAlterarCadastro;
        private System.Windows.Forms.ComboBox cbTipoPerfil;
        private System.Windows.Forms.DataGridView DataGridUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkBoxAtivo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnDeletar;
    }
}