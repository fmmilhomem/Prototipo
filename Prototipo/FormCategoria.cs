﻿using System;
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled)
            {
                btnEditar.Enabled = false;
                txtNome.Enabled = true;
                txtDescricao.Enabled = true;
                cbCategoria.DataSource = null;
            }
            else
            {
                btnEditar.Enabled = true;
                txtNome.Enabled = false;
                txtDescricao.Enabled = false;
                txtNome.Clear();
                txtDescricao.Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnNovo.Enabled)
            {
                btnNovo.Enabled = false;
                btnDeletar.Enabled = true;
                cbCategoria.Enabled = true;
            }
            else
            {
                btnNovo.Enabled = true;
                btnDeletar.Enabled = false;
                cbCategoria.DataSource = null;
                cbCategoria.Text = null;
                cbCategoria.Enabled = false;
                txtNome.Enabled = false;
                txtDescricao.Enabled = false;
                txtNome.Clear();
                txtDescricao.Clear();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clsCategoria c = new clsCategoria();
            c.nomeCategoria = txtNome.Text;
            c.descCategoria = txtDescricao.Text;

            if(btnNovo.Enabled == true)
            {
                c.Salvar(0);
            }
            else if(btnEditar.Enabled == true && cbCategoria.SelectedValue != null)
            {
                if (Convert.ToInt16(cbCategoria.SelectedValue) > 6)
                {
                    string msg = c.Salvar(Convert.ToInt16(cbCategoria.SelectedValue));
                    MessageBox.Show(msg); //Acertar
                    refresh_cbCategoria(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
                }
                else
                {
                    MessageBox.Show("Acesso Negado a esta categoria!");
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedValue != null)
            {
                int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);

                if (idCategoria > 6)
                {
                    string msg = clsCategoria.Deletar(idCategoria);
                    MessageBox.Show(msg);
                    refresh_cbCategoria(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.  
                }
                else
                {
                    MessageBox.Show("Acesso Negado a esta categoria!");
                }
            }
            else
            {
                MessageBox.Show("Liste para selecionar a categoria!");
            }         
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.Text = cbCategoria.Text;
            txtDescricao.Text = clsCategoria.SelecionarCategoriaDesc((string)txtNome.Text);
        }

        private void refresh_cbCategoria()
        {
            DataTable dtResultado = clsCategoria.SelecionarCategoriaNome();
            cbCategoria.DataSource = null;
            cbCategoria.DataSource = dtResultado;
            cbCategoria.DisplayMember = "nomeCategoria";
            cbCategoria.ValueMember = "idCategoria";
            cbCategoria.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private void cbCategoria_DropDown(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            refresh_cbCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text != string.Empty)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }
    }
}
