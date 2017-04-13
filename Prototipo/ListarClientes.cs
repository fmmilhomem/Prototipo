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
            this.Close();
        }
        /*private void dataGridView1_SelectionChanged(object sender, EventArgs e)
{
   if (DataGridCliente.SelectedRows.Count > 0)
   {
       txtNo.Text = DataGridCliente.SelectedRows[0].Cells[1].Value.ToString();
       txtEmailCliente.Text = DataGridCliente.SelectedRows[0].Cells[2].Value.ToString();
       txtCPFCliente.Text = DataGridCliente.SelectedRows[0].Cells[4].Value.ToString();
       txtCelularCliente.Text = DataGridCliente.SelectedRows[0].Cells[5].Value.ToString();
       //txtTelComercialCliente.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
       //txtTelResidencialCliente.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
       txtDataNascimentoCliente.Text = DataGridCliente.SelectedRows[0].Cells[8].Value.ToString();
   }
}*/
    }
}
