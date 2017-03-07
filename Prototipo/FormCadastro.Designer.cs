namespace Prototipo
{
    partial class FormCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtTipoPerfil = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTelaLogin = new System.Windows.Forms.Button();
            this.lblCadastroInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(49, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(46, 108);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 16);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(46, 159);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Location = new System.Drawing.Point(46, 213);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(71, 16);
            this.lblTipoPerfil.TabIndex = 4;
            this.lblTipoPerfil.Text = "Tipo Perfil:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(49, 127);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(173, 23);
            this.txtLogin.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(49, 178);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(173, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // txtTipoPerfil
            // 
            this.txtTipoPerfil.Location = new System.Drawing.Point(49, 232);
            this.txtTipoPerfil.Name = "txtTipoPerfil";
            this.txtTipoPerfil.Size = new System.Drawing.Size(173, 23);
            this.txtTipoPerfil.TabIndex = 7;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(44, 28);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(409, 16);
            this.lblCadastro.TabIndex = 8;
            this.lblCadastro.Text = "Por favor, informe seus dados para que possamos efetuar o cadastro.";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(330, 274);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 35);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(49, 274);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 35);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnTelaLogin
            // 
            this.btnTelaLogin.Location = new System.Drawing.Point(291, 94);
            this.btnTelaLogin.Name = "btnTelaLogin";
            this.btnTelaLogin.Size = new System.Drawing.Size(126, 30);
            this.btnTelaLogin.TabIndex = 11;
            this.btnTelaLogin.Text = "Clique Aqui";
            this.btnTelaLogin.UseVisualStyleBackColor = true;
            this.btnTelaLogin.Click += new System.EventHandler(this.btnTelaLogin_Click);
            // 
            // lblCadastroInfo
            // 
            this.lblCadastroInfo.AutoSize = true;
            this.lblCadastroInfo.Location = new System.Drawing.Point(269, 70);
            this.lblCadastroInfo.Name = "lblCadastroInfo";
            this.lblCadastroInfo.Size = new System.Drawing.Size(180, 16);
            this.lblCadastroInfo.TabIndex = 12;
            this.lblCadastroInfo.Text = "Caso queira logar no sistema:";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(705, 375);
            this.Controls.Add(this.lblCadastroInfo);
            this.Controls.Add(this.btnTelaLogin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.txtTipoPerfil);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblTipoPerfil);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
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
        private System.Windows.Forms.TextBox txtTipoPerfil;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTelaLogin;
        private System.Windows.Forms.Label lblCadastroInfo;
    }
}