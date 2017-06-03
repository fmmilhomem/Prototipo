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
using ConexaoDataBase;


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
            clsUsuario u = new clsUsuario();
            u = u.LogarDB(txtLogin.Text, txtSenha.Text);
            if(u != null)
            {
                MessageBox.Show("SUCESSO! LOGOU!");
                FormTelasUsuario F = new FormTelasUsuario(u);
                this.Hide();
                F.ShowDialog();                
            }
            else
            {
                MessageBox.Show(" LOGIN OU SENHA INVALIDO!");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Saindo
            Application.Exit();
        }
    }
}
