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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Enabled)
            {
                chkBoxAtivo.Enabled = true;
                txtNome.Enabled = true;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
                cbTipoPerfil.Enabled = true;
                btnDeletar.Enabled = true;
                btnSalvar.Enabled = true;
            }
            else
            {
                chkBoxAtivo.Enabled = false;
                txtNome.Enabled = false;
                txtLogin.Enabled = false;
                txtSenha.Enabled = false;
                cbTipoPerfil.Enabled = false;
                btnDeletar.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Enabled)
            {
                //Limpa DataGrid e Combobox
                DataGridUsuario.DataSource = null;
                cbTipoPerfil.SelectedItem = null;
                cbTipoPerfil.Enabled = true;
                //Desativa Botoes
                btnBuscar.Enabled = false;
                btnEditar.Enabled = false;
                //Ativa e limpa caixas
                txtNome.Enabled = true;
                txtNome.Clear();
                txtLogin.Enabled = true;
                txtLogin.Clear();
                txtSenha.Enabled = true;
                txtSenha.Clear();
                btnSalvar.Enabled = true;             
            }
            else
            {
                //Ativa busca novamente
                btnBuscar.Enabled = true;
                cbTipoPerfil.SelectedItem = null;
                //Desativa campos de cadastro
                txtNome.Enabled = false;
                txtNome.Clear();
                txtLogin.Enabled = false;
                txtLogin.Clear();
                txtSenha.Enabled = false;
                txtSenha.Clear();
                cbTipoPerfil.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //TODO: VERIFICAR COMO INSTANCIAR A CLASSE USUARIOS DO BANCO E VALIDAR AQUI PARA SE CADASTRAR
            if((string.IsNullOrEmpty(txtNome.Text)) || 
                (string.IsNullOrEmpty(txtLogin.Text)) ||
                (string.IsNullOrEmpty(txtSenha.Text)) ||
                (cbTipoPerfil.SelectedItem == null))
            {
                MessageBox.Show("PREENCHA OS CAMPOS(*) PARA SALVAR!");
            }
            else
            {
                clsUsuario u = new clsUsuario();

                if (DataGridUsuario.SelectedRows.Count > 0)
                    if (DataGridUsuario.SelectedRows[0].Cells[1].Value != null)
                        u.ID = Convert.ToInt32(DataGridUsuario.SelectedRows[0].Cells["ID"].Value);
                u.Nome = txtNome.Text;
                u.Usuario = txtLogin.Text;
                u.Senha = txtSenha.Text;
                u.Tipo = cbTipoPerfil.SelectedItem.ToString();
                u.Ativo = chkBoxAtivo.Checked;

                u.Salvar();
                MessageBox.Show("SALVO COM SUCESSO!");
                btnNovo_Click(sender, e); //Chama o metodo para cadastrar um novo
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            clsUsuario u = new clsUsuario();

            if (DataGridUsuario.SelectedRows.Count > 0)
            {
                if (DataGridUsuario.SelectedRows[0].Cells[1].Value != null)
                {
                    u.ID = Convert.ToInt32(DataGridUsuario.SelectedRows[0].Cells["ID"].Value);
                    u.Deletar();
                    MessageBox.Show("Deletado com sucesso!");
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Selecione um usuário!");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<clsUsuario> Usuario = null;
            Usuario = clsUsuario.ConsultarUsuario();
                        
            DataGridUsuario.DataSource = Usuario;
            DataGridUsuario.Columns["ID"].Width = 20;
            DataGridUsuario.Columns["Usuario"].Width = 95;
            DataGridUsuario.Columns["Nome"].Width = 85;
            DataGridUsuario.Columns["Senha"].Visible = false;
            DataGridUsuario.Columns["Tipo"].Width = 30;
            DataGridUsuario.Columns["Ativo"].Visible = false;
        }

        private void DataGridUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridUsuario.SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                if (DataGridUsuario.SelectedRows[0].Cells[1].Value != null)
                {
                    txtNome.Text = Convert.ToString(DataGridUsuario.SelectedRows[0].Cells["Nome"].Value);
                    txtLogin.Text = Convert.ToString(DataGridUsuario.SelectedRows[0].Cells["Usuario"].Value);
                    txtSenha.Text = Convert.ToString(DataGridUsuario.SelectedRows[0].Cells["Senha"].Value);
                    switch (DataGridUsuario.SelectedRows[0].Cells["Tipo"].Value.ToString())
                    {
                        case "A":
                            cbTipoPerfil.SelectedIndex = 0; //Seleciona o item para exibição na linha (index) 0
                            break;
                        default :
                            cbTipoPerfil.SelectedIndex = 1; //Seleciona o item para exibição na linha (index) 1
                            break;
                    }
                    chkBoxAtivo.Checked = Boolean.Parse(DataGridUsuario.SelectedRows[0].Cells["Ativo"].Value.ToString());
                }
            }
            else
            {
                btnEditar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}