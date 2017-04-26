namespace Prototipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarClientes));
            this.DataGridCliente = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btListarClientes = new System.Windows.Forms.Button();
            this.chkBoxNew = new System.Windows.Forms.CheckBox();
            this.lblChkBoxNL = new System.Windows.Forms.Label();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtTelefoneResidencial = new System.Windows.Forms.TextBox();
            this.txtTelefoneComercial = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblTelefoneResidencial = new System.Windows.Forms.Label();
            this.lblTelefoneComercia = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridCliente
            // 
            this.DataGridCliente.AllowUserToAddRows = false;
            this.DataGridCliente.AllowUserToDeleteRows = false;
            this.DataGridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCliente.BackgroundColor = System.Drawing.Color.Silver;
            this.DataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCliente.Location = new System.Drawing.Point(119, 31);
            this.DataGridCliente.MultiSelect = false;
            this.DataGridCliente.Name = "DataGridCliente";
            this.DataGridCliente.ReadOnly = true;
            this.DataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCliente.Size = new System.Drawing.Size(874, 285);
            this.DataGridCliente.TabIndex = 2;
            this.DataGridCliente.SelectionChanged += new System.EventHandler(this.DataGridCliente_SelectionChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(12, 442);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 31);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btListarClientes
            // 
            this.btListarClientes.Location = new System.Drawing.Point(12, 31);
            this.btListarClientes.Name = "btListarClientes";
            this.btListarClientes.Size = new System.Drawing.Size(100, 31);
            this.btListarClientes.TabIndex = 0;
            this.btListarClientes.Text = "Listar Clientes";
            this.btListarClientes.UseVisualStyleBackColor = true;
            this.btListarClientes.Click += new System.EventHandler(this.btListarClientes_Click);
            // 
            // chkBoxNew
            // 
            this.chkBoxNew.AutoSize = true;
            this.chkBoxNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkBoxNew.Enabled = false;
            this.chkBoxNew.ForeColor = System.Drawing.Color.Black;
            this.chkBoxNew.Location = new System.Drawing.Point(848, 459);
            this.chkBoxNew.Name = "chkBoxNew";
            this.chkBoxNew.Size = new System.Drawing.Size(15, 14);
            this.chkBoxNew.TabIndex = 11;
            this.chkBoxNew.UseVisualStyleBackColor = false;
            // 
            // lblChkBoxNL
            // 
            this.lblChkBoxNL.AutoSize = true;
            this.lblChkBoxNL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChkBoxNL.ForeColor = System.Drawing.Color.Black;
            this.lblChkBoxNL.Location = new System.Drawing.Point(749, 459);
            this.lblChkBoxNL.Name = "lblChkBoxNL";
            this.lblChkBoxNL.Size = new System.Drawing.Size(101, 13);
            this.lblChkBoxNL.TabIndex = 20;
            this.lblChkBoxNL.Text = "Receber Newsletter";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.CustomFormat = "yyyy/MM/dd";
            this.dtDataNasc.Enabled = false;
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(532, 352);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(194, 20);
            this.dtDataNasc.TabIndex = 4;
            this.dtDataNasc.Value = new System.DateTime(2017, 4, 22, 0, 0, 0, 0);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(119, 448);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(172, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // txtTelefoneResidencial
            // 
            this.txtTelefoneResidencial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneResidencial.Enabled = false;
            this.txtTelefoneResidencial.ForeColor = System.Drawing.Color.Black;
            this.txtTelefoneResidencial.Location = new System.Drawing.Point(643, 401);
            this.txtTelefoneResidencial.Name = "txtTelefoneResidencial";
            this.txtTelefoneResidencial.Size = new System.Drawing.Size(172, 20);
            this.txtTelefoneResidencial.TabIndex = 8;
            // 
            // txtTelefoneComercial
            // 
            this.txtTelefoneComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneComercial.Enabled = false;
            this.txtTelefoneComercial.ForeColor = System.Drawing.Color.Black;
            this.txtTelefoneComercial.Location = new System.Drawing.Point(830, 401);
            this.txtTelefoneComercial.Name = "txtTelefoneComercial";
            this.txtTelefoneComercial.Size = new System.Drawing.Size(163, 20);
            this.txtTelefoneComercial.TabIndex = 9;
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.Enabled = false;
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(468, 401);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(163, 20);
            this.txtCelular.TabIndex = 7;
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Enabled = false;
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(752, 352);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(241, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(119, 401);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(119, 352);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblDataNascimento.Location = new System.Drawing.Point(529, 333);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(80, 13);
            this.lblDataNascimento.TabIndex = 19;
            this.lblDataNascimento.Text = "Dt Nascimento:";
            // 
            // lblTelefoneResidencial
            // 
            this.lblTelefoneResidencial.AutoSize = true;
            this.lblTelefoneResidencial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefoneResidencial.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneResidencial.Location = new System.Drawing.Point(643, 382);
            this.lblTelefoneResidencial.Name = "lblTelefoneResidencial";
            this.lblTelefoneResidencial.Size = new System.Drawing.Size(83, 13);
            this.lblTelefoneResidencial.TabIndex = 17;
            this.lblTelefoneResidencial.Text = "Tel Residencial:";
            // 
            // lblTelefoneComercia
            // 
            this.lblTelefoneComercia.AutoSize = true;
            this.lblTelefoneComercia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefoneComercia.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneComercia.Location = new System.Drawing.Point(830, 382);
            this.lblTelefoneComercia.Name = "lblTelefoneComercia";
            this.lblTelefoneComercia.Size = new System.Drawing.Size(74, 13);
            this.lblTelefoneComercia.TabIndex = 18;
            this.lblTelefoneComercia.Text = "Tel Comercial:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCelular.ForeColor = System.Drawing.Color.Black;
            this.lblCelular.Location = new System.Drawing.Point(465, 382);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 16;
            this.lblCelular.Text = "Celular:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(752, 333);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 15;
            this.lblCPF.Text = "CPF:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(120, 382);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(120, 429);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(120, 333);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(893, 441);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 31);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Prototipo.Properties.Resources.imgFundoDuplo;
            this.ClientSize = new System.Drawing.Size(1011, 498);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chkBoxNew);
            this.Controls.Add(this.lblChkBoxNL);
            this.Controls.Add(this.dtDataNasc);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtTelefoneResidencial);
            this.Controls.Add(this.txtTelefoneComercial);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblTelefoneResidencial);
            this.Controls.Add(this.lblTelefoneComercia);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btListarClientes);
            this.Controls.Add(this.DataGridCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ListarClientes";
            this.Text = "ListarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridCliente;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btListarClientes;
        private System.Windows.Forms.CheckBox chkBoxNew;
        private System.Windows.Forms.Label lblChkBoxNL;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtTelefoneResidencial;
        private System.Windows.Forms.TextBox txtTelefoneComercial;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblTelefoneResidencial;
        private System.Windows.Forms.Label lblTelefoneComercia;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
    }
}