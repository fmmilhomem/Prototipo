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
    public partial class FormTelasUsuario : Form
    {
        private clsUsuario u;
        public FormTelasUsuario(clsUsuario u)
        {
            InitializeComponent();
            this.u = u;
            
        }

        //Atalho do teclado para sub menus F8,F9 e F10
        private void FormTelasUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8:
                    mnSubUser_Click(sender, e);
                    break;

                case Keys.F9:
                    mnSubLogout_Click(sender, e);
                    break;

                case Keys.F10:
                    mnSubSair_Click(sender, e);
                    break;
            }
        }
    

        private void mnSubUser_Click(object sender, EventArgs e)
        {
            FormCadastro frm = new FormCadastro();
            frm.ShowDialog();
        }

        private void mnSubLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
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
            FormCadastroProduto frm = new FormCadastroProduto(u);
            frm.ShowDialog();
            
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormTelasUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
