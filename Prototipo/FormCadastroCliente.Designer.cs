namespace Prototipo
{
    partial class FormCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
            this.lblFormCadastroCliente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefoneComercia = new System.Windows.Forms.Label();
            this.lblTelefoneResidencial = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefoneComercial = new System.Windows.Forms.TextBox();
            this.txtTelefoneResidencial = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkBoxNew = new System.Windows.Forms.CheckBox();
            this.lblChkBoxNL = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormCadastroCliente
            // 
            this.lblFormCadastroCliente.AutoSize = true;
            this.lblFormCadastroCliente.Location = new System.Drawing.Point(39, 23);
            this.lblFormCadastroCliente.Name = "lblFormCadastroCliente";
            this.lblFormCadastroCliente.Size = new System.Drawing.Size(269, 16);
            this.lblFormCadastroCliente.TabIndex = 0;
            this.lblFormCadastroCliente.Text = "Entre com os dados para cadastro do Cliente.";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(39, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(342, 52);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 16);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(39, 143);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(53, 16);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefoneComercia
            // 
            this.lblTelefoneComercia.AutoSize = true;
            this.lblTelefoneComercia.Location = new System.Drawing.Point(194, 143);
            this.lblTelefoneComercia.Name = "lblTelefoneComercia";
            this.lblTelefoneComercia.Size = new System.Drawing.Size(92, 16);
            this.lblTelefoneComercia.TabIndex = 6;
            this.lblTelefoneComercia.Text = "Tel Comercial:";
            // 
            // lblTelefoneResidencial
            // 
            this.lblTelefoneResidencial.AutoSize = true;
            this.lblTelefoneResidencial.Location = new System.Drawing.Point(342, 143);
            this.lblTelefoneResidencial.Name = "lblTelefoneResidencial";
            this.lblTelefoneResidencial.Size = new System.Drawing.Size(99, 16);
            this.lblTelefoneResidencial.TabIndex = 7;
            this.lblTelefoneResidencial.Text = "Tel Residencial:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(211, 239);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(95, 16);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "Dt Nascimento:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(391, 287);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 31);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(42, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 23);
            this.txtNome.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(42, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(449, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(345, 71);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(146, 23);
            this.txtCPF.TabIndex = 12;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_TextChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(42, 162);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(146, 23);
            this.txtCelular.TabIndex = 13;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_TextChanged);
            // 
            // txtTelefoneComercial
            // 
            this.txtTelefoneComercial.Location = new System.Drawing.Point(194, 162);
            this.txtTelefoneComercial.Name = "txtTelefoneComercial";
            this.txtTelefoneComercial.Size = new System.Drawing.Size(146, 23);
            this.txtTelefoneComercial.TabIndex = 14;
            // 
            // txtTelefoneResidencial
            // 
            this.txtTelefoneResidencial.Location = new System.Drawing.Point(345, 162);
            this.txtTelefoneResidencial.Name = "txtTelefoneResidencial";
            this.txtTelefoneResidencial.Size = new System.Drawing.Size(146, 23);
            this.txtTelefoneResidencial.TabIndex = 15;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(42, 254);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(146, 23);
            this.txtSenha.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chkBoxNew
            // 
            this.chkBoxNew.AutoSize = true;
            this.chkBoxNew.Location = new System.Drawing.Point(364, 304);
            this.chkBoxNew.Name = "chkBoxNew";
            this.chkBoxNew.Size = new System.Drawing.Size(15, 14);
            this.chkBoxNew.TabIndex = 18;
            this.chkBoxNew.UseVisualStyleBackColor = true;
            // 
            // lblChkBoxNL
            // 
            this.lblChkBoxNL.AutoSize = true;
            this.lblChkBoxNL.Location = new System.Drawing.Point(238, 302);
            this.lblChkBoxNL.Name = "lblChkBoxNL";
            this.lblChkBoxNL.Size = new System.Drawing.Size(120, 16);
            this.lblChkBoxNL.TabIndex = 19;
            this.lblChkBoxNL.Text = "Receber Newsletter";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(42, 287);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(42, 209);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(449, 23);
            this.txtEndereco.TabIndex = 22;
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(39, 190);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(61, 16);
            this.lblEndereço.TabIndex = 21;
            this.lblEndereço.Text = "Endereço";
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblChkBoxNL);
            this.Controls.Add(this.chkBoxNew);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtTelefoneResidencial);
            this.Controls.Add(this.txtTelefoneComercial);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblTelefoneResidencial);
            this.Controls.Add(this.lblTelefoneComercia);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblFormCadastroCliente);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormCadastroCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefoneComercia;
        private System.Windows.Forms.Label lblTelefoneResidencial;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefoneComercial;
        private System.Windows.Forms.TextBox txtTelefoneResidencial;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkBoxNew;
        private System.Windows.Forms.Label lblChkBoxNL;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereço;
    }
}