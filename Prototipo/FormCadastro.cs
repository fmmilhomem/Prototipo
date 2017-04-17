using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnTelaLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormTelasUsuario>().Count() > 0)
            {
                lblCadastroInfo.Visible = false;
                btnTelaLogin.Visible = false;
                btnSair.Text = "Voltar";
            }
            else
            {
                lblCadastroInfo.Visible = true;
                btnTelaLogin.Visible = true;
                btnSair.Text = "Sair";
            }
        }
    }
}
