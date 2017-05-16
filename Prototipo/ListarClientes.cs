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

        private void DataGridCliente_SelectionChanged(object sender, EventArgs e)
        {            
            if (DataGridCliente.SelectedRows.Count > 0)
            {
                txtNome.Text = DataGridCliente.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = DataGridCliente.SelectedRows[0].Cells[2].Value.ToString();
                txtCPF.Text = DataGridCliente.SelectedRows[0].Cells[4].Value.ToString();
                txtCelular.Text = DataGridCliente.SelectedRows[0].Cells[5].Value.ToString();
                txtTelefoneComercial.Text = DataGridCliente.SelectedRows[0].Cells[6].Value.ToString();
                txtTelefoneResidencial.Text = DataGridCliente.SelectedRows[0].Cells[7].Value.ToString();
                dtDataNasc.Text = DataGridCliente.SelectedRows[0].Cells[8].Value.ToString();
                txtSenha.Text = DataGridCliente.SelectedRows[0].Cells[3].Value.ToString();
                chkBoxNew.Checked = Boolean.Parse(DataGridCliente.SelectedRows[0].Cells[9].Value.ToString());
            }
        }

        private void DataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
