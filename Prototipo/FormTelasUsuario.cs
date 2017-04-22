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

        private void mnSubUser_Click(object sender, EventArgs e)
        {
            FormCadastro frm = new FormCadastro();
            frm.ShowDialog();
        }

        private void mnSubConPedido_Click(object sender, EventArgs e)
        {

        }

        private void mnSubSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            //this.Close();
            FormCadastroCliente frm = new FormCadastroCliente();
            frm.ShowDialog();
            
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            //this.Close();
            //FormNovoPedido frm = new FormNovoPedido();
            //frm.ShowDialog();
            FormConsultarPedido frm = new FormConsultarPedido();
            frm.ShowDialog();

        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
           // this.Close();
            FormCadastroProduto frm = new FormCadastroProduto();
            frm.ShowDialog();
            
        }

        private void mnSubLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
