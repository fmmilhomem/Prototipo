using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoDataBase;

namespace Prototipo
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsEstoque est = new clsEstoque();
            est = est.Buscar(txtBoxId.Text);
            if (e != null)
            {
                //AQUI CARREGA UM DATAGRID
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }
        }
    }
}
