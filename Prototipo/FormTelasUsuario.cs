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
            lblUsuarioLogado.Text = u.Usuario;     
        }

        //Atalho do teclado para sub menus F8,F9 e F10
        private void FormTelasUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8:
                    subUsuarios_Click(sender, e);
                    break;

                case Keys.F9:
                    subLogout_Click(sender, e);
                    break;

                case Keys.F10:
                    subSair_Click(sender, e);
                    break;
            }
        }
    
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {            
            FormCadastroUsuario frm = new FormCadastroUsuario();
            frm.ShowDialog();
        }        

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto frm = new FormCadastroProduto(u);
            frm.ShowDialog();            
        }

        private void subClientes_Click(object sender, EventArgs e)
        {
            FormCadastroCliente frm = new FormCadastroCliente();
            frm.ShowDialog();
        }

        private void subCategorias_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            frm.ShowDialog();
        }

        private void subEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque frm = new FormEstoque();
            frm.ShowDialog();
        }

        private void subProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroProduto frm = new FormCadastroProduto(u);
            frm.ShowDialog();
        }

        private void subUsuarios_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario frm = new FormCadastroUsuario();
            frm.ShowDialog();
        }

        private void subLogout_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Close();            
        }

        private void subSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
