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
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnTelaLogin_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormTelasUsuario>().Count() > 0)
            {
                lblAlterarCadastro.Visible = false;
                btnSair.Text = "Voltar";
            }
            else
            {
                lblAlterarCadastro.Visible = true;
                btnSair.Text = "Sair";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //TODO: VERIFICAR COMO INSTANCIAR A CLASSE USUARIOS DO BANCO E VALIDAR AQUI PARA SE CADASTRAR
            if((String.IsNullOrEmpty(txtNome.Text)) && (String.IsNullOrEmpty(txtLogin.Text)) && (String.IsNullOrEmpty(txtSenha.Text)))
            {
                MessageBox.Show("INFORME OS CAMPOS PARA CADASTRAR!");
            }
            else
            {
                clsCliente c = new clsCliente();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<clsUsuario> Usuario = null;
            Usuario = clsUsuario.ConsultarUsuario();
                        
            DataGridUsuario.DataSource = Usuario;
            DataGridUsuario.Columns["ID"].Width = 20;
            DataGridUsuario.Columns["Usuario"].Width = 95;
            DataGridUsuario.Columns["Nome"].Width = 85;
            DataGridUsuario.Columns["Senha"].Visible = false;
            DataGridUsuario.Columns["Tipo"].Width = 30;
            DataGridUsuario.Columns["Ativo"].Width = 30;            
        }

        private void DataGridUsuario_SelectionChanged(object sender, EventArgs e)
        {
            //Zera o campo de qtd

            if (DataGridUsuario.SelectedRows.Count > 0)
            {
                if (DataGridUsuario.SelectedRows[0].Cells[1].Value != null)
                {
                    txtNome.Text = Convert.ToString(DataGridUsuario.SelectedRows[0].Cells["Nome"].Value);
                    txtLogin.Text = Convert.ToString(DataGridUsuario.SelectedRows[0].Cells["Usuario"].Value);
                    txtSenha.Text = Convert.ToString(DataGridUsuario.SelectedRows[0].Cells["Senha"].Value);
                    //cbTipoPerfil.DataSource = DataGridUsuario.SelectedRows[0].Cells["Tipo"].Value;
                    chkBoxAtivo.Checked = Boolean.Parse(DataGridUsuario.SelectedRows[0].Cells["Ativo"].Value.ToString());
                }
            }
        }
    }
}