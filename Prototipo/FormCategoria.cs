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
using System.Data.SqlClient;

namespace Prototipo
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataTable dtResultado = clsCategoria.SelecionarCategoriaNome();
            cbCategoria.DataSource = null;

            if (!cbCategoria.Enabled)
            {
                cbCategoria.Enabled = true;
                cbCategoria.DataSource = dtResultado;
                cbCategoria.DisplayMember = "nomeCategoria";
            }
            else
            {
                cbCategoria.Enabled = false;
            }
            cbCategoria.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.Text = cbCategoria.Text;
            txtDescricao.Text = clsCategoria.SelecionarCategoriaDesc((string)txtNome.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clsCategoria c = new clsCategoria();
            c.nomeCategoria = txtNome.Text;
            c.descCategoria = txtDescricao.Text;
            if (cbCategoria.Enabled)
            {
                c.Salvar(clsCategoria.SelecionarCategoriaId(cbCategoria.Text));
                
            }
            else
            {
                c.Cadastrar();
            }

            cbCategoria.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
            MessageBox.Show("Salvo com sucesso!");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int idCategoria = clsCategoria.SelecionarCategoriaId(cbCategoria.Text);
           
            if (cbCategoria.Enabled)
            {
                clsCategoria.Deletar(idCategoria);

            }

            cbCategoria.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
            MessageBox.Show("Salvo com sucesso!");
        }
    }
}
