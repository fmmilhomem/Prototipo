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
    public partial class FormTelasUsuario : Form
    {
        public FormTelasUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente f = new FormCadastroCliente();
            f.Show();
            this.Hide();
        }
    }
}
