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
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou senha errado");
            }


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Saindo
            Application.Exit();
        }

        private void btnQueroCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.Show();
        }
    }
}
