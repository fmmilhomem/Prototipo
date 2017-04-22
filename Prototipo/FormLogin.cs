using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prototipo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //TODO : RETIRAR APOS CONECTADO COM DB
            string login = "admin";
            string senha = "admin";

            if ((txtLogin.Text == login) && (txtSenha.Text == senha))
            {
                MessageBox.Show("Logado com sucesso!");                
                FormTelasUsuario telas = new FormTelasUsuario();
                telas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha errado");
            }
        }

        private void btnQueroCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.ShowDialog();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Atalho do teclado para sub menus F8,F9 e F10
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnEntrar_Click(sender, e); //Chama o botão de entrar no sistema
                    break;

                case Keys.F10:
                    btnCancelar_Click(sender, e); //Chama o botão de sair no sistema
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Saindo
            Application.Exit();
        }
    }
}
