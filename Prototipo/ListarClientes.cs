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
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void btListarClientes_Click(object sender, EventArgs e)
        {
            List<clsCliente> Clientes = clsCliente.SelecionarClientes();
            DataGridCliente.DataSource = Clientes;
            DataGridCliente.Columns[0].Visible = false;
            DataGridCliente.Columns["senhaCliente"].Visible = false;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha tela de consulta
            this.Close();
        }
    }
}
