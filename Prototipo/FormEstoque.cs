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

            if (txtBoxId.Text == string.Empty)
            {
                List<clsEstoque> est = clsEstoque.SelecionarProduto();
                DataGridEstoque.DataSource = est;
                DataGridEstoque.Columns[0].Visible = false;
            }
            else
            {
                List<clsEstoque> est = clsEstoque.SelecionarProduto(int.Parse(txtBoxId.Text));

                if (est != null)
                {
                    DataGridEstoque.DataSource = est;
                    DataGridEstoque.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado");
                }
            }
        }
    }
}
